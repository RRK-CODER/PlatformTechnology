using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace midsem_20IT1048
{
    public partial class UGInside : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("data source=RRK;initial catalog = UGInternals; persist security info = True;Integrated Security = SSPI");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT TOP(1000)[Reg No],[Name],[Course,[Year],[Subject Name],[Test1 marks],[Test2 marks],[Test3 marks],[Assignments Marks] FROM[UGInternals].[dbo].[UGInternals]", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
           

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}