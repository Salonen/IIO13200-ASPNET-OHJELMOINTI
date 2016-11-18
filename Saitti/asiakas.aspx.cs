using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class asiakas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {


            string cs = ConfigurationManager.ConnectionStrings["Asiakkaat"].ConnectionString;

            string sql = "";
            //sql = "SELECT astunnus, asnimi, yhteyshlo, postitmp FROM asiakas"; // WHERE asioid='salesa'";
            sql = "SELECT * FROM asiakas"; // WHERE asioid='salesa'";

            DataTable dt = new DataTable();

            using (SqlConnection conn =
                      new SqlConnection(cs))

            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                dt.Clear();

                da.Fill(dt); // Joskus VPN-yhteys poikki

                ListBox1.Items.Add(dt.ToString());
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        TextBox1.Text += dt.Rows[i][j].ToString() + " : ";
                    }
                    TextBox1.Text += "\n";
                }


                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
        catch (Exception)
        {

            throw;
        }
    
    }
}