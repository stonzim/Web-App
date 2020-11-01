using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{

    public partial class Calendar : System.Web.UI.Page
    {
        public void PageChange_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
        public void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            chosenDate.Text = "Date: " + (Calendar1.SelectedDate.ToLongDateString());
        }
        public void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.IsWeekend)
            {
                e.Day.IsSelectable = false;
                e.Cell.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}
