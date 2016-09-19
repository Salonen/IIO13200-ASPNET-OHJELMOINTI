using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Web;
using System.Data; // for datatable yms
using System.Configuration;

public partial class Tehtava2 : System.Web.UI.Page
{
    //DropDownList1.Items.Add("Suomi");
    //DropDownList1.Items.Add("Viking");

    protected void Page_Load(object sender, EventArgs e)
    {
        //DropDownList1.DataTextField = "joopa";
        //DropDownList1.Items.Clear();
        /*if (DropDownList1.SelectedItem.Text == "Suomi" || DropDownList1.SelectedItem.Text == "")
        {
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("Suomi");
            DropDownList1.Items.Add("Viking");
        }
        if (DropDownList1.SelectedItem.Text == "Viking")
        {
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("Viking");
            DropDownList1.Items.Add("Suomi");
        }*/

        DropDownList1.Items.Add("Suomi");
        DropDownList1.Items.Add("Viking");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string rivi = "";

            Random rnd = new Random();

            if(DropDownList1.SelectedItem.Text=="Suomi") rivi = JAMK.ICT.Data2.Lotto.Luvut(7,39,rnd); // KIRJOITIN UUDESTAAN JA ... yms. ... // VIEW BROWSER
            if(DropDownList1.SelectedItem.Text == "Viking") rivi = JAMK.ICT.Data2.Lotto.Luvut(6, 48, rnd); // KIRJOITIN UUDESTAAN JA ... yms. ... // VIEW BROWSER

            TextBox1.Text = rivi;

            //rivi = l.Luvut(7, 39, rnd);

        }
        catch (Exception)
        {

            throw;
        }
    }
}

