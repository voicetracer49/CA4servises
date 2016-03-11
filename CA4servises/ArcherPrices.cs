using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CA4servises
{
    public class ArcherPrices
    {
        private string name; 
        private string alias;
        private string archerId;
        private string prices;       
        
        public ArcherPrices()  
        {
        }

        public string Name // Properties: Name fra Archer Tabellen
        {
            get { return name; }
            set { name = value; }
        }
        public string Alias // Properties: Alias fra Archer Tabellen
        {
            get { return alias; }
            set { alias = value; }
        }
        public string ArcherId // properties: AliasId fra Alias Tabellen
        {
            get { return archerId; }
            set { archerId = value; }
        }
        public string Prices // properties: Prices fra Alias Tabellen
        {
            get { return prices; }
            set { prices = value; }
        }
     
    }
}