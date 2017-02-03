using System;
using System.Web;
using System.Web.UI;
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
		ArrayList answerParts = new ArrayList();

		String answer;

		public void generateCards(object sender, EventArgs args)
		{
			for (int i = 0; i < cards.Length; i++) {
				cards[i] = (1+rand.Next(24));
			}
			card1.Text = cards[0].ToString();
			card2.Text = cards[1].ToString();
			card3.Text = cards[2].ToString();
			card4.Text = cards[3].ToString();
			card5.Text = cards[4].ToString();
			card6.Text = cards[5].ToString();
		}

		public void checkCards(object sender, EventArgs ars) {
			answer = answerBox.Text;
			splitString(answer);
		}

		public void splitString(String s){
			char[] c = s.ToCharArray();

			for (int i = 0; i < c.Length; i++) {
				if (c[i] == '(') {
					openP.Add(i);
				}
				else if (c[i] == ')'){
					closeP.Add(i);
				}
			}

			findPairs(openP, closeP);
			doMath(pairList);
		}

		public void findPairs(ArrayList o, ArrayList p) {
			int a;
			int b;

			if (!(o.Count == p.Count)) {
				return;
			}
			for (int i = 0; i < o.Count; i++) {
				b = (int)p[i];
				do{
					a = (int)o[(o.Count - i - 1)];
				} while (a > b);
				NumberPair pr = new NumberPair(a, b);
				pairList.Add(pr);
			}
		}

		public void doMath(ArrayList a) {
			ArrayList strAry = new ArrayList();
			for (int i = 0; i < a.Count; i++) {
				NumberPair pr = (NumberPair) a[i];
				strAry.Add(answer.Substring(pr.getStart(), pr.getEnd()));
			}
		}
	}
}
