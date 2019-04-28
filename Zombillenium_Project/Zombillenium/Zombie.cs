using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombillenium
{
    class Zombie : Monstre
    {
        private int degre_decomposition;
        private CouleurZ teint;
        private string nom1;

        public int Degre_decomposition
        {
            get
            {
                return degre_decomposition;
            }

            set
            {
                degre_decomposition = value;
            }
        }

        public string Nom1
        {
            get
            {
                return nom1;
            }

            set
            {
                nom1 = value;
            }
        }

        internal CouleurZ Teint
        {
            get
            {
                return teint;
            }

            set
            {
                teint = value;
            }
        }

        public Zombie(int degre_decomposition, CouleurZ teint, Attraction affectation, int cagnotte, string fonction, int matricule, string nom, string prenom, TypeSexe sexe) : base(affectation, cagnotte, fonction, matricule, nom, prenom, sexe)
        {
            this.Degre_decomposition = degre_decomposition;
            this.Teint = teint;
            this.Nom1 = "Zombie";
        }

        public override string ToString()
        {
            string chaine = "";
            chaine += Nom1 + "\n" + base.ToString() + " Degre de decomposition : " + Degre_decomposition + "\n" + " Teint : " + Teint + "\n";
            return chaine;
        }
    }
}
