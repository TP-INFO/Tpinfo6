using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{
    public abstract class Astre
    {
        protected DateTime _dtHLever;
        protected DateTime _dtHCoucher;

        public DateTime DTHLever
        {
            get
            {
                return this._dtHLever;
            }
            set
            {
                this._dtHLever = value;
            }
        }


        public DateTime DTHCoucher
        {
            get
            {
                return this._dtHCoucher;
            }
            set
            {
                this._dtHCoucher = value;
            }
        }

        public Astre()
        {

        }

        abstract public void SeLever();        

        abstract public void SeCoucher();

    }
}
