using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Abricotier : Vegetal
    {

        private const string nom="Abricot";
        public string Nom => nom;
        private int _quantite;
        public static int Count;
        public int Quantite
        {
            get
            {
                return _quantite;
            }

            set
            {
                _quantite = value;
            }
        }

        /// <summary>
        /// Fait pousser entre 1 et 6 abricots.
        /// </summary>
        public override int Pousser()
        {
            Random rd = new Random();
            return Quantite = rd.Next(1,7);
        }

        /// <summary>
        /// Constructeur incrémentant la quantité d'instance de classe.
        /// </summary>
        public Abricotier()
        {
            Count++;
        }
        /// <summary>
        /// Déconstructeur décrémentant la quantité d'instance de classe.
        /// </summary>
        ~Abricotier()
        {
            Count--;
        }
    }
}
