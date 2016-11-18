using JAMK.IT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Tehtava4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        DataTable koo = new DataTable();
        DataTable joo = new DataTable();

        koo = DBDemoxOy.GetDataSimple();
        GridView1.DataSource = koo;
        GridView1.DataBind();

        lblUserName.Text = koo.Rows.ToString();//your cloumn name;
        //lblUserName.Text = dt.Rows[0]["UserName"].ToString();//your cloumn ;
        joo = DBDemoxOy.GetDataReal();

        GridView1.DataSource = joo;
        GridView1.DataBind();
        
        lblUserName.Text = joo.Rows.ToString();//your cloumn name;
                
    }
}
