using System;
using System.Web;
using System.Web.UI;
namespace Krypton
{
	public partial class CreateGame : System.Web.UI.Page
	{

		public int max = 24;

		public void SetMax(object sender, EventArgs args)
		{
			max = int.Parse(MaxBox.Text);

			Session["maxNumber"] = max;
		}
		public void InitSetMax(object sender, EventArgs args) {
			Session["maxNumber"] = max;
		}
	}
}
