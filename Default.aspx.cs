using System;
using System.Collections;

namespace Krypton
{

	public partial class Default : System.Web.UI.Page
	{
		Random rand = new Random();

		int[] cards = new int[6];
		ArrayList openP = new ArrayList();
		ArrayList closeP = new ArrayList();
		ArrayList pairList = new ArrayList();
		ArrayList numbers = new ArrayList();
		ArrayList comands = new ArrayList();

		String answer;

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
		}

		public void checkCards(object sender, EventArgs ars)
		{
			answer = answerBox.Text;
			splitString(answer);
		}

		public void splitString(String s)
		{
			char[] c = s.ToCharArray();

			for (int i = (c.Length-1); i > 0; i--)
			{
				if (c[i] == '(')
				{
					openP.Add(i);
					Boolean end = true;
					int j = i;
					while (!end) {
						if (c[j] == ')') {
							closeP.Add(j);
							end = true;
						}
						else if (j >= (c.Length-1)) {
							end = true;
						}
						else {
							j++;
						}
					}
				}
			}
			for (int i = 0; i < c.Length; i++)
			{
				char ch = c[i];
				if (ch == '+')
					comands.Add(0);
				if (ch == '-')
					comands.Add(1);
				if (ch == '*')
					comands.Add(2);
				if (ch == '/')
					comands.Add(3);
				if (ch == '^')
					comands.Add(4);
			}

			findPairs(openP, closeP);
			doMath(pairList);
		}

		public void findPairs(ArrayList o, ArrayList c)
		{

			if (!(o.Count == c.Count))
			{
				return;
			}
			for (int i = 0; i < o.Count; i++)
			{
				NumberPair pr = new NumberPair((int) o[i], (int) c[i]);
				pairList.Add(pr);
			}
		}

		public void doMath(ArrayList a)
		{
			ArrayList strAry = new ArrayList();
			for (int i = 0; i < a.Count; i++)
			{
				NumberPair pr = (NumberPair)a[i];
				strAry.Add(answer.Substring(pr.getStart(), pr.getEnd()));
				answerBox.Text = (String) strAry[i];
			}
		}
	}
}
