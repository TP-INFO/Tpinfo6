using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciation d'un objet en utilisant l'enum.
            //Animaux ani1 = new Animaux("chevre", RessourcesGenre.Animal);
            //Console.WriteLine("Ani1 est une "+ani1.LeType+". C'est un "+ani1.LeGenre);
            //Vegetal veg1 = new Vegetal("abricotier", RessourcesGenre.Vegetal);
            //Console.WriteLine("veg1 est une " + veg1.LEssence + ". C'est un " + veg1.LeGenre);
            //Vegetal[] arbes = new Vegetal[10];



            // Lance le programme.
            // TODO à mettre en invite de commande.

            Abricotier abri1 = new Abricotier(TypeVivant.Vegetal,20);
            
            TroupeauMohamed<Abricotier> ListAbricotier = new TroupeauMohamed<Abricotier>(10);
            



            //Occupant fermier = new Occupant("Charettier", NatureOccupant.Humaine);
            //Occupant fermiere = new Occupant("Charettière", NatureOccupant.Humaine);
            //Occupant androide = new Occupant("MarcelX34", NatureOccupant.Artificielle);
            //Console.WriteLine("La ferme est dirigée par Mr."+fermier.LeNom+", Mme. "+fermiere.LeNom+", et sont épaulés par "+androide.LeNom+" l'androide.");

        }
    }
}
