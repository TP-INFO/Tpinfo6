using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Chou : Vegetal
    {
        private const string nom="Chou";
        public string Nom => nom;
        public static int Count;        
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
        /// Fait pousser entre 1 et 3 choux
        /// </summary>
        public override int Pousser()
        {
            Random rd = new Random();
            return Quantite = rd.Next(1,4);
            
        }
        /// <summary>
        /// Constructeur incrémentant la quantité d'instance de classe.
        /// </summary>
        public Chou()
        {
            Count++;
        }
        /// <summary>
        /// Déconstructeur décrémentant la quantité d'instance de classe
        /// </summary>
        ~Chou()
        {
            Count--;
        }
    
    }
}
