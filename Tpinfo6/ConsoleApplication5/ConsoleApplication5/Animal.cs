using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    public abstract class Animal : IVirus
    {
        public string nom;
        private bool _nourri;
        public bool Nourri
        {
            get
            {
                return _nourri;
            }

            set
            {
                _nourri = value;
            }
        }

        /// <summary>
        /// l'animal se déplace (/◕ヮ◕)/
        /// </summary>
        public abstract void  SeDeplacer();

        ///  <summary>
        /// L'animal mange le vegetal veg en quantite q (indice i de la liste) qui diminue en conséquence.
        /// </summary>
        /// (ノಠ益ಠ)ノ彡┻━┻   
        public virtual void Manger(Vegetal veg,List<int>quantite, int index)
        {
            this._nourri = true;
            quantite[index]--;
        }

        /// <summary>
        /// Redéfinition de tostring pour occulter le namespace
        /// </summary>
        /// <returns>Renvoie "Animal"
        /// </returns>
        public override string ToString()
        {
            return base.ToString().Remove(0, 20);
        }

        /// <summary>
        /// Constructeur utile ?
        /// </summary>
        /// <param name="nom"></param>
        protected Animal(string nom) { this.nom = nom; }

        /// <summary>
        /// L'animal tombe-t-il malade ? Nombre aléatoire entre 0 et 4 pour le déterminer, 20% de chance d'infection.
        /// </summary>
        /// <returns>
        /// true si l'animal est infecté, false sinon
        /// </returns>
        public bool Infecter()
        {
            Random infection = new Random();
            if (infection.Next(5) == 0) return true; else return false;
        }
    }
}
