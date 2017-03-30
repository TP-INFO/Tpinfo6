using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{
    struct Clone : ISeDeplacer
    {
        public string Nom { get; set; }

        public Clone(string nom)
        {
            Nom = nom;
        }
        public void SeDeplacer(string destination)
        {
            Console.WriteLine("{0} se déplace vers {1}", Nom, destination);
        }
    }
}
