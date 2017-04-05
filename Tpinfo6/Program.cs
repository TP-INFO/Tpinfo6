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
            // instanciation d'un objet en utilisant l'enum.
            Animaux ani1 = new Animaux("chevre", RessourcesGenre.Animal);
            Console.WriteLine("Ani1 est une "+ani1.LeType+". C'est un "+ani1.LeGenre);
                       
        }
    }
}
