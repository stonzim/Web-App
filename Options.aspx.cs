using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{

    public partial class Options : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                for (int i = 0; i < 5; i++)
                {
                    ListItem listItem = new ListItem();
                    listItem.Text = "Item " + i;
                    listItem.Value = i.ToString();
                    LeftBox.Items.Add(listItem);
                }
            }
        }
        public void PageChange_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
        public void AddToRight_Click(object sender, EventArgs e)
        {
            if (LeftBox.Items.Count != 0)
            {
                if (LeftBox.SelectedItem != null)
                {
                    ListItem listItem = LeftBox.SelectedItem;
                    LeftBox.Items.Remove(listItem);
                    listItem.Selected = false;
                    RightBox.Items.Add(listItem);
                    notification.Text = "";
                }
                else
                {
                    notification.Text = "Please select an item in the left-hand!";
                }
            } else
            {
                notification.Text = "No more items to move!";
            }
        }
        public void AddToLeft_Click(object sender, EventArgs e)
        {
            if (RightBox.Items.Count != 0)
            {
                if (RightBox.SelectedItem != null)
                {
                    ListItem listItem = RightBox.SelectedItem;
                    RightBox.Items.Remove(listItem);
                    listItem.Selected = false;
                    LeftBox.Items.Add(listItem);
                    notification.Text = "";
                } else
                {
                    notification.Text = "Please select an item in the right-hand box!";
                }
            } else
            {
                notification.Text = "No more items to move!";
            }
        }
    }
}
