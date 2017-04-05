﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tpinfo6
{
    public abstract class NewHumanity : IMammifere
    {
        /*──────────────────|
        |     Attributs     |
        |──────────────────*/
        private string _userChoice;
        private string _nom;
        private string _prenom;

        public string UserChoice
        {
            get { return this._userChoice; }
            set { _userChoice = value; }
        }

        public string Nom
        {
            get { return this._nom; }
            set { _nom = value; }
        }

        /*──────────────────|
        |      Méthodes     |
        |──────────────────*/

        public virtual void RentrerChezSoi()
        {

        }

        public virtual void SeDeplacer()
        {

        }

        public virtual void Manger()
        {

        }

        public virtual void ToDo()
        {

        }

        public virtual void ToDoInHouse()
        {

        }

        public virtual void Mourrir()
        {
            Console.WriteLine("\n\tOh non ! {0} est mort ! Comment allez vous faire ?", Nom);
        }

        /// <summary>
        /// Méthode permettant à un humain de s'endormir !
        /// </summary>
        public virtual void Dormir()
        {
            Console.WriteLine("\n\t{0} va se coucher.", Nom);
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("\t[...]");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("\t{0} s'endort paisiblement *zZz ZzzZ zzZz*", Nom);
        }


    }//End Of class
}
