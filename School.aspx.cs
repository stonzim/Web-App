using System;
using System.Web;
using System.Web.UI;
using System.Configuration;
using System.Data.SqlClient;

namespace WebApp
{
    public partial class School : System.Web.UI.Page
    {
        string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connStr))
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM courses;", sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                GridView1.DataSource = sqlDataReader;
                GridView1.DataBind();
            }
        }
        public void PageChange_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
        public void AddButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CourseTB.Text))
            {
                using (SqlConnection sqlConnection = new SqlConnection(connStr))
                {
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO courses(CourseName) VALUES('" +
                        CourseTB.Text + "');", sqlConnection);
                    sqlConnection.Open();
                    int TotalRows = (int)sqlCommand.ExecuteNonQuery();
                    //SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    //GridView1.DataSource = sqlDataReader;
                    //GridView1.DataBind();
                    //Response.Redirect("School.aspx");
                    AlertLabel.Text = CourseTB.Text + " entered";
                    CourseTB.Text = "";
                    SqlCommand sqlCommand2 = new SqlCommand("SELECT * FROM courses;", sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand2.ExecuteReader();
                    GridView1.DataSource = sqlDataReader;
                    GridView1.DataBind();
                }
            } else
            {
                AlertLabel.Text = "Enter a course";
            }
        }
    }
}
