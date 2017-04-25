using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    class Program
    {
        static void Main(string[] args)


       {
            Cerisier cerisier = new Cerisier(TypeRessources.cerisier);
            Console.WriteLine("La résistance de " + cerisier.LeType + "0 est de " + cerisier.LaResistance);
            Cerisier cerisier1 = new Cerisier(TypeRessources.cerisier);
            Console.WriteLine("La résistance de " + cerisier1.LeType + "1 est de " + cerisier1.LaResistance);
            Cerisier cerisier2 = new Cerisier(TypeRessources.cerisier);
            Console.WriteLine("La résistance de " + cerisier2.LeType + "0 est de " + cerisier2.LaResistance);







        }
    }
}
