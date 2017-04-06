using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tpinfo6
{
    public static class Initialisation
    {
        public static void InitialisationDeb()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("BIENVENU A LA FERME VIRALE");
            Console.WriteLine("--------------------------");

            Console.WriteLine("Tout d'abord il est temps de créer la ferme : ");
            Console.WriteLine("Ses ressources : animaux, légumes et arbres fruitiers");
            Console.WriteLine("et ses occupants");
            Console.WriteLine();

            Console.WriteLine("Entrez '1' pour les chèvres");
            Console.WriteLine("Entrez '2' pour les dindons");
            Console.WriteLine("Entrez '3' pour les abricotiers");
            Console.WriteLine("Entrez '4' pour les cerisiers");
            Console.WriteLine("Entrez '5' pour les choux");
            Console.WriteLine("Entrez '6' pour le maïs");
            Console.WriteLine("Entrez '7' pour les occupants");
            Console.WriteLine("Entrez '8' pour les chiens");
            Console.WriteLine();
            Console.WriteLine("Choissisez votre section : ");
            short habitant = Convert.ToInt16(Console.ReadLine());
            bool b1 = true, b2 = true, b3 = true, b4 = true, b5 = true, b6 = true;
            while ((b1 != false) && (b2 != false) && (b3 != false) && (b4 !=false) && (b5 != false) && (b6 != false))
            {

            }
            switch (habitant)
            {
                case 1:
                    InitChevres();
                    b1 = false;
                    break;
                case 2:
                    Initdindons();
                    b2 = false;
                    break;
                case 3:
                    InitAbricotier();
                    break;
                case 4:
                    InitCerisier();
                    break;
                case 5:
                    InitChou();
                    break;
                case 6:
                    InitEpiMaïs();
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Initialise la création du troupeau de chèvres.
        /// Les objets sont placés dans une liste.
        /// Appelle la méthode de création de troupeau "CreerTroupeau".
        /// </summary>
        public static void InitChevres()
        {
            short nbreMin = 1;
            short nbreMax = 20;
            short nbreHabitant = 0;
            string habitant = "1 - 20";

            CreerTroupeau(habitant, ref nbreHabitant, nbreMin, nbreMax);
            
            List<Animaux> chevre = new List<Animaux>();
            for (int i = 0; i <= nbreHabitant; i++)
            {
                chevre.Add(new Animaux("chevre" + i, RessourcesGenre.Animal));
            }
            foreach (Animaux item in chevre)
            {
                Console.WriteLine(item.LeType);
            }
        }

        /// <summary>
        /// Initialise la création du troupeau de dindons.
        /// Les objets sont placés dans une liste.
        /// Appelle la méthode de création de troupeau "CreerTroupeau".
        /// </summary>
        public static void Initdindons()
        {
            short nbreMin = 2;
            short nbreMax = 20;
            short nbreHabitant = 0;
            string habitant = "2 - 20";

            CreerTroupeau(habitant, ref nbreHabitant, nbreMin, nbreMax);
            
            List<Animaux> dindon = new List<Animaux>();
            for (int i = 0; i <= nbreHabitant; i++)
            {
                dindon.Add(new Animaux("dindon" + i, RessourcesGenre.Animal));
            }
            foreach (Animaux item in dindon)
            {
                Console.WriteLine(item.LeType);
            }          
        }

        /// <summary>
        /// Initialise la création du troupeau de chiens.
        /// Les objets sont placés dans une liste.
        /// Appelle la méthode de création de troupeau "CreerTroupeau"
        /// </summary>
        public static void InitCerisier()
        {
            short nbreMin = 0;
            short nbreMax = 15;
            short nbreHabitant = 0;
            string habitant = "0 - 15";

            CreerTroupeau(habitant, ref nbreHabitant, nbreMin, nbreMax);

            List<Vegetal> cerisier = new List<Vegetal>();
            for (int i = 0; i < nbreHabitant; i++)
            {
                cerisier.Add(new Vegetal("cerisier" + i, RessourcesGenre.Vegetal));
            }
            foreach (Vegetal item in cerisier)
            {
                Console.WriteLine(item.LEssence);
            }
         }
        /// <summary>
        /// Initialise la création du troupeau d'abricotiers.
        /// Les objets sont placés dans une liste.
        /// Appelle la méthode de création de troupeau "CreerTroupeau"
        /// </summary>
        public static void InitAbricotier()
        {
            short nbreMin = 0;
            short nbreMax = 15;
            short nbreHabitant = 0;
            string habitant = "0 - 15";

            CreerTroupeau(habitant, ref nbreHabitant, nbreMin, nbreMax);
            
            List<Vegetal> abricotier = new List<Vegetal>();
            for (int i = 0; i < nbreHabitant; i++)
            {
                abricotier.Add(new Vegetal("abricotier" + i, RessourcesGenre.Vegetal));
            }
            foreach (Vegetal item in abricotier)
            {
                Console.WriteLine(item.LEssence);
            }
        }
        /// <summary>
        /// Initialise la création du troupeau de choux.
        /// Les objets sont placés dans une liste.
        /// Appelle la méthode de création de troupeau "CreerTroupeau"
        /// </summary>
        public static void InitChou()
        {
            short nbreMin = 0;
            short nbreMax = 40;
            short nbreHabitant = 0;
            string habitant = "0 - 40";

            CreerTroupeau(habitant, ref nbreHabitant, nbreMin, nbreMax);
            
            List<Vegetal> chou = new List<Vegetal>();
            for (int i = 0; i < nbreHabitant; i++)
            {
                chou.Add(new Vegetal("chou" + i, RessourcesGenre.Vegetal));
            }
            foreach (Vegetal item in chou)
            {
                Console.WriteLine(item.LEssence);
            }
        }
        public static void InitEpiMaïs()
        {
            short nbreMin = 0;
            short nbreMax = 50;
            short nbreHabitant = 0;
            string habitant = "0 - 50";

            CreerTroupeau(habitant, ref nbreHabitant, nbreMin, nbreMax);
            
            List<Vegetal> epiMaïs = new List<Vegetal>();
            for (int i = 0; i < nbreHabitant; i++)
            {
                epiMaïs.Add(new Vegetal("Epi de maïs" + i, RessourcesGenre.Vegetal));
            }
            foreach (Vegetal item in epiMaïs)
            {
                Console.WriteLine(item.LEssence);
            }
        }
        /// <summary>
        /// Initialise la création du troupeau de chiens.
        /// Les objets sont placés dans une liste.
        /// Appelle la méthode de création de troupeau "CreerTroupeau"
        /// </summary>
        public static void Initchiens()
        {
            short nbreMin = 1;
            short nbreMax = 3;
            short nbreHabitant = 0;
            string habitant = "1 - 3";

            CreerTroupeau(habitant, ref nbreHabitant, nbreMin, nbreMax);

            List<Animaux> chien = new List<Animaux>();
            for (int i = 0; i < nbreHabitant; i++)
            {
                chien.Add(new Animaux("chien" + i, RessourcesGenre.Animal));
            }
            foreach (Animaux item in chien)
            {
                Console.WriteLine(item.LeType);
            }
        }

        /// <summary>
        /// Méthode de création du troupeau.
        /// Les paramètres proviennent de la spécificité de l'espèce.
        /// Effectue un test si le nombre saisi est hors intervalle.
        /// </summary>
        /// <param name="habitant"></param>
        /// <param name="nbreHabitant"></param>
        /// <param name="nbreMin"></param>
        /// <param name="nbreMax"></param>
        private static void CreerTroupeau(string habitant, ref short nbreHabitant, short nbreMin, short nbreMax)
        {
            bool test;
            do
            {
                test = true;
                Console.WriteLine("Entre un nombre entre " + habitant + ", mon gars ! :");
                short nbreHab = Convert.ToInt16(Console.ReadLine());
                nbreHabitant = nbreHab;
                if ((nbreHab < nbreMin) || (nbreHab > nbreMax))
                {
                    Console.WriteLine("Bon sang ! T'es à la campagne et tu sais pas lire et écrire ? Recommence couille de loup !");
                    Console.WriteLine();
                    test = false;
                }
            } while (test == false);
        }






    }
}