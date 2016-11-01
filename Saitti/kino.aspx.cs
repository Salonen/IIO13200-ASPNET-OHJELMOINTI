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
    string xmlfilu;
    protected void Page_Load(object sender, EventArgs e)
    {
        //haetaan web.configista xml-tiedoston nimi
        xmlfilu = ConfigurationManager.AppSettings["kino"];
        lblMessages.Text = xmlfilu;
    }

    protected void btnHae_Click(object sender, EventArgs e)
    {
        //haetaan XML-data DataView-olioon, joka kytketään GridViewhen
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataView dv = new DataView();

        /*XmlTextReader reader = new XmlTextReader("http://www.w3.org/2001/XMLSchema");
        int n = 0;
        while (reader.Read())
        {
            // Do some work here on the data.
            TextBox1.Text = reader.ToString();
        }*/

        String URLString = "http://www.finnkino.fi/xml/TheatreAreas/";
        XmlTextReader reader = new XmlTextReader(URLString);

        XmlDocument doc = new XmlDocument();
        doc.Load(reader/*@"G:\C#2\Viinit1.xml"*/);

        XmlNodeList elemList = doc.GetElementsByTagName("Name");
        XmlNodeList elemListB = doc.GetElementsByTagName("ID");

        //TextBox2.Text = elemList[0].InnerText;

        String URLString2 = "http://www.finnkino.fi/xml/Schedule/";
        XmlTextReader reader2 = new XmlTextReader(URLString2);

        XmlDocument doc2 = new XmlDocument();
        doc2.Load(reader2/*@"G:\C#2\Viinit1.xml"*/);

        //string g = elemList[0].

        int pois = 1;
        int i = 0;
        for (; i < elemList.Count && pois == 1; i++)
        {
            if (elemList[i].InnerText == "Espoo: Sello")
            {
                pois = 0;
                i--;
            }

        }

        string id = elemListB[i].InnerText.ToString();

        XmlNodeList elemList2 = doc2.GetElementsByTagName("Title");
        XmlNodeList elemList2B = doc2.GetElementsByTagName("TheatreID");
        XmlNodeList elemList2C = doc2.GetElementsByTagName("EventMicroImagePortrait");

        //string g=elemList2
        List<string> url = new List<string>();


        for (int j = 0; j < elemList2.Count; j++)
        {
            if (elemList2B[j].InnerText == id)
            {
                TextBox2.Text += elemList2[j].InnerText;
                if (j < elemList2C.Count) url.Add(elemList2C[j].InnerText);
            }
        }

        /*for (int i = 0; i < elemList.Count; i++)
        {
            TextBox2.Text += elemList[i].InnerText;

        }*/

        Repeater1.DataSource = url;
        Repeater1.DataBind();

        string x = "";

        while (reader.Read())
        {
            switch (reader.NodeType)
            {
                case XmlNodeType.Element: // The node is an element.
                    ListBox1.Items.Add(string.Format("<" + reader.Name));//.ToString();

                    while (reader.MoveToNextAttribute()) // Read the attributes.
                        ListBox1.Items.Add((" " + reader.Name + "='" + reader.Value + "'"));//.ToString();
                    ListBox1.Items.Add(string.Format(">"));//.ToString();
                    ListBox1.Items.Add(string.Format(">"));//.ToString();
                    break;
                case XmlNodeType.Text: //Display the text in each element.
                    ListBox1.Items.Add(string.Format(reader.Value));//.ToString();
                    break;
                case XmlNodeType.EndElement: //Display the end of the element.
                    ListBox1.Items.Add(string.Format("</" + reader.Name));// ToString();
                    ListBox1.Items.Add(string.Format(">"));//.ToString();
                    break;
            }
        }
        TextBox1.Text = x.ToString(); // TOIMII!!!

        /*dt = x;
        dv = dt.DefaultView;
        gvData.DataSource = dv;
        gvData.DataBind();*/

        //ListBox1.Items.Add(x);



        /*ds.ReadXml(Server.MapPath("http://www.w3.org/2001/XMLSchema"));//huom MapPath muuttaa viittauksen websaitille
        dt = ds.Tables[0];
        dv = dt.DefaultView;
        gvData.DataSource  = dv;
        gvData.DataBind();

        for (int n = 0; n < 3; n++)
        {
            dt = ds.Tables[n];
            dv = dt.DefaultView;
            gvData.DataSource = dv;
            gvData.DataBind();
        }*/
    }
}