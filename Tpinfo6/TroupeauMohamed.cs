using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    class TroupeauMohamed<T> 
    {
        private List<T> _troupeau;

        public TroupeauMohamed(int nombre)
        {
            _troupeau = new List<T>();
        }


        public void Add(T item)
        {
            if (_troupeau.Count < _troupeau.Capacity)
            {
                _troupeau.Add(item);
            }
        }


    }
}
