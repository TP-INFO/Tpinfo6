using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Chien : Animal
    {
        private string _nom;

        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }


        /// <summary>
        ///  (ノಠ益ಠ)ノ彡┻━┻
        /// </summary>
        public override void SeDeplacer()
        {
            Console.WriteLine("Le chien se déplace à quatre pattes ! omg !");
        }

        /// <summary>
 /// Le chien mange des abricots. yes.
 /// </summary>
 /// <param name="veg"></param>
 /// <param name="quantite"></param>
 /// <param name="index"></param>
        public override void Manger(Vegetal veg, List<int> quantite,int index)
        {
            if (veg is Abricotier)
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
        public Chien(string nom):base(nom)
        {
            this.Nom = nom;
        }
    }
}
