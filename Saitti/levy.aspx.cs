using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
// System, System.Drawing and 
    
//using System.Windows.Forms

public partial class levy : System.Web.UI.Page
{
    //string joo = "images / Anna2009.jpg";
    int joopa = 1, tila=0;

    XmlDocument doc = new XmlDocument();
    XmlNodeList nodeList;
    string k = "images/";
    string k2 = ".jpg";

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {

        
        // using
        doc.Load(@"f:\LevykauppaX.xml");


        //XmlNodeList nodeList;
        XmlNode root = doc.DocumentElement;

        nodeList = root.SelectNodes("/Records/genre/record");
        //TextBox1.Text = "1";

        if (tila == 0)
        {
            //ListBox1.ClearSelection();
            joopa = ListBox1.SelectedIndex;
                if (joopa<0) joopa = 1;
            ListBox1.Items.Clear();
            
            for (int i = 0; i < nodeList.Count; i++)
            {
                if (tila == 0)
                {
                    ListBox1.Items.Add(nodeList[i].Attributes["Artist"].InnerText + " : " +
                    nodeList[i].Attributes["Title"].InnerText + "\n ISBN = " + nodeList[i].Attributes["ISBN"].InnerText + "\n Hinta : " +
                    nodeList[i].Attributes["Price"].InnerText);// vain 2 namea
                }

                switch (i)
                {
                    case 0:
                        image.Src = k + nodeList[i].Attributes["ISBN"].InnerText + k2;
                        break;
                    case 1:
                        image2.Src = k + nodeList[i].Attributes["ISBN"].InnerText + k2;
                        break;
                    case 2:
                        image3.Src = k + nodeList[i].Attributes["ISBN"].InnerText + k2;
                        break;
                    case 3:
                        image4.Src = k + nodeList[i].Attributes["ISBN"].InnerText + k2;
                        break;
                    case 4:
                        image5.Src = k + nodeList[i].Attributes["ISBN"].InnerText + k2;
                        break;
                    case 5:
                        image6.Src = k + nodeList[i].Attributes["ISBN"].InnerText + k2;
                        break;
                }
                image7.Src = k + "Paula2012.JPG";
            }
        }
        ListBox1.SelectedIndex = joopa;
        tila = 1;
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
            image8.Src = k + nodeList[joopa/*int.Parse(TextBox1.Text)*/].Attributes["ISBN"].InnerText + k2;

        }
        catch (Exception)
        {

            throw;
        }
        

       
        //string koo = "images/Laura2012.jpg";
       
    }



    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        
        tila = 1;
        TextBox2.Text = tila.ToString();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox2.Text = joopa.ToString();
    }
}