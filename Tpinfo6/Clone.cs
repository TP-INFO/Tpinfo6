using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{
    /// <summary>
    /// Structure permettant de cloner un animal
    /// </summary>
    public struct Clone : ISeDeplacer
    {
        //Accesseur du nom du clone
        public string Nom { get; set; }

        //Constructeur avec le nom en argument
        public Clone(string nom)
        {
            Nom = nom;
        }

        //Implémentation de la méthode sedeplacer de l'interface Isedeplacer
        public void SeDeplacer(string destination)
        {
            Console.WriteLine("{0} va prendre soin de {1}", Nom, destination);
        }
    }
}
