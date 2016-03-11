using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//using CA4Client.localhost;  // Så behæver man ikke skrive f.eks. localhost.ArcherPrizes

namespace CA4Client
{
    public partial class Index : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
                
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            localhost.WebService1 apSerw = new localhost.WebService1();
            localhost.ArcherPrices ap = new localhost.ArcherPrices();
            
            if (TextBox1NameIn.Text != "") { 
            ap = apSerw.findAP(TextBox1NameIn.Text);
            
            ListBox1Prizes.Items.Add("Alias: " + ap.Alias);
            ListBox1Prizes.Items.Add("Prize: " + ap.Prices);
            
            TextBox1NameIn.Text = "";
            TextBox2InputSum.Focus();
            } else { TextBox1NameIn.Text = "Skriv et navn !"; }
        }
        
            

        protected void Button2Sum_Click(object sender, EventArgs e)
        {
            if (TextBox2InputSum.Text != "")
            { 
            localhost.WebService1 apSum = new localhost.WebService1();
           
            TextBox3ResultSum.Text = apSum.totalCalc(TextBox2InputSum.Text);
            TextBox2InputSum.Text = ""; // indput slettes!
            TextBox2.Text = ""; // Result af øvrige slettes!
            TextBox4.Text = "";
            TextBox1.Focus();
            }
            else { TextBox2InputSum.Text = "Skriv mindst et tal!"; }
        }


        protected void Button2_Click(object sender, EventArgs e)
        {
            localhost.WebService1 apSum = new localhost.WebService1();

            TextBox2.Text = apSum.AVG(TextBox1.Text);
            TextBox1.Text = "";// indput slettes!
            TextBox3ResultSum.Text = ""; // Result af øvrige slettes!
            TextBox4.Text = "";
            TextBox3.Focus();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            localhost.WebService1 apSum = new localhost.WebService1();

            TextBox4.Text = apSum.sort(TextBox3.Text);
            TextBox3.Text = "";// indput slettes!
            TextBox3ResultSum.Text = ""; // Result af øvrige slettes!
            TextBox2.Text = "";
            TextBox1NameIn.Focus();
        }

      

    }
}