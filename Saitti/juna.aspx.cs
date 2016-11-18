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



    //string xmlfilu;
    protected void Page_Load(object sender, EventArgs e)
    {
               
        //haetaan web.configista xml-tiedoston nimi
        //xmlfilu = ConfigurationManager.AppSettings["kino"];
        //lblMessages.Text = xmlfilu;

    }

    protected void btnHae_Click(object sender, EventArgs e)
    {
        try
        {

        
        
        DataTable dt = new DataTable();
        DataView dv = new DataView();
        
        using (var webClient = new System.Net.WebClient())
        {
           
                var json2 = webClient.DownloadString("http://rata.digitraffic.fi/api/v1/metadata/stations");
                List<dynamic> p2 = JsonConvert.DeserializeObject<List<dynamic>>(json2); 
            //listbox1.Items.Clear();
            if (tila == 0)
            {
                    ListBox1.Items.Clear();
                    for (int i = 0; i < p2.Count; i++)
                {
                                   
                        ListBox1.Items.Add(p2[i]["stationName"].ToString() + " : " + p2[i]["stationShortCode"]);
                    }

            }
            tila = 1;

            var json = webClient.DownloadString(string.Format("http://rata.digitraffic.fi/api/v1/live-trains?station={0}", p2[vali]["stationShortCode"].ToString()));
            TextBox1.Text = vali.ToString();// p2[1]["stationShortCode"].ToString();
            
            
            List<dynamic> p = JsonConvert.DeserializeObject<List<dynamic>>(json);
            
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

      
        }

        
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