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
    string joo = "images / Anna2009.jpg";


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

        //Bitmap myBmp = Bitmap.FromFile("path here");
        //Bitmap myBmp = new Bitmap("path here");

        string koo = "images/Laura2012.jpg";
        image.Src = koo;

        //Image ima = Image.FromFile("c:\\FakePhoto1.jpg"); 
        //Image1.Page =myBmp;// FromFile("c:\\FakePhoto2.jpg");
        //Image i = Image.FromFile("image.jpg");




        //Image image = new Bitmap(@"c:\FakePhoto.jpg");

        //Image i = Image.FromFile("image.jpg");

        //Canvas.Children.Add(image);



        //XmlNodeList elemList = doc.SelectNodes("genre");

        /*        for (int i = 0; i < elemList.Count; i++)
                {
                    TextBox1.Text += elemList[i].ToString();
                }*/
    }


    /*public void CreateBitmapAtRuntime()
    {
        PictureBox pictureBox1 = new PictureBox();
        pictureBox1.Size = new Size(210, 110);
        this.Controls.Add(pictureBox1);

        Bitmap flag = new Bitmap(200, 100);
        Graphics flagGraphics = Graphics.FromImage(flag);
        int red = 0;
        int white = 11;
        while (white <= 100)
        {
            flagGraphics.FillRectangle(Brushes.Red, 0, red, 200, 10);
            flagGraphics.FillRectangle(Brushes.White, 0, white, 200, 10);
            red += 20;
            white += 20;
        }
        pictureBox1.Image = flag;

    }*/
}