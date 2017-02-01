using System;
using System.Web;
using System.Web.UI;

namespace Krypton
{

	public partial class Default : System.Web.UI.Page
	{
		public void generateCards(object sender, EventArgs args)
		{
			Random rand = new Random(20);

			card1.Text = rand.Next().ToString();
			card2.Text = rand.Next().ToString();
			card3.Text = rand.Next().ToString();
			card4.Text = rand.Next().ToString();
			card5.Text = rand.Next().ToString();
			card6.Text = rand.Next().ToString();
		}
	}
}
