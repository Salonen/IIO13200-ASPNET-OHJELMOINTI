using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Source : System.Web.UI.Page
{
    public string Messu
    {
        get { return txtMessages.Text; }
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        //täällä tehdään yleensä kaikki sivun alustukseen liittyvät
        //huom mutta VAIN YHDEN kerran!!!
        if (!IsPostBack)
        {
            ddlMessages.Items.Add("Ping!");
            ddlMessages.Items.Add("Hello, handshake?");
            ddlMessages.Items.Add("Goodbye");
        }
    }

    protected void buttonQueryString_Click(object sender, EventArgs e)
    {
        Response.Redirect("tapa2.aspx?Data" + txtMessages.Text);
        Response.Redirect("tapa2.aspx");
    }

    protected void post_Click(object sender, EventArgs e)
    {

    }

    protected void ses_Click(object sender, EventArgs e)
    {
        //kirjoitetaan Sessioniin
        Session["viesti"] = txtMessages.Text;
        Response.Redirect("tapa4.aspx");
    }

    protected void Cookie_Click(object sender, EventArgs e)
    {
        //luodaan keksi ja kirjoitetaan siihen
        HttpCookie keksi = new HttpCookie("viesti", txtMessages.Text); // F1
        //keksi.Expires
        Response.Cookies.Add(keksi);
        Response.Redirect("tapa5.aspx");

    }

    protected void P_Click(object sender, EventArgs e)
    {
        //Response.Redirect("tapa6.aspx"); // ei kelpaa, koska PreviousPage ei synny
        // Luetaan Page-olion PreviousPage-ominaisuudesta
        Server.Transfer("tapa6.aspx");
    }

    protected void ddlMessages_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtMessages.Text = ddlMessages.SelectedItem.ToString();
    }
}