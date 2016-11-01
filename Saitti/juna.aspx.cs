/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class juna : System.Web.UI.Page
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
using System.Xml.Linq;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
       // DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataView dv = new DataView();
        //ds.ReadXml(Server.MapPath("Levykauppa.xml"));//huom MapPath muuttaa viittauksen websaitille
        // @"https://10.1.12.15/xmldata?item=all";
        /*string url = @"http://www.finnkino.fi/xml.xml";
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.Load(url);*/

        //https://10.1.12.15/xmldata?item=all
        /*var document = XDocument.Load("http://www.finnkino.fi/xml?item=all");*/

        //XmlTextReader reader = new XmlTextReader("http://www.finnkino.fi/xml");
        /*while (reader.Read())
        {*/
        // Do some work here on the data.
        //http://rata.digitraffic.fi/api/v1/live-trains?station=HKI

        using (var webClient = new System.Net.WebClient())
        {
            var json = webClient.DownloadString("http://rata.digitraffic.fi/api/v1/live-trains?station=JK");
            //dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
            //dt = JsonConvert.DeserializeObject<dt>(json);
            //var result = JsonConvert.DeserializeObject<T>(json);
            //var oMycustomclassname = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(Json Object);

            //dynamic user = JsonConvert.DeserializeObject<dynamic>(json);

            //dynamic stuff1 = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            //dynamic data = JObject.Parse(json);
            //string data = JObject.Parse(json)["trainNumber"].ToString();
            //string Text = data.trainNumber.ToString();//stuff1["trainNumber"];

            //dynamic p = JsonConvert.DeserializeObject<dynamic>(json);
            List<dynamic> p = JsonConvert.DeserializeObject<List<dynamic>>(json);

            //TextBox2.Text = p[0].countryCode;// Text.ToString();*/
            //TextBox2.Text = "kokoko";
     //   string sss = p[0].trainNumber;// Text.ToString();*/
     //   TextBox2.Text = sss;
            //dt = CreateDataTable(typeof());
            //dt = CreateDataTable(p);
            //dt.Rows.Add(p[0]);
            //string value = JArray.Parse(json).Children()["countryCode"].First();


            /*JObject jObject = JObject.Parse(json);
            JToken jUser = jObject["trainNumber"];
            string sss = jUser["players"].ToArray();*/
            //string sss  = (string)jUser["stationShortCode"];
            string joo = p[0]["timeTableRows"][1]["stationShortCode"].ToString();
           // string joo = p[0]["timeTableRows"][1]["stationShortCode"].ToString();


            TextBox2.Text = joo + p[0].trainNumber;

            //dynamic d = JObject.Parse(json);

            /*Console.WriteLine(d.number);
            Console.WriteLine(d.str);
            Console.WriteLine(d.array.Count);*/

            // dynamic data = Json.Decode(json);
            //DataTable table = new DataTable();

            //dt.Columns.Add(user);

            //dt = d;
            //dt = user;


            //for (int k=0; k < 30; k++) {
            //TextBox1.Text = json.ToString(); 
            /*ListBox1.Items.Add(json);*/
            //string str = "Some number of characters";
            string j = p[1].trainNumber; //"sssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss";

       //string j = json;

            Char[] letters = j.ToCharArray();

            //TextBox1.Multiline = true;

            int u = 0;
            for (int m = 0; m < j.Length && m < 20000; m++)
            {
                if (u++ > 3)
                {
                    //TextBox1.Text += "\r\n";
                    u = 0;
                }
                TextBox1.Text += letters[m].ToString();
                ListBox1.Items.Add(letters[m].ToString());
            }

            /*char[] b = new char[j.Length];

            using (StringReader sr = new StringReader(j))
            {
                // Read 13 characters from the string into the array.
                sr.Read(b, 0, 13);
                TextBox1.Text += b.ToString();
                ListBox1.Items.Add(b.ToString());

                // Read the rest of the string starting at the current string position.
                // Put in the array starting at the 6th array member.
                sr.Read(b, 5, j.Length - 13);
                TextBox1.Text += b.ToString();
                ListBox1.Items.Add(b.ToString());
            }*/
            //}
            //var obj = JsonConvert.DeserializeObject(json);
            //var formatted = JsonConvert.SerializeObject(obj, Formatting.Indented);

            //items = JsonConvert.DeserializeObject<DataTable>(json);
            //dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));

            //dt = (DataTable)JsonConvert.DeserializeObject(json, (typeof(DataTable)));
            //dt = json;
            // Now parse with JSON.Net
        }

        //TextBox1.Text = json      // ToString();
        //}

        //dt = ;

        /*ds.ReadXml(reader);

        for (int n = 0; n<3; n++)
        {*/
        // dt = ds.Tables[n];
        dv = dt.DefaultView;
        gvData.DataSource = dv;
        gvData.DataBind();
        //}/**/
    }
}