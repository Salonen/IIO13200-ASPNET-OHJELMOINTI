using System;
using System.Configuration; //Web.Configin lukemista varten
using System.Data; //Dataa ja yleisiä ADO.NETin luokkia varten
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Tyontekijat : System.Web.UI.Page
{
    int index = 0,tila = 0;
    protected void btnHae_Click(object sender, EventArgs e)
    {

        try
        {

        

        String URLString = "http://www.finnkino.fi/xml/TheatreAreas/";
        XmlTextReader reader = new XmlTextReader(URLString);

        XmlDocument doc = new XmlDocument();
        doc.Load(reader);

        XmlNodeList elemList = doc.GetElementsByTagName("Name");
        XmlNodeList elemListB = doc.GetElementsByTagName("ID");

            ListBox1.Items.Clear();

            if (tila == 0)
            {
                for (int j = 0; j < elemList.Count; j++)
                {
                    
                    ListBox1.Items.Add(elemList[j].InnerText);
                }

            }
            tila = 1;


            String URLString2 = string.Format("http://www.finnkino.fi/xml/Schedule/?area={0}", elemListB[index].InnerText);
        XmlTextReader reader2 = new XmlTextReader(URLString2);

        XmlDocument doc2 = new XmlDocument();
        doc2.Load(reader2);

       

        int pois = 1;
        int i = 0;
            TextBox3.Text = index.ToString() + "\n";
       

        string id = elemListB[index].InnerText.ToString();

        XmlNodeList elemList2 = doc2.GetElementsByTagName("Title");
        XmlNodeList elemList2B = doc2.GetElementsByTagName("area");
        XmlNodeList elemList2C = doc2.GetElementsByTagName("EventMicroImagePortrait");

            
            List<string> url = new List<string>();

            
            TextBox3.Text += elemListB[index].InnerText.ToString() + "\n";
            for (int j = 0; j < elemList2B.Count; j++) TextBox3.Text += " \n " + elemList2B[j].InnerText.ToString();
            

            TextBox2.Text = "";
            for (int j = 0; j < elemList2.Count; j++)
           {
                url.Add(elemList2C[j].InnerText);

               
                            TextBox2.Text += elemList2[j].InnerText;
              
            }


        

        

        Repeater1.DataSource = url;
        Repeater1.DataBind();

        }
        catch (Exception)
        {

            throw;
        }
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        index = ListBox1.SelectedIndex;
    }
}