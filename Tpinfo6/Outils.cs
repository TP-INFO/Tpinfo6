using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tpinfo6
{
    public class Outils
    {
        private string Table;
        private string Seau;
        private string Couteau;

        public Outils()
        {
            
        }

        
        public string LaTable
        {
            get { return Table;}
            set { Table = value;}
        }
        public string LeSeau
        {
            get { return Seau;}
            set { Seau = value; }
        }
        public string LeCouteau
        {
            get { return Couteau;}
            set { Couteau = value;}
        }
    }
}