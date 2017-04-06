using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tpinfo6
{
    class Program
    {
        const double VERSION = 0.92; 

        static void Main(string[] args)
        {

            InitiateStory.Start();

            InitiateStory.ConfigStory();

            InitiateStory.StartStory();

            #region Structure de Tests

            //Dindon Din = new Dindon();
            //Din.Nom = "Glou";
            //Din.Glouglouter();

            //Couteau Cou = new Couteau();
            //Cou.TuerAnimal(Din);

            //Virus h5n1 = new Virus();
            //h5n1.infecterMammifere(Pepper, Homme);
            //h5n1.infecterAnimal(Pepper, Dog);

            #endregion

            #region ToDo :

            /*        
                      Général :
                      { --STATIC--

                      Mettre header "Welcome in" persistant
                      Présenter le Contexte et mettre en place la semaine

                      }

                      Actions :
                     
                      Définir des méthodes d'actions pour les Androides
                      Implémenter les méthodes pour la class Clone
                      -DONE- Régler la question du couteau pour Tuer()
                      -DONE- Créer Méthode pour infecter animaux
                      -DONE- Définir les méthodes d'actions pour les animaux 
                      -DONE- Mettre en place une struct pour Clone

                      Flora :
                      -DONE- Définir pour chaques jour des changements d'états dans les arbres et plantes
                      Empêcher récolte selon les jours
                      -DONE- Méthode aléatoire pour faire mourrir ou non les arbres/plantes
                      -DONE- Méthode aléatoire quand fermier taille pour que l'arbre meurt

                      Humain :
                      -DONE- Implémenter fonction RentrerChezSoi()
                      -DONE- Terminer Manger() et Mourrir() pour Humains, Androïdes
                      -DONE- Implementer Switch-Alt(Manger)
            */
            #endregion



        }//End of Main
    }
}
