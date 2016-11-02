using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class levy : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        XmlDocument doc = new XmlDocument(); // using

        // FileStream fs = new FileStream("F:\LevykauppaX.xml", FileMode.Open, FileAccess.Read);
        //XmlDocument doc = new XmlDocument();
        doc.Load(@"g:\LevykauppaX.xml"); 
// eri levy eri koneella !
        //doc.Load(fs);

        //doc.Load(@"F:\\LevykauppaX.xml");

        /*XmlDocument doc = new XmlDocument();
        doc.Load(reader);*/

        //XmlNodeList elemList = doc.GetElementsByTagName("record ISBN");

       // XmlNodeList xnList = doc.SelectNodes("/Records/genre/name");
        /*foreach (XmlNode xn in xnList)
        {
            string firstName = xn["FirstName"].InnerText;
            string lastName = xn["LastName"].InnerText;
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }*/

        //TextBox1.Text += xnList[0].InnerText.ToString();
        //string jii = doc.SelectSingleNode("/Records").InnerXml.ToString();
       /* XmlNode jii = doc.DocumentElement.SelectSingleNode("/Records");
        string attr = jii.Attributes["theattributename"]?.InnerText;*/


        string jii = doc.SelectSingleNode("/Records/genre").Attributes["name"].InnerText;

        TextBox1.Text = jii;

        //XmlNodeList elemList = doc.SelectNodes("genre");

        /*        for (int i = 0; i < elemList.Count; i++)
                {
                    TextBox1.Text += elemList[i].ToString();
                }*/
    }
}