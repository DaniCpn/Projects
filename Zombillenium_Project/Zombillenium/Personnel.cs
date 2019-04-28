using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombillenium
{
    class Personnel
    {
        protected string fonction;
        protected int matricule;
        protected string nom;
        protected string prenom;
        protected TypeSexe sexe;


        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Fonction
        {
            get
            {
                return fonction;
            }

            set
            {
                fonction = value;
            }
        }

        public int Matricule
        {
            get
            {
                return matricule;
            }

            set
            {
                matricule = value;
            }
        }

        internal TypeSexe Sexe
        {
            get
            {
                return sexe;
            }

            set
            {
                sexe = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public Personnel(string fonction, int matricule, string nom, string prenom, TypeSexe sexe)
        {
            this.Fonction = fonction;
            this.Matricule = matricule;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Sexe = sexe;
        }

        public override string ToString()
        {
            string chaine = "";
            chaine += " Matricule : " + Matricule + " |" + " Nom : " + Nom + " |" + " Prenom : " + Prenom + " |" + " Sexe : " + Sexe + " |" + " Fonction : " + Fonction + " |";
            return chaine;
        }
  
    }
}
