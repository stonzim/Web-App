using System;
using System.Web;
using System.Web.UI;
using System.Drawing;
using System.Web.UI.WebControls;

namespace WebApp
{

    public partial class Colour : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        public void PageChange_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
        public void PageChange_Click2(object sender, EventArgs e)
        {
            Response.Redirect("Contact.aspx");
        }
        public void Colour_CheckedChanged(object sender, System.EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            label.ForeColor = System.Drawing.Color.FromName(radioButton.Text);
        }

    }
}
