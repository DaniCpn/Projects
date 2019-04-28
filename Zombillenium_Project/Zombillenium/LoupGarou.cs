using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombillenium
{
    class LoupGarou : Monstre
    {
        private double indice_cruaute;
        private string nom1;

        public LoupGarou(double indice_cruaute, Attraction affectation, int cagnotte, string fonction, int matricule, string nom, string prenom, TypeSexe sexe) : base(affectation, cagnotte, fonction, matricule, nom, prenom, sexe)
        {
            this.Indice_cruaute = indice_cruaute;
            this.Nom1 = "LoupGarou";
        }

        public double Indice_cruaute
        {
            get
            {
                return indice_cruaute;
            }

            set
            {
                indice_cruaute = value;
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
            chaine += Nom1 + "\n" + base.ToString() + " Indice de cruaute : " + Indice_cruaute + "\n";
            return chaine;
        }
    }
}
