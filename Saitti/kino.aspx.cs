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

   

        String URLString2 = "http://www.finnkino.fi/xml/Schedule/";
        XmlTextReader reader2 = new XmlTextReader(URLString2);

        XmlDocument doc2 = new XmlDocument();
        doc2.Load(reader2);

       

        int pois = 1;
        int i = 0;
        for (; i < elemList.Count && pois == 1; i++)
        {
            if (elemList[i].InnerText == "Tampere: Cine Atlas")
            {
                pois = 0;
                i--;
            }

        }

        string id = elemListB[i].InnerText.ToString();

        XmlNodeList elemList2 = doc2.GetElementsByTagName("Title");
        XmlNodeList elemList2B = doc2.GetElementsByTagName("TheatreID");
        XmlNodeList elemList2C = doc2.GetElementsByTagName("EventMicroImagePortrait");

        
        List<string> url = new List<string>();


        for (int j = 0; j < elemList2.Count; j++)
        {
            if (elemList2B[j].InnerText == id)
            {
                TextBox2.Text += elemList2[j].InnerText;
                if (j < elemList2C.Count) url.Add(elemList2C[j].InnerText);
            }
        }

        

        Repeater1.DataSource = url;
        Repeater1.DataBind();

        }
        catch (Exception)
        {

            throw;
        }
    }
}