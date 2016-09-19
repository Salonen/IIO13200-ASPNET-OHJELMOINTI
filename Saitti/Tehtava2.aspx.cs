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
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string rivi = "";

            Random rnd = new Random();

            rivi = JAMK.ICT.Data2.Lotto.Luvut(7,39,rnd); // KIRJOITIN UUDESTAAN JA ... yms. ... // VIEW BROWSER

            TextBox1.Text = rivi;

            //rivi = l.Luvut(7, 39, rnd);

        }
        catch (Exception)
        {

            throw;
        }
    }
}

