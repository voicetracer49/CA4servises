using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CA4Client
{
    public class ClientArcher
    { 

        private string name;
        private string alias;

        public ClientArcher(localhost.ArcherPrices arc)  //konstruktor: Archer
        {
            //name = arc.name;
            alias = arc.Alias; 
           
        }
             
        public string Name // højreklik på variable/refactor/encapsulate for at lave properties(set,get)!
        {
            get { return name; }
            set { name = value; }
        }
       
        public string Alias
        {
            get { return alias; }
            set { alias = value; }
        }
        //tostring
        public override string ToString()
        {
            return "Archer is" + Name +" alias " + Alias;
        }
    }
}