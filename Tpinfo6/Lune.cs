using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    public class Lune : Astre
    {

        public override void SeLever()
        {
            Console.WriteLine("La nuit fait son apparition ..\n");
            Console.WriteLine("La Lune se lève !");
            nuit = true;
        }

        public override void SeCoucher()
        {
            Console.WriteLine("La lune disparaît dans le Crépuscule\n");
            Console.WriteLine("[...]\n");
            Console.WriteLine("Le jour se lève ..\n");
            nuit = false;
        }

        public Lune()
        {

        }
    }
}
