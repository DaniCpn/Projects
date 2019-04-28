using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombillenium
{
    class Vampire : Monstre
    {
        private float indice_luminosite;
        private string nom1;

        public Vampire(float indice_luminosite, Attraction affectation, int cagnotte, string fonction, int matricule, string nom, string prenom, TypeSexe sexe) : base(affectation, cagnotte, fonction, matricule, nom, prenom, sexe)
        {
            this.Indice_luminosite = indice_luminosite;
            this.Nom1 = "Vampire";
        }

        public float Indice_luminosite
        {
            get
            {
                return indice_luminosite;
            }

            set
            {
                indice_luminosite = value;
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

        public override string ToString()
        {
            string chaine = "";
            chaine += Nom1 + "\n" + base.ToString() + " Indice de luminosite : " + Indice_luminosite + "\n";
            return chaine;
        }
    }
}
