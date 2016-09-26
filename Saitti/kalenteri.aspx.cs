using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class kalenteri : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Calendar1.TodaysDate = Calendar1.SelectedDate;
        TextBox1.Text = "Your birthday Date is now " + Calendar1.TodaysDate.ToShortDateString();
        DateTime today = System.DateTime.Today;
        TextBox2.Text = today.ToString();
    }
}