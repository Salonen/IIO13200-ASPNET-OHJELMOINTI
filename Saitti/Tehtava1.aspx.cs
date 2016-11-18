using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration; //Web.Configin lukemista varten
using System.Globalization;

public partial class Tehtava1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    
    
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
            TextBox6.Text = hinta.ToString("C2",CultureInfo.CreateSpecificCulture("fi-Fi"));
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
    
public class BL
{
    public static double Ala(double l,double k)
    {
        try
        {
            return l * k;
        }
        catch (Exception)
        {

            throw;
        }

        
    }

    public static double Piiri(double l, double k)
    {
        try
        {
            return l * 2 + k * 2;
        }
        catch (Exception)
        {

            throw;
        }

        
    }

    public static double Hinta(double ala, double piiri, double k_leveys, double l ,double k)
    {
        try
        {
            double kate = 1 + 0.30, LasinNelioHinta = 45, KarminMetri = Convert.ToDouble(ConfigurationManager.AppSettings["alu"]), TyoIkkunalle = 150;

            return kate * ((ala * LasinNelioHinta) + (piiri * KarminMetri) + TyoIkkunalle);
        }
        catch (Exception)
        {

            throw;
        }

       
    }

    
}
