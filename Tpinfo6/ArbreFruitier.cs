using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{
    public abstract class ArbreFruitier : Végétal
    {
        /// <summary>
        /// Private double indiquant le nombre de fruits sur l'arbre
        /// </summary>
        private double _nNbreFruits;
        
        /// <summary>
        /// Accesseur
        /// </summary>
        public double NNbreFruits
        {
            get
            {
                return this._nNbreFruits;
            }
            set
            {
                this._nNbreFruits=value;
            }
        }
        /// <summary>
        /// Constructeur vide
        /// </summary>
        public ArbreFruitier()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="tauxCroissance"></param>
        public virtual void PousseNouveauxFruits(double tauxCroissance)
        {
            double temp = _nNbreFruits;
            _nNbreFruits *= tauxCroissance;
            Console.WriteLine("Aujourd'hui, {0} nouveaux fruits!", _nNbreFruits-temp);
        }
    }
}
