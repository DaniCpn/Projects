using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombillenium
{
    class Spectacle : Attraction
    {
        private List<DateTime> horaire;
        private int nombre_place;
        private string nom_salle;
        private string nom;

        public int Nombre_place
        {
            get
            {
                return nombre_place;
            }

            set
            {
                nombre_place = value;
            }
        }

        public string Nom_salle
        {
            get
            {
                return nom_salle;
            }

            set
            {
                nom_salle = value;
            }
        }

        public string Nom1
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

        public Spectacle(List<DateTime> horaire, int nombre_place, string nom_salle, bool besoin_specifique, TimeSpan duree_maintenance, int identifiant, bool maintenance, string nature_maintenance, int nombre_min_monstre, string nom, bool ouvert, string type_de_besoin) : base(besoin_specifique, duree_maintenance, identifiant, maintenance, nature_maintenance, nombre_min_monstre, nom, ouvert, type_de_besoin)
        {
            this.Nombre_place = nombre_place;
            this.Nom_salle = nom_salle;
            this.Nom1 = "Spectable";
            //horaire = new List<DateTime>();
            this.horaire = new List<DateTime>();
        }

        override public string ToString()
        {
            string chaine = "";
            chaine += Nom1 + "\n" + base.ToString() + " Nombre de places : " + Nombre_place + "\n" + " Nom de la salle : " + Nom_salle + "\n";
            chaine += " Liste de horaires : ";

            /*for (int i = 0; i < horaire.Count(); i++)
            {
                chaine += horaire[i];
            }*/

            chaine += "\n";
            return chaine; 
        }
    }
}
