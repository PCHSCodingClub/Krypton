using System;
using System.Collections;
using System.Data;

namespace Krypton {

	public partial class Default : System.Web.UI.Page 	{
		DataTable dt = new DataTable();				//used to turn equations into ints
		Random rand = new Random();					//generates random numbers

		int[] cards = new int[6];					//stores the numbers used by cards

		String answer;								//the computed answer as a string (used later)
		int computedAnswer;							//the computed answer

		public void generateCards(object sender, EventArgs args) {		//randomly generates 
			for (int i = 0; i < cards.Length; i++) {					//makes a random number for each card
				cards[i] = (1 + rand.Next((int) Session["maxNumber"]));
			}
			card1.Text = cards[0].ToString();							//puts the cards onto the page.
			card2.Text = cards[1].ToString();
			card3.Text = cards[2].ToString();
			card4.Text = cards[3].ToString();
			card5.Text = cards[4].ToString();
			card6.Text = cards[5].ToString();


			ViewState.Add("canGetCards", true);									//allows points to be obtained again.
			ViewState.Add("cards", cards);										//stores data
		}

		public void checkCards(object sender, EventArgs ars) {					//checks if cards are right
			answer = ("((((((("+ answerBox.Text + ")))))))");                             //finds what is in the box
			int[] c = (int[])ViewState["cards"];								//gets the cards out of the view
			int a = c[5];														//finds the answer card's value
			try {
				computedAnswer = (int)dt.Compute(answer, "");					//turns it into an int
			}
			catch {
				computedAnswer = -1;
			}
			if ((Boolean)ViewState["canGetCards"]) {
				if (computedAnswer == -1) {                             		//checks if answer is correct
					label.Text = "ERROR INVALID ANSWER";
				}
				else if (computedAnswer != a) {
					label.Text = "Answer Does not match";
				}
				else if (contains(answer, c)) {
					label.Text = "Correct";
					ViewState.Add("canGetCards", false);
				}
				else {
					label.Text = "You did not use the cards correctly";
				}
			}
			else {
				label.Text = "Please Generate New Cards";
			}
		}

		public bool contains(string a, int[] c) {		//checks if the answer contains all of the numbers
			int length = (c.Length - 2); 				//length of the array minus two (one for the answer, one because arrays start at zero

			for (int i = 0; i < length; i++) {			//goes through all cards
				int n = c[i];							//get current card
				if (containsNumber(a,n.ToString())) {	//does it contain the number
					continue;							//yes?  great! keep checking
				}
				else {
					return false;						//no?  :( end the check
				}
			}
			return true;								//If you run through them all, your done, return true
		}

		public bool containsNumber(string big, string small) {									//checks if a string contains another string
			if (big.Contains(small)) {															//does it contain the string AND is it not surrounded by another string (2150 != 15)
				int s = big.IndexOf(small, StringComparison.Ordinal) - 1;						//start of the small string in big string
				int e = s + small.Length;														//end of the small string in the big string

				if (!isNumber(big.Substring(s,s+1)) && !isNumber(big.Substring(e, e + 1))) {	//are the edges not numbers?
					return true;																//Yay! our number is alone
				}
			}
			return false;																		//else: woops, not right!
		}

		public bool isNumber(String s) {
			if (s.Length != 1) {
				return false;
			}
			char[] ch = s.ToCharArray();
			for (int i = 0; i < ch.Length; i++)
			{
				if (ch[i] == '0' || ch[i] == '1' || ch[i] == '2' || ch[i] == '3' || ch[i] == '4' || ch[i] == '5' || ch[i] == '6' || ch[i] == '7' || ch[i] == '8' || ch[i] == '9')
				{
					return true;
				}
			}
			return false;
		}
	}
}
