using System;
using System.Web;
using System.Web.UI;
using System.Configuration;
using System.Data.SqlClient;

namespace WebApp
{
    public partial class School : System.Web.UI.Page
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            string connStr = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
            using (SqlConnection sqlConnection = new SqlConnection(connStr))
            {
                SqlCommand sqlCommand = new SqlCommand("select StudentName, CourseName from students INNER JOIN courses ON " +
                    "students.CourseID=courses.CourseID;", sqlConnection);
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
        public void Btn1_Click(object sender, EventArgs e)
        {
        }
    }
}
