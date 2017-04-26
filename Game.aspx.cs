using System;
using System.Collections;
using System.Data;

namespace Krypton
{

	public partial class Game : System.Web.UI.Page
	{
		DataTable dt = new DataTable();             //used to turn equations into ints
		Random rand = new Random();                 //generates random numbers

		int[] cards = new int[6];                   //stores the numbers used by cards

		String answer;                              //the computed answer as a string (used later)
		int computedAnswer;                         //the computed answer

		int pointTotal;                         //Used to save actual pointTotal
		int roundNumber;                    //Used to save actual Current Round
		int maxRound;

		public void generateCards(object sender, EventArgs args)
		{
			if ((int)Session["currentRounds"] > (int)Session["maxRounds"])
				{
				RoundMax.Text = "fIN";
				}
			else
				{
				//Update Round Counter
				maxRound = (int)Session["maxRounds"];
				RoundMax.Text = maxRound.ToString();
	
				roundNumber = (int)Session["currentRounds"];
				roundNumber = roundNumber++;
				RoundCurrent.Text = roundNumber++.ToString();
				Session["currentRounds"] = roundNumber++;
				}

			//randomly generates 
			int[] r = new int[6];
			for (int i = 0; i < cards.Length; i++)
			{            //makes a random number for each card
				do
				{
					r[i] = (1 + rand.Next(52));
				} while (!isUnique(r, i));

			}

			makeCards(r, cards);

			card1.Text = cards[0].ToString();                           //puts the cards onto the page.
			card2.Text = cards[1].ToString();
			card3.Text = cards[2].ToString();
			card4.Text = cards[3].ToString();
			card5.Text = cards[4].ToString();
			card6.Text = cards[5].ToString();

			label.Text = "";

			ViewState.Add("canGetCards", true);                                 //allows points to be obtained again.
			ViewState.Add("cards", cards);                                      //stores data
		}

		public Boolean isUnique(int[] a, int i)
		{
			for (int j = 0; j < a.Length; j++)
			{
				if (i == j || a[i] != a[j])
				{
					continue;
				}
				else {
					return false;
				}
			}
			return true;
		}

		public void makeCards(int[] r, int[] c)
		{
			for (int i = 0; i < r.Length; i++)
			{
				if (r[i] > 42)
				{
					r[i] -= 42;
				}
				else if (r[i] > 25)
				{
					r[i] -= 25;
				}
				c[i] = r[i];
			}
		}

		public void checkCards(object sender, EventArgs ars)
		{                   //checks if cards are right
			answer = ("(((((((" + answerBox.Text + ")))))))");                             //finds what is in the box
			int[] c = (int[])ViewState["cards"];                                //gets the cards out of the view
			int a = c[5];                                                       //find2ws the answer card's value
			try
			{
				computedAnswer = (int)dt.Compute(answer, "");                   //turns it into an int
			}
			catch
			{
				computedAnswer = -1;
			}
			if ((Boolean)ViewState["canGetCards"])
			{
				if (computedAnswer == -1)
				{                                   //checks if answer is correct
					label.Text = "ERROR INVALID ANSWER";
				}
				else if (computedAnswer != a)
				{
					label.Text = "Answer Does not match";
				}
				else if (contains(answer, c) && addsWell(answer, c))
				{
					label.Text = "Correct";
					ViewState.Add("canGetCards", false);

					pointTotal = (int)Session["ScoreTotal"];
					pointTotal = pointTotal++;
					Score.Text = pointTotal++.ToString();
					Session["ScoreTotal"] = pointTotal;
				}
				else {
					label.Text = "You did not use the cards correctly";
				}
			}
			else {
				label.Text = "Please Generate New Cards";
			}
		}

		public bool addsWell(string a, int[] c)
		{
			int sum = 0;
			string str = a;
			for (int i = 0; i < (c.Length - 1); i++)
			{
				sum += c[i];
			}
			str = str.Replace('*', '+');
			str = str.Replace('/', '+');
			str = str.Replace('-', '+');
			int check = (int)dt.Compute(str, "");
			label.Text = check.ToString();
			if (check == sum)
			{
				return true;
			}
			return false;
		}

		public bool contains(string a, int[] c)
		{       //checks if the answer contains all of the numbers
			int length = (c.Length - 1);                //length of the array minus two (one for the answer, one because arrays start at zero

			for (int i = 0; i < length; i++)
			{           //goes through all cards
				int n = c[i];                           //get current card
				if (containsNumber(a, n.ToString()))
				{   //does it contain the number
					continue;                           //yes?  great! keep checking
				}
				else {
					return false;                       //no?  :( end the check
				}
			}
			return true;                                //If you run through them all, your done, return true
		}

		public bool containsNumber(string big, string small)
		{                                   //checks if a string contains another string
			if (big.Contains(small))
			{                                                           //does it contain the string AND is it not surrounded by another string (2150 != 15)
				int s = big.IndexOf(small, StringComparison.Ordinal) - 1;                       //start of the small string in big string
				int e = s + small.Length + 1;                                                       //end of the small string in the big string

				if (!isNumber(big[s]) && !isNumber(big[e]))
				{           //are the edges not numbers?
					return true;                                                                //Yay! our number is alone
				}
			}
			return false;                                                                       //else: woops, not right!
		}

		public bool isNumber(char c)
		{
			if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
			{
				return true;
			}
			return false;
		}
	}
}
