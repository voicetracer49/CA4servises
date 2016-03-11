using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CA4Client
{
    public class ClientPrice
    {
        private string aliasId;
        private string prices;
        private ClientArcher hasAnAlias;
  
        public ClientPrice(localhost.ArcherPrices a, ClientArcher arc)
        {
            //aliasId = a.ArcherId;
            prices = a.Prices;
            hasAnAlias = arc;
        }
        public string AliasId
        {
            get { return aliasId; }
            set { aliasId = value; }
        }
        
        public string Prices
        {
            get { return prices; }
            set { prices = value; }
        }
        public ClientArcher HasAnAlias
        {
            get { return hasAnAlias; }
            set { hasAnAlias = value; }
        }


        public override string ToString()
        {
            return HasAnAlias.ToString() + " got the price " + Prices;
        }

    }
}