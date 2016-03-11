using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Collections;
using System.Data.SqlClient;

namespace CA4servises
{
    /// Summary description for WebService
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public ArcherPrices findAP(string name)
        {

            SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = ArcherDB");
            // no error handling today
            conn.Open();
            SqlCommand cmd = conn.CreateCommand(); // connection initialiseres!
            ArcherPrices ans = new ArcherPrices();
   //if(name != null)  {

                // find alias in archer tabellen med findAP(string name)!
                cmd.CommandText = @"select Alias from Archer where Name = '" + name + "'";

                SqlDataReader rdr = cmd.ExecuteReader(); //Instans af SqlDataReader

                rdr.Read(); //udfør og read sql kald!
                ans.Alias = rdr["Alias"].ToString();
                rdr.Close();  // Close immellem quotes!

                // find prizes in archer tabellen med netop fundne Alias i Alias tabel !
                cmd.CommandText = @"select Prices from Alias where AliasID = '" + ans.Alias + "'";

                rdr = cmd.ExecuteReader();

                // to løsninger, hvis flere prizes pr. Alias !
                string priceMid = "";
                while (rdr.Read()) // read next result row
                {
                    priceMid = rdr["Prices"].ToString();
                    ans.Prices += priceMid + ",";
                }// end while 
                /*  rdr.Read();
                  ans.Prices = rdr["Prices"].ToString();
                */
                conn.Close();
                return ans;
          /* }else {
               ans.Alias = "";
               ans.Prices = "";
               return ans; }*/
            }
        

        [WebMethod]
        public string totalCalc(string a)
        {
            string[] numbers = a.Split(',');
            int sum = 0;
            int midCalc = 0;
            int i;
            for (i = 0; i < numbers.Length; i++)
            {
                midCalc = Convert.ToInt32(numbers[i]);
                sum += midCalc;
            }          
            return  Convert.ToString(sum);
        }

        private Double num;
        [WebMethod]
        public string AVG(string b)
        {
            string[] numbers = b.Split(',');
            double avg;

            int i;
            for (i = 0; i < numbers.Length; i++)
            {
                 num += Convert.ToDouble(numbers[i]);
            }
            avg = num / numbers.Length;
            
            return Convert.ToString(avg);
        }

        [WebMethod]
        public string sort(string c)
        {
            string[] numbers = c.Split(',');
            
            /* int[] numbx; 
            int j;
            for (j = 0; j < numbers.Length; j++) {  
                numbx = Convert.ToInt32(numbers[j]));     
            }
            */

            Array.Sort(numbers);

            string numb ="";
            int i;
            for (i = 0; i < numbers.Length; i++)
            {
                numb += numbers[i] + ",";         
            }
            return numb;      
        }


        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}