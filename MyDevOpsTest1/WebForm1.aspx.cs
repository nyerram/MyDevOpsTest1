using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace MyDevOpsTest1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=NYXPS;Database=DevOpsTestDatabase;Integrated Security=true;");
            conn.Open();
            string SQL = "Select * from Users;";
            SqlCommand cmd = new SqlCommand(SQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //cmd.ExecuteNonQuery();
            
            GridView1.DataSource = dt;
            GridView1.DataBind();
            conn.Close();

        }
    }
}