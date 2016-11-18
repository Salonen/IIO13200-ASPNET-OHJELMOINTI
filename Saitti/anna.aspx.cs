using System;
using System.Collections.Generic;
//using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;

public partial class anna : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {

        XmlDocument doc = new XmlDocument();
        XmlNodeList nodeList;
        XmlNodeList nodeList2;
        XmlNodeList nodeList3;
        XmlNodeList nodeList4;
        XmlNodeList nodeList5;
        XmlNodeList nodeList6;
        XmlNodeList nodeList7;
        string k = "images/";
        string k2 = ".jpg";
          
        // using
        doc.Load(@"f:\Palautteet.xml"); // Muista myös toinen ja kolmas


        //XmlNodeList nodeList;
        XmlNode root = doc.DocumentElement;

        nodeList = root.SelectNodes("/palautteet/palaute/pvm");
        nodeList2 = root.SelectNodes("/palautteet/palaute/tekija");
        nodeList3 = root.SelectNodes("/palautteet/palaute/opittu");
        nodeList4 = root.SelectNodes("/palautteet/palaute/haluanoppia");
        nodeList5 = root.SelectNodes("/palautteet/palaute/hyvaa");
        nodeList6 = root.SelectNodes("/palautteet/palaute/parannettavaa");
        nodeList7 = root.SelectNodes("/palautteet/palaute/muuta");
        
        for (int i = 0; i < nodeList.Count; i++)
            {
            
            TextBox8.Text += nodeList[i].InnerText.ToString() + " : ";
            TextBox8.Text += nodeList2[i].InnerText.ToString() + " : ";
            TextBox8.Text += nodeList3[i].InnerText.ToString() + " : ";
            TextBox8.Text += nodeList4[i].InnerText.ToString() + " : ";
            TextBox8.Text += nodeList5[i].InnerText.ToString() + " : ";
            TextBox8.Text += nodeList6[i].InnerText.ToString() + " : ";
            TextBox8.Text += nodeList7[i].InnerText.ToString() + " : " + "\n";


            
        }

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

       
        if (TextBox1.Text.Length == 0 ||
            TextBox2.Text.Length == 0 ||
            TextBox3.Text.Length == 0 ||
            TextBox4.Text.Length == 0 ||
            TextBox5.Text.Length == 0 ||
            TextBox6.Text.Length == 0 ||
            TextBox7.Text.Length == 0   
            )
        {
            Label1.Text = "Required field is empty!";
        }
                // Message box
        else {     

        XDocument doc = XDocument.Load(@"f:\Palautteet.xml"); // Muista myös toinen ja kolmas
        XElement xml = doc.Element("palautteet");
        

        xml.Add(
        new XElement("palaute",
        new XElement("pvm", TextBox1.Text),
        new XElement("tekija", TextBox2.Text),
        new XElement("opittu", TextBox3.Text),
        new XElement("haluanoppia", TextBox4.Text),
        new XElement("hyvaa", TextBox5.Text),
        new XElement("parannettavaa", TextBox6.Text),
        new XElement("muuta", TextBox7.Text)));
        xml.Save(@"f:\Palautteet.xml");  // Muista myös toinen ja kolmas

           
            }
        }
        catch (Exception)
        {

            throw;
        }

    }

    protected void Button3_Click(object sender, EventArgs e) // muista download mysql
    {
        //string cs = "server=mysql.labranet.jamk.fi;user=koodari;" + "pwd=koodari16;database=salesa;"; //@
        // salasana piilossa
        try
        {

        
        string cs = ConfigurationManager.ConnectionStrings["Mysli"].ConnectionString; //Mysli;//"Data source=mysql.labranet.jamk.fi;Initial Catalog=salesa;user=salesa;password=f";// + "MySql.Data.MySqlClient";

        // pois salasana ja tämä? kun laitat githubbiin

        MySqlConnection conn = null;
        MySqlDataReader rdr = null;

        /*try
        {*/
            conn = new MySqlConnection(cs);
            conn.Open();

            string stm = "SELECT * FROM palaute";

            MySqlCommand cmd = new MySqlCommand(stm, conn); 

            //conn.Open();

            DataTable dt2 = new DataTable();



            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                da.Fill(dt2);


                TextBox9.Text += dt2.Rows[0].ToString();

                int i = 0;
                //string seura;
                while (i < dt2.Rows.Count)
                {
                    //seura = dt2.Rows[i]["seura"].ToString();

                    TextBox9.Text += dt2.Rows[i]["pvm"].ToString();
                    TextBox9.Text += dt2.Rows[i]["tekija"].ToString();
                    TextBox9.Text += dt2.Rows[i]["opittu"].ToString();
                    TextBox9.Text += dt2.Rows[i]["haluanoppia"].ToString();
                    TextBox9.Text += dt2.Rows[i]["hyvaa"].ToString();
                    TextBox9.Text += dt2.Rows[i]["parannettavaa"].ToString();
                    TextBox9.Text += dt2.Rows[i++]["muuta"].ToString() + "\n";
                    /*comboBox.Items.Add(seura);
                    pelaajat.Add(new Pelaaja(textBox.Text, textBox1.Text, seura, int.Parse(textBox2.Text)));*/

                }
            }

            conn.Close();

        }
        catch (Exception)
        {

            throw;
        }

    }
}


