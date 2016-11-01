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
using System.Web.UI.WebControls;

public partial class Tyontekijat : System.Web.UI.Page
{
    int tila = 0, vali = 0, vipu = 0;
    string sana = "joo";



    string xmlfilu;
    protected void Page_Load(object sender, EventArgs e)
    {
               
        //haetaan web.configista xml-tiedoston nimi
        xmlfilu = ConfigurationManager.AppSettings["kino"];
        lblMessages.Text = xmlfilu;

    }

    protected void btnHae_Click(object sender, EventArgs e)
    {
        try
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

        //listBox1.ClearSelected();
        //listbox1.Items.Clear();

        using (var webClient = new System.Net.WebClient())
        {
            /*if (tila == 0)
            {
                var json = webClient.DownloadString("http://rata.digitraffic.fi/api/v1/live-trains?station=JK");
            }
            else
            {*/
            //string url = string.Format("http://rata.digitraffic.fi/api/v1/live-trains?station={0}", "HKI");

                var json2 = webClient.DownloadString("http://rata.digitraffic.fi/api/v1/metadata/stations");
                List<dynamic> p2 = JsonConvert.DeserializeObject<List<dynamic>>(json2);
            //listbox1.Items.Clear();
            if (tila == 0)
            {
                for (int i = 0; i < p2.Count; i++)
                {
                //TextBox1.Text += " \n " + p[i].trainNumber + " : " + p[0]["cancelled"] + " : " + p[0]["departureDate"];
                    
                        ListBox1.Items.Add(p2[i]["stationName"].ToString() + " : " + p2[i]["stationShortCode"]);
                    }

            }
            tila = 1;

            var json = webClient.DownloadString(string.Format("http://rata.digitraffic.fi/api/v1/live-trains?station={0}", p2[vali]["stationShortCode"].ToString()));
            TextBox1.Text = vali.ToString();// p2[1]["stationShortCode"].ToString();
            
            /*}*/
            //var json2 = webClient.DownloadString("http://rata.digitraffic.fi/api/v1/metadata/stations");

            //http://rata.digitraffic.fi/api/v1/metadata/stations
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
            //List<dynamic> p2 = JsonConvert.DeserializeObject<List<dynamic>>(json2);

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
   //         string joo = p[0]["timeTableRows"][1]["stationShortCode"].ToString();
            // string joo = p[0]["timeTableRows"][1]["stationShortCode"].ToString();
            if (vipu == 0)
            {
                TextBox2.Text = "";
                ListBox2.Items.Clear();
                for (int i = 0; i < p.Count; i++)
                {
              
                    TextBox2.Text += " \n " + p[i].trainNumber + " : " + p[0]["cancelled"] + " : " + p[0]["departureDate"];
                    ListBox2.Items.Add(p[i]["trainNumber"].ToString());
                }
            }
            vipu = 1;

           /* for (int i = 0; i < p2.Count; i++)
            {
                //TextBox1.Text += " \n " + p[i].trainNumber + " : " + p[0]["cancelled"] + " : " + p[0]["departureDate"];
                ListBox1.Items.Add(p2[i]["stationName"].ToString() + " : " + p2[i]["stationShortCode"]);
            }*/



            //TextBox2.Text = joo + p[0].trainNumber;



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
 /*string j = p[1].trainNumber; //"sssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssssss";

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
 }*/

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
        catch (Exception)
        {

            throw;
        }
    }

    protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {

        
        //tila = 1;
        sana = ListBox1.SelectedItem.ToString();
        vipu = 0;
        vali = ListBox1.SelectedIndex;
            //listBox1.ClearSelected();
        }
        catch (Exception)
        {

            throw;
        }
    }

}