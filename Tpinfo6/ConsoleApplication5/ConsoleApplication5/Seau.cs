using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    static class Seau
    {
        /// <summary>
        /// Méthode remplir le seau avec les fruits/légumes à condition que le nombre de ceux-ci ne soit pas nul.
        /// </summary>
        /// <param name="veg"></param>
        /// <param name="quantite"></param>
        /// <param name="index"></param>
        public static void RemplirSeau(Vegetal veg,List<int>quantite,int index)
        {
            switch (veg.ToString())
            {
                case "Abricotier":
                    if (quantite[index]==0)
                    {
                        Console.WriteLine($"Erreur : pas assez de {veg}");
                        throw new Exception();
                    }
                    break;
                case "Chou":
                    if (quantite[index] == 0)
                    {
                        Console.WriteLine($"Erreur : pas assez de {veg}");
                        throw new Exception();
                    }
                    break;
                case "Maïs":
                    if (quantite[index] == 0)
                    {
                        Console.WriteLine($"Erreur : pas assez de {veg}");
                        throw new Exception();
                    }
                    break;
                default:
                    throw new Exception();

            }
        }
    }
}
