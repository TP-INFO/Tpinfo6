using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Chevre : Animal
    {
        private string nom;
        public string Nom => nom;
        public override void SeDeplacer()
        {
            Console.WriteLine("l'animal se déplace (/◕ヮ◕)/");
        }
        /// <summary>
        /// L'animal mange la nourriture seulement si c'est du chou, sinon renvoie une exception.
        /// </summary>
        /// <param name="veg"></param>
        /// <param name="quantite"></param>
        /// <param name="index"></param>
        public override void Manger(Vegetal veg, List<int> quantite,int index)
        {
            if (veg is Chou)
            {
                this.Nourri = true;
                quantite[index]--;
            }
            else throw new Exception();
        }
        /// <summary>
        /// Constructeur rqrant le nom de l'animal en paramètre.
        /// </summary>
        /// <param name="nom"></param>
        public Chevre(string nom):base(nom)
        {
            this.nom = nom;
        }
    }
}
