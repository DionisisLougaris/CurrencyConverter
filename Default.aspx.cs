using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using lt.lb.www;
using System.Xml;

public partial class _Default : System.Web.UI.Page
{
    lt.lb.www.ExchangeRates myWs = new lt.lb.www.ExchangeRates();
    

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false) // first time loading the page
        {
            XmlNode node = myWs.getListOfCurrencies(); //putting all listing in one xml Node
            XmlNodeList nodes = node.SelectNodes("//item"); //extracting usefull info in a NodeList
            foreach (XmlNode nd in nodes)
            {
                fromList.Items.Add(nd["currency"].InnerText + " " + //currency and decription are the internal tags of the node that we need for our list
                        nd["description"].InnerText);
                toList.Items.Add(nd["currency"].InnerText + " " +
                        nd["description"].InnerText);
            }
            fromList.SelectedIndex = 26; //intializing the euro currency on the first list
            toList.SelectedIndex = 27; //initializing the english pound on the second list
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        decimal f, rateFrom = 0, rateTo = 0;
        string n1, n2;
        n1 = Convert.ToString(fromList.SelectedItem).Substring(0, 3);
        n2 = Convert.ToString(toList.SelectedItem).Substring(0, 3);
        //this free webservice works on data from the past
        XmlNode node = myWs.getExchangeRatesByDate("2014‐12‐31");// usefull data are inside the <item> tag
        XmlNodeList nodes = node.SelectNodes("//item");
        
        foreach (XmlNode nde in nodes)
        {
            if (nde["currency"].InnerText == n1)  // tracking the 'from' currency
                //Calculating the Rate
                rateFrom = Convert.ToDecimal(nde["rate"].InnerText) /
                          Convert.ToInt32(nde["quantity"].InnerText);
            if (nde["currency"].InnerText == n2)  // tracking the 'to' currency

                rateTo = Convert.ToDecimal(nde["rate"].InnerText) /
                     Convert.ToInt32(nde["quantity"].InnerText);
        }
        // 2 decimal specificity
        f = Math.Round(Convert.ToDecimal(amountTextBox.Text) * rateFrom / rateTo, 2);
        outputLabel.Text = Convert.ToString(f);
    }
}