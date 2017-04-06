using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Tpinfo6
{
    class Program
    {
        public static void Main(string[] args)
        {
            ///Déclaration de la variable de type int: jour, initialisée à la valeur de Jours.Lundi
            int jour = (int)Jours.Lundi;
            Console.WriteLine();
            while (jour!=8)
            {
                //Switch permettant d'indiquer les activités se déroulant sur la ferme, jour par jour
                switch (jour)
                {
                    case 1:
                        Console.WriteLine(Jours.Lundi);
                        DerouleJournee.ActionsJournee();
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine(Jours.Mardi);
                        DerouleJournee.ActionsJournee();
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine(Jours.Mercredi);
                        DerouleJournee.ActionsJournee();
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine(Jours.Jeudi);
                        DerouleJournee.ActionsJournee();
                        Console.WriteLine();
                        break;
                    case 5:
                        Console.WriteLine(Jours.Vendredi);
                        DerouleJournee.ActionsJournee();
                        Console.WriteLine();
                        break;
                    case 6:
                        Console.WriteLine(Jours.Samedi);
                        DerouleJournee.ActionsJournee();

                        Console.WriteLine();
                        break;
                    case 7:
                        Console.WriteLine(Jours.Dimanche);
                        DerouleJournee.ActionsJournee();
                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
                //Incrémentation de jour, pour dérouler la semaine, jusqu'au dimanche
                jour++;
            }
        }

        
    }
}
