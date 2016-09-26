using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data; // for datatable yms
using System.Configuration;


public partial class Oppilaat : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn3Get3_Click(object sender, EventArgs e)
    {
        DataTable dt = JAMK.ICT.Data.DBPlacebo.Get3TestStudents();
        gvStudents.DataSource = dt;
        gvStudents.DataBind();
    }

    protected void btnGetAllClick(object sender, EventArgs e)
    {
        // Haetaan oppilaat tietokannasta
        string cs = ConfigurationManager.ConnectionStrings["oppilaat"].ConnectionString;
        string messu = "";
        
        try
        {
            DataTable dt = JAMK.ICT.Data.DBPlacebo.GetAllStudentsFromSQLServer(cs, "oppilaat", out messu);
            gvStudents.DataSource = dt;
            gvStudents.DataBind();
            lblMessages.Text = messu;
        }
        catch (Exception ex)
        {
            lblMessages.Text = ex.Message;
        }
    }
}