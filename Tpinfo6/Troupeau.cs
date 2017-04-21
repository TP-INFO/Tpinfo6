using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    class Troupeau
    {
        private List<Cerisier> cerisiers;

        public Troupeau()
        {
            cerisiers = new List<Cerisier>();
        }

        public List<Cerisier> Cerisiers
        {
            get { return cerisiers; }
            set { cerisiers = Cerisiers; }
        }
        public void CreerTroupeau()
        {

        }
    }
}
