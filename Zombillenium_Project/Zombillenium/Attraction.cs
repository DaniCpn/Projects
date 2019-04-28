using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombillenium
{
    class Attraction
    {
        protected bool besoin_specifique;
        protected TimeSpan duree_maintenance;
        protected List<Monstre> equipe;
        protected int identifiant;
        protected bool maintenance;
        protected string nature_maintenance;
        protected int nombre_min_monstre;
        protected string nom;
        protected bool ouvert;
        protected string type_de_besoin;

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

        public int Identifiant
        {
            get
            {
                return identifiant;
            }

            set
            {
                identifiant = value;
            }
        }

        internal List<Monstre> Equipe
        {
            get
            {
                return equipe;
            }

            set
            {
                equipe = value;
            }
        }

        public TimeSpan Duree_maintenance
        {
            get
            {
                return duree_maintenance;
            }

            set
            {
                duree_maintenance = value;
            }
        }

        public bool Maintenance
        {
            get
            {
                return maintenance;
            }

            set
            {
                maintenance = value;
            }
        }

        public string Nature_maintenance
        {
            get
            {
                return nature_maintenance;
            }

            set
            {
                nature_maintenance = value;
            }
        }

        public bool Ouvert
        {
            get
            {
                return ouvert;
            }

            set
            {
                ouvert = value;
            }
        }

        public int Nombre_min_monstre
        {
            get
            {
                return nombre_min_monstre;
            }

            set
            {
                nombre_min_monstre = value;
            }
        }

        public string Type_de_besoin
        {
            get
            {
                return type_de_besoin;
            }

            set
            {
                type_de_besoin = value;
            }
        }

        public bool Besoin_specifique
        {
            get
            {
                return besoin_specifique;
            }

            set
            {
                besoin_specifique = value;
            }
        }

        public Attraction(bool besoin_specifique, TimeSpan duree_maintenance, int identifiant, bool maintenance, string nature_maintenance, int nombre_min_monstre, string nom, bool ouvert, string type_de_besoin)
        {
            this.Besoin_specifique = besoin_specifique;
            this.Duree_maintenance = duree_maintenance;
            this.Identifiant = identifiant;
            this.Maintenance = maintenance;
            this.Nature_maintenance = nature_maintenance;
            this.Nombre_min_monstre = nombre_min_monstre;
            this.Nom = nom;
            this.Ouvert = ouvert;
            this.Type_de_besoin = type_de_besoin;

            Equipe = new List<Monstre>();
        }

        override public string ToString()
        {
            string chaine = "";
            chaine += " Identifiant : " + Identifiant + " |" + " Nom de l'attraction : " + nom + " |" + " Besoin spécifique : " + Besoin_specifique + " |" + " Durée de maintenance : " + Duree_maintenance + " |" + " Maintenance : " + Maintenance + " |" + " Nature maintenance : " + Nature_maintenance + " |" + " Nombre minimum de monstres : " + Nombre_min_monstre + " |" + " Ouvert : " + Ouvert + " |" + " Type de besoin : " + Type_de_besoin + " |";

            chaine += "\n" + " Liste de Monstres : " + "\n";
            if(Equipe != null)
            {
                for (int i = 0; i < Equipe.Count(); i++)
                {
                    chaine += " - " + Equipe.ElementAt(i).Nom + "\n";
                }
            }
            else
            {
                chaine += " Pas de monstres \n";
            }

            return chaine;
        }

        public void Affecter_Monstre_Attraction(Monstre M)
        {
            Equipe.Add(M);
        }
    }
}
