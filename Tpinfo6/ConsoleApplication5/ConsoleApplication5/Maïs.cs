using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Maïs : Vegetal
    {

        private const string Nom = "Maïs";
        public string nom => Nom;        
        public static int Count { get; set; }
        private int _quantite;
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
        /// Fait pousser entre 1 et 7 épis de maïs.
        /// </summary>
        public override int Pousser()
        {
            Random rd = new Random();
            return Quantite = rd.Next(1,8);

        }

        /// <summary>
        /// Constructeur incrémentant la quantité d'instance de classe.
        /// </summary>
        public Maïs()
        {
            Count++;
        }
        /// <summary>
        /// Dénstructeur décrémentant la quantité d'instance de classe.
        /// </summary>
        ~Maïs()
        {
            Count--;
        }   
    }
}
