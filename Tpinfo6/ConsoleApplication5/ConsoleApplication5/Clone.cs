using System;

namespace ConsoleApplication5
{
    struct Clone
    {
        public string Nom { get; set; }
        public string Sexe{ get; set; }
        public int Age{ get; set; }

        /// <summary>
        /// Récolte le fruit/légume en créant une nouvelle instance de celui-ci.
        /// </summary>
        /// <param name="nomVegetal"></param>
        /// <returns>
        /// renvoie l'instance du fruit/légume
        /// </returns>
        ///.....φ(・∀・＊)
        public Vegetal Recolter(Vegg nomVegetal)
        {
            switch (nomVegetal)
            {
                case Vegg.Abricotier:
                    Abricotier abricot = new Abricotier();
                    return abricot;
                case Vegg.Chou:
                    Chou chou = new ConsoleApplication5.Chou();
                    return chou;
                case Vegg.Maïs:
                    Maïs maïs = new ConsoleApplication5.Maïs();
                    return maïs;
                default:
                    throw new Exception();
            }
        }
    }
}