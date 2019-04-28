using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombillenium
{
    class Fantome : Monstre
    {
        private string nom1;

        public Fantome(Attraction affectation, int cagnotte, string fonction, int matricule, string nom, string prenom, TypeSexe sexe) : base(affectation, cagnotte, fonction, matricule, nom, prenom, sexe)
        {
            this.Nom1 = "Fantome";
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
            chaine += Nom1 + "\n" + base.ToString();
            return chaine;
        }
    }
}
