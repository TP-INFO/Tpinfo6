using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2017_03_22_TP6
{
    public class Soleil : Astre
    {
        
        public Soleil()
        {
           
        }

        public void PremierLever(DateTime dtHPremierLever)
        {
            Console.WriteLine("Une nouvelle semaine commence à la ferme 'Farm 3000': le soleil se lève, nous sommes le {0}", dtHPremierLever);
        }
        public void DernierCoucher(DateTime dtHDernierCoucher)
        {
            Console.WriteLine("Encore une semaine qui se termine à la ferme 'Farm 3000': le soleil se couche, nous sommes le {0}", dtHDernierCoucher);
        }
        public override void SeLever()
        {
            Console.WriteLine("Le soleil se lève"); 
        }
        public override void SeCoucher()
        {
            Console.WriteLine("Le soleil se couche");
        }
    }
}
