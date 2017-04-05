using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Humain
    {
        private string nom;
        private string sexe;
        private int age;
        /// <summary>
        /// Accesseurs
        /// </summary>
        public string Nom
        {
            get { return nom; }

            set { nom = value; }
        }
        public string Sexe
        {
            get { return sexe; }

            set { sexe = value; }
        }
        public int Age
        {
            get { return age; }

            set { age = value; }
        }

        /// <summary>
        /// Méthode nourrir les animaux implique de remplir le seau et d'activer la méthode manger des animaux
        /// </summary>
        /// <param name="nomAnimal"></param>
        /// <param name="veg"></param>
        /// <param name="quantite"></param>
        /// <param name="index"></param>
        public void NourrirAnimaux(Animal nomAnimal,Vegetal veg, List<int>quantite, int index)
        {
            Seau.RemplirSeau(veg,quantite,index);
            nomAnimal.Manger(veg,quantite,index);
        }

        /// <summary>
        /// Plante le fruit/légume en créant une nouvelle instance de celui-ci.
        /// </summary>
        /// <param name="nomVegetal"></param>
        /// <returns>
        /// renvoie l'instance du fruit/légume
        /// </returns>
        ///.....φ(・∀・＊)
        public Vegetal Planter(Vegg nomVegetal)
        {         
            switch (nomVegetal)
            {
                case Vegg.Abricotier:      
                     Abricotier abricot = new Abricotier();
                    return abricot;
                case Vegg.Chou:
                    Chou chou = new Chou();
                    return chou;
                case Vegg.Maïs:
                    Maïs maïs = new Maïs();
                    return maïs;
                default:
                    throw new Exception();
            }
        }

        /// <summary>
        /// Constructeur nécessitant le nom, le sexe et l'âge.
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="sexe"></param>
        /// <param name="age"></param>
       public Humain(string nom, string sexe, int age)
        {
            this.nom = nom;
            this.sexe = sexe;
            this.age = age;
        }


    

}
}
