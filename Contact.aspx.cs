using System;
using System.Web;
using System.Web.UI;
using System.Drawing;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class Contact : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BoxControl.UserName = "Winston";
            BoxControl.UserAge = 37;
            BoxControl.UserCountry = "New Zealand";
        }
        public void PageChange_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
        public void PageChange_Click2(object sender, EventArgs e)
        {
            Response.Redirect("Colour.aspx");
        }
        public void ColourDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            DropDownList dropDownList = (DropDownList)sender;
            changeColour.ForeColor = System.Drawing.Color.FromName(dropDownList.SelectedValue);
        }
    }
}
