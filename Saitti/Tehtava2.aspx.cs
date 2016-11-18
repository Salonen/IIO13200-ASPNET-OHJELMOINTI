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
    class Lotto
    {
        public static string Luvut(int monta, int alue, Random rnd)
        {

            int numero, n, m;
            int[] taul = new int[monta];
            int[] taul2 = new int[alue + 1];
            string palautus = "";

            for (n = 0; n < alue + 1; n++) taul2[n] = n;

            for (n = 0; n < monta; n++)
            {
                taul[n] = numero = taul2[rnd.Next(1, alue + 1 - n)];

                taul2[numero] = taul2[alue - n];
            }

            for (n = 0; n < monta; n++)
            {
                palautus += " " + taul[n].ToString();
            }
            palautus += "\n";
            return palautus;
        }
    }
    int t = 0;

    //string nimi;
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            t = DropDownList1.SelectedIndex;
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("Suomi");
            DropDownList1.Items.Add("Viking");
            DropDownList1.SelectedIndex = t;
        }
        catch (Exception)
        {

            throw;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            string rivi = "";

            Random rnd = new Random();

            if(t==0/*DropDownList1.SelectedItem.Text=="Suomi"*/) rivi = Lotto.Luvut(7,39,rnd); // KIRJOITIN UUDESTAAN JA ... yms. ... // VIEW BROWSER
            if(t==1/*DropDownList1.SelectedItem.Text == "Viking"*/) rivi = Lotto.Luvut(6, 48, rnd); // KIRJOITIN UUDESTAAN JA ... yms. ... // VIEW BROWSER
            
            TextBox1.Text = rivi;

            //rivi = l.Luvut(7, 39, rnd);

        }
        catch (Exception)
        {

            throw;
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        //DropDownList1.Items.Clear();
    }
}

