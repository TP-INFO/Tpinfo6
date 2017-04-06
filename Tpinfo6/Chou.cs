using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    /// <summary>
    /// Classe publique permettant de créer un chou et de lui attribuer des méthodes
    /// </summary>
    public class Chou : Flora
    {
        /*──────────────────|
        |      Méthodes     |
        |──────────────────*/

        /// <summary>
        /// Génére un nombre aléatoires de chou(x)
        /// </summary>
        public void GenerateChou()
        {
            Random random = new Random();
            int chou = random.Next(1, 30);

            if (chou < 5)
            {
                Console.WriteLine("\tSavez-vous planter les choux ? .. Votre champ n'a produit que {0} choux cette semaine..", chou);
            }
            else if (chou > 5 && chou < 10)
            {
                Console.WriteLine("\tVotre technique n'est certainement pas bonne .. Le champ n'a produit que {0} choux cette semaine..", chou);
            }
            else if (chou > 10 && chou < 20)
            {
                Console.WriteLine("\tC'est une bonne récolte que vous avez là ! Vous allez pouvoir récolter {0} choux cette semaine !\n", chou);
                Console.WriteLine("\tA vos fourneaux !");
            }
            else
            {
                Console.WriteLine("\tQuel chance !\n" +
                                  "\tUne récolte exceptionnel de {0} choux s'offre à vous, bonne régalade !", chou);
            }
        }

        /// <summary>
        /// Castastrophe aléatoire faisant mourrir les choux
        /// </summary>
        public override void Mourrir()
        {
            Random random = new Random();
            int cataclysm = random.Next(0, 2);
            if (cataclysm == 0)
            {
                Console.WriteLine("\n\tOh non ! Les choux ont été dévorés par des Lapins !");
                Console.Write("\t (\\-/)\n" +
                              "\t(='.'=)\n" +
                              "\t(o)-(o)");
            }
            else if (cataclysm == 1)
            {
                Console.WriteLine("\n\tOh non ! Vous avez oublié d'arroser les choux, ils sont tous carbonisés ! (>.<)");
            }
            else
            {
                Console.WriteLine("\n\tOh non ! Les choux ont été dévastés par une météorite !");
            }
        }
    }
}
