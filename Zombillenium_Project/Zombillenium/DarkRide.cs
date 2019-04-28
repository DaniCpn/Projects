using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombillenium
{
    class DarkRide : Attraction
    {
        private TimeSpan duree;
        private bool vehicule;
        private string nom;

        public TimeSpan Duree
        {
            get
            {
                return duree;
            }

            set
            {
                duree = value;
            }
        }

        public bool Vehicule
        {
            get
            {
                return vehicule;
            }

            set
            {
                vehicule = value;
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

        public DarkRide(TimeSpan duree, bool vehicule, bool besoin_specifique, TimeSpan duree_maintenance, int identifiant, bool maintenance, string nature_maintenance, int nombre_min_monstre, string nom, bool ouvert, string type_de_besoin) : base(besoin_specifique, duree_maintenance, identifiant, maintenance, nature_maintenance, nombre_min_monstre, nom, ouvert, type_de_besoin)
        {
            this.Duree = duree;
            this.Vehicule = vehicule;
            this.Nom1 = "DarkRide";
        }

        override public string ToString()
        {
            string chaine = "";
            chaine += Nom1 + "\n" + base.ToString() + " Duree : " + Duree + "\n" + " Vehicule : " + Vehicule + "\n";
            return chaine;
        }
    }
}
