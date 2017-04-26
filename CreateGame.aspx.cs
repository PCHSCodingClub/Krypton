using System;
using System.Web;
using System.Web.UI;
namespace Krypton
{
	public partial class CreateGame : System.Web.UI.Page
	{

		public int max = 24;

		public void SetMax(object sender, EventArgs args) //Button Will be turned into max rounds
		{
			//max = int.Parse(MaxBox.Text);

			Session["ScoreTotal"] = 1;
			//Session["maxNumber"] = max;
			Session["maxRounds"] = 10;
			Session["currentRounds"] = 0;
		}	
	}
}
