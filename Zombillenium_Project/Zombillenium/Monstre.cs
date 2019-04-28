using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombillenium
{
    class Monstre : Personnel
    {
        private Attraction affectation;
        private int cagnotte;
        

        public Monstre(Attraction affectation, int cagnotte, string fonction, int matricule, string nom, string prenom, TypeSexe sexe) : base(fonction, matricule, nom, prenom, sexe)
        {
            this.Affectation = affectation;
            this.Cagnotte = cagnotte;
        }

        public int Cagnotte
        {
            get
            {
                return cagnotte;
            }

            set
            {
                cagnotte = value;
            }
        }

        internal Attraction Affectation
        {
            get
            {
                return affectation;
            }

            set
            {
                affectation = value;
            }
        }

        public override string ToString()
        {
            string chaine = "";
            if(Affectation != null)
            {
                chaine += base.ToString() + " Affectation : " + Affectation.Identifiant + " |" + " Cagnotte : " + Cagnotte + " | \n";
            }
            else
            {
                chaine += base.ToString() + " Affectation : Pas d'affectation" + "\n" + " Cagnotte : " + Cagnotte + " | \n";
            }
            
            return chaine;
        }
    }
}
