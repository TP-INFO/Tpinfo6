using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tpinfo6
{
    /// <summary>
    /// on trouve, les végétaux, les animaux et le virus.
    /// Le virus peut être affamé et infecter ou bien devenir malade quand soin ou traitement.
    /// L'attribut genre peut signifier Animal, Végétal ou Virus (voir enum)
    /// </summary>
    public abstract class Ressources
    {
        private bool Affame;
        private bool Malade;
        private RessourcesGenre Genre;
        private int Quantité;

        public Ressources(RessourcesGenre Genre)
        {
            this.Genre = Genre;
        }

        public Ressources(RessourcesGenre Genre, bool Affame)
        {
            this.Genre = Genre;
            this.Affame = Affame;
        }

        public void Ressource(bool Malade)
        {
            this.Malade = Malade;
        }

        public bool LAffame
        {
            get { return Affame; }
            set { Affame = value;}
        }

        public RessourcesGenre LeGenre
        {
            get { return Genre; }
            set { Genre = value; }
        }
        public bool LeMalade
        {
            get { return Malade;}
            set { Malade = value;}
        }

        public int LaQuantité
        {
            get { return Quantité;}
            set { Quantité = value;}
        }

    }
}