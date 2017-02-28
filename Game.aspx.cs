using System;
using System.Collections;
using System.Data;

namespace Krypton
{

	public partial class Default : System.Web.UI.Page
	{
		DataTable dt = new DataTable();
		//Data cardData = new DataSet();
		Random rand = new Random();

		int[] cards = new int[6];

		String answer;
		int computedAnswer;
		Boolean canGetPoints = false;

		public void generateCards(object sender, EventArgs args)
		{
			for (int i = 0; i < cards.Length; i++)
			{
				cards[i] = (1 + rand.Next(24));
			}
			card1.Text = cards[0].ToString();
			card2.Text = cards[1].ToString();
			card3.Text = cards[2].ToString();
			card4.Text = cards[3].ToString();
			card5.Text = cards[4].ToString();
			card6.Text = cards[5].ToString();


			canGetPoints = true;
			ViewState.Add("cards", cards);
		}

		public void checkCards(object sender, EventArgs ars)
		{
			answer = answerBox.Text;
			try
			{
				computedAnswer = (int)dt.Compute(answer, "");
			}
			catch {
				computedAnswer = -1;
			}

			if (computedAnswer == -1)
			{
				label.Text = "ERROR INVALID ANSWER";
			}
			else if (computedAnswer != ((int[])ViewState["cards"])[5])
			{
				label.Text = "Answer Does not match";
			}
			else{
				label.Text = (((int[])ViewState["cards"])[5]).ToString();
			}
		}

		public void checkNums(String s)
		{
			char[] c = s.ToCharArray();

			for (int i = 0; i < c.Length; i++)
			{
				char ch = c[i];
				if (isNumber(ch)) {
					
				}
			}
		}

		public Boolean isNumber(char c)
		{
			if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
			{
				return true;
			}
			else {
				return false;
			}
		}	
	}
}
