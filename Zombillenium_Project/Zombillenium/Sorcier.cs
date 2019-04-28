using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombillenium
{
    class Sorcier : Personnel
    {
        private List<string> pouvoirs;
        private Grade tatouage;
        private string nom1;

        internal Grade Tatouage
        {
            get
            {
                return tatouage;
            }

            set
            {
                tatouage = value;
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

        public Sorcier(List<string> pouvoirs, Grade tatouage, string fonction, int matricule, string nom, string prenom, TypeSexe sexe) : base(fonction, matricule, nom, prenom, sexe)
        {
            this.pouvoirs = new List<string>();
            this.Tatouage = tatouage;
            this.Nom1 = "Sorcier";
        }


        public override string ToString()
        {
            string chaine = "";
            chaine += Nom1 + "\n" + base.ToString() + " Tatouage : " + Tatouage + "\n";

            chaine += " Pouvoirs : ";

            /*for (int i = 0; i < pouvoirs.Count(); i++) 
            {
                chaine += pouvoirs.ElementAt(i);
            }*/


            chaine += "\n";

            return chaine;
        }
    }
}
