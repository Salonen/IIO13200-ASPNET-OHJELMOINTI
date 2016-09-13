using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration; //Web.Configin lukemista varten

public partial class Tehtava1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //TextBox1.Text = "0";
        // TextBox2.Text = "0";
        //TextBox3.Text = "0";

    }

    /*public void Button1_Click(object sender, EventArgs e)
    {
       
        //try
        //{
            
        /*}
        catch (Exception ex)
        {
            //MessageBox.Show(ex.Message);
        }
        finally
        {
            //yield to an user that everything okay
        }
        */
    // }
    
    protected void Button1_Click1(object sender, EventArgs e)
    {
        try {
            double ala, k_piiri, hinta;

            ala = BL.Ala(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
            k_piiri = BL.Piiri(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
            hinta = BL.Hinta(ala / 1000 / 1000, k_piiri / 1000, double.Parse(TextBox3.Text), double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));

            Label1.Text = "joo"; // ala.ToString();
            TextBox4.Text = (ala / 1000 / 1000).ToString(); // ala.ToString(); /// !!! ei 1 -> 4
            TextBox5.Text = (k_piiri / 1000).ToString();
            TextBox6.Text = hinta.ToString();
        }
        catch (Exception ex)
        {
            //MessageBox.Show(ex.Message);
        }
        finally
        {
            //yield to an user that everything okay
        }
    }
}
    /*protected void Button1_Click1(object sender, EventArgs e)
    {
        double ala, k_piiri, hinta;

        ala = BL.Ala(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
        k_piiri = BL.Piiri(double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));
        hinta = BL.Hinta(ala / 1000 / 1000, k_piiri / 1000, double.Parse(TextBox3.Text), double.Parse(TextBox1.Text), double.Parse(TextBox2.Text));

        Label1.Text = "joo"; // ala.ToString();
        TextBox4.Text = (ala / 1000 / 1000).ToString(); // ala.ToString(); /// !!! ei 1 -> 4
        TextBox5.Text = (k_piiri / 1000).ToString();
        TextBox6.Text = hinta.ToString();
    }*/
//}

public class BL
{
    public static double Ala(double l,double k)
    {
        return l * k;
    }

    public static double Piiri(double l, double k)
    {
        return l * 2 + k * 2;
    }

    public static double Hinta(double ala, double piiri, double k_leveys, double l ,double k)
    {
        double kate = 1 + 0.30, LasinNelioHinta = 45, KarminMetri = 100, TyoIkkunalle = 150;


        //kpa = k * k_leveys * 2 + (l - 2 * k_leveys) * 2;

        //TyoIkkunalle = ConfigurationManager.AppSettings["TyoIkkunalle"];

        return kate * ((ala*LasinNelioHinta) + (piiri*KarminMetri) + TyoIkkunalle);
    }

    /*Hinta(ilman alvia) = (1 + kate%) x((IkkunanPintaAla x LasinNeliohinta) + (KarminPiiri x AlumiiniKarminJuoksumetriHinta) + (Työmenekki))

    Käytetään tehtävässä seuraavia parametrejä:
    kate% = 30%  LasinNelioHinta=45€/m2 AlumiiniKarminJuoksumetriHinta = 100€/jm Työmenekki = 150€/ikkuna*/
}
