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
        try
        {
            Calendar1.TodaysDate = Calendar1.SelectedDate;
            TextBox1.Text = "Your birthday Date is now " + Calendar1.TodaysDate.ToShortDateString();
            DateTime today = System.DateTime.Today;
            TextBox2.Text = today.ToString();
            //int a, b;

            DateTime d1 = Calendar1.SelectedDate;
            DateTime d2 = today;
            //TextBox3.Text = (d1 - d2).TotalDays.ToString();
            //TextBox4.Text = (365-((d1 - d2).TotalDays)).ToString();

            double b1 = (d2 - d1).TotalDays;
            //double b2 = (b1>=0) ? 360-b1 : ;

            double tulos = (b1 >= 0) ? 365 - b1 : -b1;

            //TimeSpan t = d1 - d2;
            //double NrOfDays = t.TotalDays;

            //b = ;

            TextBox5.Text = (tulos).ToString();

            // int b1 = d1.TotalDays;




            /*DateTime day = DateTime.Now;
            TextBox3.Text = day.ToString();*/
        }
        catch (Exception ex)
        {

        }
        finally
        {

        }
    }
}