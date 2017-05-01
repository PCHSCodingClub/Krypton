using System;
using System.Web;
using System.Web.UI;
namespace Krypton
{
	public partial class CreateGame : System.Web.UI.Page
	{
		protected override void OnLoad(EventArgs e)
		{
			Session["ScoreTotal"] = 1;
			Session["maxRounds"] = 10;
			Session["currentRounds"] = 1;
		}

		public int max = 24;

		public void SetMax(object sender, EventArgs args) //Button Will be turned into max rounds
		{
			max = int.Parse(MaxBox.Text);

			Session["maxRounds"] = max;
		}	
	}
}
