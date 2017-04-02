﻿using System;
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
                Console.WriteLine("Etes vous sûr d'être un fermier ? .. Votre champ n'a produit que " + mais + " maïs cette semaine..");
            }
            else if (mais > 200 && mais < 500)
            {
                Console.WriteLine("Votre technique n'est certainement pas bonne .. Le champ n'a produit que " + mais + " maïs cette semaine..");
            }
            else if (mais > 500 && mais < 700)
            {
                Console.WriteLine("C'est une bonne récolte que vous avez là ! Vous allez pouvoir récolter " + mais + " maïs cette semaine !"); 
            }
            else
            {
                Console.WriteLine("Quel chance !\n" +
                                  "Une récolte exceptionnel de" + mais + " maïs s'offre à vous, bonne régalade !");
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
