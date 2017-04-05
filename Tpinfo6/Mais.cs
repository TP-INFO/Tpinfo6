using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    public class Mais : Flora
    {
        /// <summary>
        /// Méthode générant un nombre aléatoire d'épis de Maïs
        /// </summary>
        public void GenerateMais()
        {
            Random random = new Random();
            int mais = random.Next(100, 1000);

            if (mais < 200)
            {
                Console.WriteLine("\tEtes vous sûr d'être un fermier ? .. Votre champ n'a produit que {0} brins de maïs cette semaine..", mais);
            }
            else if (mais > 200 && mais < 500)
            {
                Console.WriteLine("\tVotre technique n'est certainement pas bonne .. Le champ n'a produit que {0} brins de maïs cette semaine..", mais);
            }
            else if (mais > 500 && mais < 700)
            {
                Console.WriteLine("\tC'est une bonne récolte que vous avez là ! Vous allez pouvoir récolter {0} brin de maïs cette semaine !", mais); 
            }
            else
            {
                Console.WriteLine("\tQuel chance !\n" +
                                  "\tUne récolte exceptionnel de {0} maïs s'offre à vous, bonne régalade !", mais);
            }
        }

        /// <summary>
        /// Catastrophe aléatoire détruisant le Maïs
        /// </summary>
        public override void Mourrir()
        {
            Random random = new Random();
            int cataclysm = random.Next(0, 2);
            if (cataclysm == 0)
            {
                Console.WriteLine("\n\tOh non ! Le champ de Maïs a été dévorés par des sauterelles !");
            }
            else if (cataclysm == 1)
            {
                Console.WriteLine("\n\tOh non ! Vous avez oublié d'arroser le champ de Maïs, ils sont tous carbonisés ! (>.<)");
            }
            else
            {
                Console.WriteLine("\n\tOh non ! Le champ de Maïs a été dévasté par une pluie de météorites !");
            }
        }

        /*──────────────────|
        |   Constructeurs   |
        |──────────────────*/
        public void Maïs()
        {

        }
    }
}
