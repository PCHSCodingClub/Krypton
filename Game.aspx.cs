using System;
using System.Collections;
using System.Data;

namespace Krypton
{

	public partial class Default : System.Web.UI.Page
	{
		DataTable dt = new DataTable();				//used to turn equations into ints
		Random rand = new Random();					//generates random numbers

		int[] cards = new int[6];					//stores the numbers used by cards

		String answer;								//the computed answer as a string (used later)
		int computedAnswer;							//the computed answer
		Boolean canGetPoints = false;				//makes sure that a player cannot get double points

		public void generateCards(object sender, EventArgs args)	//randomly generates 
		{
			for (int i = 0; i < cards.Length; i++)					//makes a random number for each card
			{
				cards[i] = (1 + rand.Next(24));
			}
			card1.Text = cards[0].ToString();						//puts the cards onto the page.
			card2.Text = cards[1].ToString();
			card3.Text = cards[2].ToString();
			card4.Text = cards[3].ToString();
			card5.Text = cards[4].ToString();
			card6.Text = cards[5].ToString();


			canGetPoints = true;									//allows points to be obtained again.
			ViewState.Add("cards", cards);							//stores data
		}

		public void checkCards(object sender, EventArgs ars)		//checks if cards are right
		{
			answer = answerBox.Text;								//finds what is in the box
			try
			{
				computedAnswer = (int)dt.Compute(answer, "");		//turns it into an int
			}
			catch {
				computedAnswer = -1;
			}

			if (computedAnswer == -1)								//checks if answer is correct
			{
				label.Text = "ERROR INVALID ANSWER";
			}
			else if (!canGetPoints) {
				label.Text = "Generate new cards";
			}
			else if (computedAnswer != ((int[])ViewState["cards"])[5])
			{
				label.Text = "Answer Does not match";
			}
			else{
				label.Text = (((int[])ViewState["cards"])[5]).ToString();
			}
		}

		public Boolean contains(string a, int[] c)								//not used (yet) ignore
		{
			char[] chars = a.ToCharArray();
			int length = (c.Length - 2);

			for (int i = 0; i < length; i++) {
				int n = c[i];
				if (a.Contains(n.ToString())) {
					
				}
			}
			return true;
		}
	}
}
