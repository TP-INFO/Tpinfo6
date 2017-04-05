using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{
    public abstract class ArbreFruitier : Végétal
    {
        private double _nNbreFruits;
        
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

        public ArbreFruitier()
        {

        }

        public virtual void PousseNouveauxFruits(double tauxCroissance)
        {
            double temp = _nNbreFruits;
            _nNbreFruits *= tauxCroissance;
            Console.WriteLine("Aujourd'hui, {0} nouveaux fruits!", _nNbreFruits-temp);
        }
    }
}
