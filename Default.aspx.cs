using System;
using System.Web;
using System.Web.UI;

namespace WebApp
{

    public partial class Default : System.Web.UI.Page
    {        
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        public void PageChange_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Contact.aspx");
        }
        public void PageChange_Click2(object sender, EventArgs e)
        {
            Response.Redirect("Colour.aspx");
        }
        public void PageChange_Click3(object sender, EventArgs e)
        {
            Response.Redirect("Calendar.aspx");
        }
        public void PageChange_Click4(object sender, EventArgs e)
        {
            Response.Redirect("Options.aspx");
        }
        public void PageChange_Click5(object sender, EventArgs e)
        {
            Response.Redirect("School.aspx");
        }
        public void Button1Clicked(object sender, EventArgs args)
        {
            button1.Text = "You clicked me";
            blah.Text = "Hello, " + textInput.Text;
        }
        public void GreetList_SelectedIndexChanged(object sender, EventArgs args)
        {
            if (GreetList.SelectedValue == "Greetings")
            {
                blahblah.Text = "to you";
            } else if (GreetList.SelectedValue == "Hello")
            {
                blahblah.Text = "there";
            }
            else if (GreetList.SelectedValue == "Go away")
            {
                blahblah.Text = "fuck face!";
            } else
            {
                blahblah.Text = "";
            }

        }
    }
}
