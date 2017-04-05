using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Initialisation de la ferme !
            Console.WriteLine(
                "Bienvenue à la ferme !\nVous allez au cours d'une semaine vous occuper de vos animaux et de votre potager." +
                "\nCommencer par donner un nom à votre fermier.");

                string sNomFermier = Console.ReadLine();
                Humain personne = new Humain(sNomFermier, "homme", 35);

            Console.WriteLine(
                $"Pour aider le fermier {sNomFermier}, clonons le ! Vous avez maintenant plus de bras \tpour travailler");
                // On crée notre clone du fermier
                Clone luc = new Clone
                {
                    Age = personne.Age,
                    Sexe = personne.Sexe,
                    Nom = "Clone_"+sNomFermier
                };

            Console.WriteLine("Vous avez trois animaux ! Un dindon doudou, un chien toutou, et une chèvre chevrou.\n+" +
                              "Il faudra veiller à les nourrir avec leurs aliments favoris.");
                //On crée les animaux
                List<Animal> animal = new List<Animal>();

                Dindon doudou = new Dindon("doudou");
                animal.Add(doudou);
                doudou.Nourri = false;

                Chevre chevrou = new Chevre("chevrou");
                animal.Add(chevrou);
                chevrou.Nourri = false;

                Chien toutou = new Chien("toutou");
                animal.Add(toutou);
                toutou.Nourri = false;

                List<Vegetal> produit = new List<Vegetal>();
                List<int> quantite = new List<int>();

            #endregion

            #region boucle de la semaine !
            foreach (Jours jours in Enum.GetValues(typeof(Jours)))
            {
                 Console.WriteLine(
                    "****************************************************\nFARMONS UN PEU\n****************************************************");
                var sJourNuit = Soleil.Cycle(DateTime.Now) ? "jour" : "nuit";
                Console.WriteLine($"Bonjour ! Nous sommes {jours}. Il est {DateTime.Now.Hour}:{DateTime.Now.Minute}, il fait donc {sJourNuit}.");

                bool t = true;
                do          
                {
                    Console.WriteLine("Voulez-vous planter des fruits et légumes ? O/N");
                    string reponse = Console.ReadLine().ToUpper();
                    t = AppelPlanter(produit, personne,reponse); 
                    if (t==false)
                        if(!produit.Exists(x=> x is Abricotier) || !produit.Exists(x => x is Chou) || !produit.Exists(x => x is Maïs))
                    {
                        //Vérif qu'il y a les trois produits de base.
                        Console.WriteLine("Planter au moins un de chaque type :)");
                        t= AppelPlanter(produit, personne,"O"); 
                    }
                } while (t);

                // On fait pousser
                 quantite.AddRange(produit.Select(food => food.Pousser()).ToList());
                
                //Affichage de notre stock
                for (int i = 0; i < produit.Count; i++)
                {
                    Console.WriteLine(produit[i].ToString() + " : " + quantite[i]);
                }
                
                // On regroupe et trie le stock
                CorrigerListe(produit, quantite);
                TrierListe(produit, quantite);

                Console.WriteLine(
                    "****************************************************\nMAGIE\n****************************************************");
                //RE
                for (int i = 0; i < produit.Count; i++)
                {
                    Console.WriteLine(produit[i].ToString() + " : " + quantite[i]);
                }
                Console.WriteLine(
                    "****************************************************\nNOURRIR LES ANIMAUX !\n****************************************************");
                //Nourissage des bestiaux

                RoutineNourrir(animal, personne, produit, quantite);
                Console.WriteLine(
                    "****************************************************\nLES ANIMAUX SONT-ILS NOURRIS ?\n****************************************************");
                foreach (Animal bete in animal)
                {
                    string fed;
                    fed = bete.Nourri == true ? "Oui." : "Non.";
                    Console.WriteLine("{0} a-t-il mangé ? {1}", bete.nom, fed);
                }

                Console.WriteLine(
                    "****************************************************\nSTOCK DES PRODUITS DE LA FERME APRES REPAS\n****************************************************");
                for (int i = 0; i < produit.Count; i++)
                {
                    Console.WriteLine($"Quantité restante de {produit[i].ToString()} : {quantite[i]}");
                }
            }
        }
        #endregion

        public static bool AppelPlanter(List<Vegetal> produit, Humain personne,string reponse)
        {
            
  
            if (reponse != "O" && reponse != "N")
            {
                Exception ex = new Exception();
                Console.WriteLine("Erreur : réponse doit etre O ou N");
                Console.WriteLine(ex.Message);
                return true;
            }
            if (reponse == "N")
            {
                return false;
            }
            else
            {
                var food = PlanterProduits(personne);
                produit.Add(food);
                return true;
            }

        }

        public static Vegetal PlanterProduits(Humain personne)
        {
            // Planter les plantes
            Console.WriteLine("Que voulez-vous que le fermier {0} plante ? Abricotier - Chou - Maïs.",personne.Nom);
            string fruitzelegumes = Console.ReadLine().ToUpper();
            switch (fruitzelegumes)
            {
                case "ABRICOTIER":
                    var abricot = personne.Planter(Vegg.Abricotier);
                    Console.WriteLine("Le nombre d'abricotier est de : {0}", Abricotier.Count);
                    return abricot;
                case "CHOU":
                    var chou = personne.Planter(Vegg.Chou);
                    Console.WriteLine("Le nombre de choux est de : {0}", Chou.Count);
                    return chou;
                case "MAÏS":
                    var maïs = personne.Planter(Vegg.Maïs);
                    Console.WriteLine("Le nombre de maïs est de : {0}", Maïs.Count);
                    return maïs;
                case "MAIS":
                    maïs = personne.Planter(Vegg.Maïs);
                    Console.WriteLine("Le nombre de maïs est de : {0}", Maïs.Count);
                    return maïs;
                default:
                    throw new ArgumentException();
            }
        }

        public static void RoutineNourrir(List<Animal> animal, Humain personne, List<Vegetal> produit,List<int>quantite)
        {
            Console.WriteLine(animal.Count);
            foreach (Animal bete in animal)
            {
                try
                {
                    Console.WriteLine($"Quel aliment donner à {bete} ? Abricot - Chou - Maïs");
                    string reponse = Console.ReadLine().ToUpperInvariant();
                    switch (reponse)
                    {
                        case "ABRICOT":
                            int iAbricot = produit.FindIndex(x => x is Abricotier);
                            personne.NourrirAnimaux(bete, produit[iAbricot], quantite, iAbricot);
                            break;
                        case "CHOU":
                            int iChou = produit.FindIndex(x => x is Chou);
                            personne.NourrirAnimaux(bete, produit[iChou], quantite, iChou);
                            break;
                        case "MAÏS":
                            int iMaïs = produit.FindIndex(x => x is Maïs);
                            personne.NourrirAnimaux(bete, produit[iMaïs], quantite, iMaïs);
                            break;
                        default:
                            throw new ArgumentNullException();
                    }
                }
                catch (ArgumentNullException an)
                {
                    Console.WriteLine("Erreur : entrer un argument ! !");
                    Console.WriteLine(an.Message);
                    RoutineNourrir(animal, personne, produit, quantite);
                }
                catch (Exception)
                {
                    Console.WriteLine("Erreur : mauvaise nourriture !");
                    RoutineNourrir(animal, personne, produit, quantite);
                }
            }
        }

        public static void CorrigerListe(List<Vegetal> produit, List<int> quantite)
        {
            for (int i = 0; i < produit.Count; i++)
            {
                for (int j = 0; j < produit.Count; j++)
                {
                    if (i!=j)
                    {
                        if (produit[i].Equals(produit[j])==true)
                        {
                            quantite[i] += quantite[j];
                            produit.RemoveAt(j);
                            quantite.RemoveAt(j);
                            j--;
                        }
                    }
                }
            }
        }

        public static void TrierListe(List<Vegetal> produit, List<int> quantite)
        {
            int[] indice = new int[3];
            indice[0] = produit.FindIndex(x => x is Abricotier);
            indice[1] = produit.FindIndex(x => x is Chou);
            indice[2] = produit.FindIndex(x => x is Maïs);

            Vegetal[] produitbis = new Vegetal[3];
            int[] quantitebis = new int[3];

            for (int i = 0; i < 3; i++)
            {
                produitbis[i] = produit[indice[i]];
                quantitebis[i] = quantite[indice[i]];
            }

            for (int i = 0; i < 3; i++)
            {
                produit[i] = produitbis[i];
                quantite[i] = quantitebis[i];
            }
        }

       
    }
}
