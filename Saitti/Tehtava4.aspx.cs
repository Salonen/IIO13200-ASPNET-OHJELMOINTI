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

        /*        DataTable dt = new DataTable();
                dt = (DataTable)Session["userdata"];*/
        lblUserName.Text = koo.Rows.ToString();//your cloumn name;
        //lblUserName.Text = dt.Rows[0]["UserName"].ToString();//your cloumn name;
        joo = DBDemoxOy.GetDataReal();

        GridView1.DataSource = joo;
        GridView1.DataBind();
        
        lblUserName.Text = joo.Rows.ToString();//your cloumn name;

        /*TextBox1.Text = koo;
        DataList1 = koo;
        // Instruct the DataGrid to bind to the DataSet, with the 
        // ParentTable as the topmost DataTable.
        GridView1.SetDataBinding(dataSet, "ParentTable");*/
    }
}
