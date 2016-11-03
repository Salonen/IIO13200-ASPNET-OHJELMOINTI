/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class kino : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}*/

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

            if (tila == 0)
            {
                for (int j = 0; j < elemList.Count; j++)
                {
                    //TextBox1.Text += " \n " + p[i].trainNumber + " : " + p[0]["cancelled"] + " : " + p[0]["departureDate"];

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
        /*for (; i < elemList.Count && pois == 1; i++)
        {
            if (elemList[i].InnerText == "Tampere: Cine Atlas")
            {
                pois = 0;
                i--;
            }

        }*/

        string id = elemListB[index].InnerText.ToString();

        XmlNodeList elemList2 = doc2.GetElementsByTagName("Title");
        XmlNodeList elemList2B = doc2.GetElementsByTagName("area");
        XmlNodeList elemList2C = doc2.GetElementsByTagName("EventMicroImagePortrait");

            //string attrVal = elemList[i].Attributes["SuperString"].Value;

            //elemList2.Item(30).ChildNodes.Item(67);
            List<string> url = new List<string>();

            //var authors = doc.Descendants("Author");
            //TextBox3.Text += elemListB[index].InnerText.ToString() + "\n";
            //for (int j=0;j<elemList2B.Count;j++) TextBox3.Text += " \n " + elemList2B[j].InnerText.ToString();
            TextBox3.Text += elemListB[index].InnerText.ToString() + "\n";
            for (int j = 0; j < elemList2B.Count; j++) TextBox3.Text += " \n " + elemList2B[j].InnerText.ToString();
            //TextBox3.Text = elemListB[index].InnerText.ToString();

            TextBox2.Text = "";
            for (int j = 0; j < elemList2.Count; j++)
           {
                url.Add(elemList2C[j].InnerText);

               // TextBox3.Text = elemList2B[j].ToString();
               //           if (elemList2B[j].InnerText.ToString() == elemListB[index].InnerText.ToString()/*id*/)
               //           {
                            TextBox2.Text += elemList2[j].InnerText;
               //TextBox2.Text += doc2["Title"];
               //TextBox3.Text = elemList2B[j].ToString();
               //            if (j < elemList2C.Count) url.Add(elemList2C[j].InnerText);
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