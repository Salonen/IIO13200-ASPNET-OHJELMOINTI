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

public partial class anna : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
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
        doc.Load(@"f:\Palautteet.xml");


        //XmlNodeList nodeList;
        XmlNode root = doc.DocumentElement;

        nodeList = root.SelectNodes("/palautteet/palaute/pvm");
        nodeList2 = root.SelectNodes("/palautteet/palaute/tekija");
        nodeList3 = root.SelectNodes("/palautteet/palaute/opittu");
        nodeList4 = root.SelectNodes("/palautteet/palaute/haluanoppia");
        nodeList5 = root.SelectNodes("/palautteet/palaute/hyvaa");
        nodeList6 = root.SelectNodes("/palautteet/palaute/parannettavaa");
        nodeList7 = root.SelectNodes("/palautteet/palaute/muuta");
        //TextBox1.Text = "1";

        //if (tila == 0)
        //{
        //ListBox1.ClearSelection();
        //ListBox1.Items.Clear();
        for (int i = 0; i < nodeList.Count; i++)
            {
            //      if (tila == 0)
            //    {
            //      ListBox1.Items.Add(nodeList[i].Attributes["Artist"].InnerText + " : " +
            TextBox8.Text += nodeList[i].InnerText.ToString() + " : ";
            TextBox8.Text += nodeList2[i].InnerText.ToString() + " : ";
            TextBox8.Text += nodeList3[i].InnerText.ToString() + " : ";
            TextBox8.Text += nodeList4[i].InnerText.ToString() + " : ";
            TextBox8.Text += nodeList5[i].InnerText.ToString() + " : ";
            TextBox8.Text += nodeList6[i].InnerText.ToString() + " : ";
            TextBox8.Text += nodeList7[i].InnerText.ToString() + " : " + "\n";


            /*+ "\n ISBN = " + nodeList[i].Attributes["ISBN"].InnerText + "\n Hinta : " +
                    nodeList[i].Attributes["Price"].InnerText);// vain 2 namea*/
            //}
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        XDocument doc = XDocument.Load(@"f:\Palautteet.xml");
        XElement xml = doc.Element("palautteet");
        /*xml.Add(new XElement("Student",
                   new XElement("FirstName", "David"),
                   new XElement("LastName", "Smith")));*/
        //doc.Save(@"f:\Palautteet.xml");


        //XElement xml = XElement.Load(@"f:\Palautteet.xml");
       /* xml.Add(
        
        new XElement("pvm", "eee"),
        new XElement("tekija", "eee"),
        new XElement("opittu", "eee"),
        new XElement("haluanoppia", "eee"),
        new XElement("hyvaa", "eee"),
        new XElement("parannettavaa", "eee"),
        new XElement("muuta", "eee"));
        xml.Save(@"f:\Palautteet.xml");*/

        xml.Add(
        new XElement("palaute",
        new XElement("pvm", "eee"),
        new XElement("tekija", "eee"),
        new XElement("opittu", "eee"),
        new XElement("haluanoppia", "eee"),
        new XElement("hyvaa", "eee"),
        new XElement("parannettavaa", "eee"),
        new XElement("muuta", "eee")));
        xml.Save(@"f:\Palautteet.xml");


        /* XmlDocument  doc = new XmlDocument();
        doc.Load(@"f:\Palautteet.xml");

        XPathNavigator navigator = doc.CreateNavigator();

        navigator.MoveToChild("/palautteet/palaute", "");
        writer = navigator.AppendChild();

        xmlWriter.WriteStartElement("Student");
        xmlWriter.WriteElementString("FirstName", firstName);
        xmlWriter.WriteElementString("LastName", lastName);
        xmlWriter.WriteEndElement(); 

        //if (newDoc)
            xmlWriter.WriteEndDocument();

        xmlWriter.Close(); 

        //if (!newDoc)
          //  doc.Save(nameFile);*/
    }

    protected void Button3_Click(object sender, EventArgs e) // muista download mysql
    {
        //string cs = "server=mysql.labranet.jamk.fi;user=koodari;" + "pwd=koodari16;database=salesa;"; //@
        // salasana piilossa
        string cs = "Data source=mysql.labranet.jamk.fi;Initial Catalog=salesa;user=salesa;password=";// + "MySql.Data.MySqlClient";

        MySqlConnection conn = null;
        MySqlDataReader rdr = null;

        try
        {
            conn = new MySqlConnection(cs);
            conn.Open();

            string stm = "SELECT * FROM palaute";

            MySqlCommand cmd = new MySqlCommand(stm, conn); 

            //conn.Open();

            DataTable dt2 = new DataTable();



            using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
            {
                da.Fill(dt2);
            }

            TextBox9.Text += dt2.Rows[0].ToString();

            int i = 0;
            string seura;
            while (i < dt2.Rows.Count)
            {
                seura = dt2.Rows[i]["seura"].ToString();

                TextBox9.Text += dt2.Rows[i]["palautteet/palaute/pvm"].ToString();
                TextBox9.Text += dt2.Rows[i]["palautteet/palaute/tekija"].ToString();
                TextBox9.Text += dt2.Rows[i++]["palautteet/palaute/opittu"].ToString();
                /*comboBox.Items.Add(seura);
                pelaajat.Add(new Pelaaja(textBox.Text, textBox1.Text, seura, int.Parse(textBox2.Text)));*/

            }

            conn.Close();

        }
        catch (MySqlException ex)
        {
            Console.WriteLine("Error: {0}", ex.ToString());

        }
        finally
        {
            if (rdr != null)
            {
                rdr.Close();
            }

            if (conn != null)
            {
                conn.Close();
            }

        }

    }
}

