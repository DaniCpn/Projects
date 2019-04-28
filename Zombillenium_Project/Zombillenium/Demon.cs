using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombillenium
{
    class Demon : Monstre
    {
        private int force;
        private string nom1;

        public int Force
        {
            get
            {
                return force;
            }

            set
            {
                force = value;
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

        public Demon(int force, Attraction affectation, int cagnotte, string fonction, int matricule, string nom, string prenom, TypeSexe sexe) : base(affectation, cagnotte, fonction, matricule, nom, prenom, sexe)
        {
            this.Force = force;
            this.Nom1 = "Demon";
        }

        public override string ToString()
        {
            string chaine = "";
            chaine += Nom1 + "\n" + base.ToString() + " Force : " + Force + "\n";
            return chaine;
        }
    }
}
