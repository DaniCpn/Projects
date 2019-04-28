using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombillenium
{
    class Boutique : Attraction
    {
        private TypeBoutique type;
        private string nom;

        internal TypeBoutique Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
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

        public Boutique(TypeBoutique type, bool besoin_specifique, TimeSpan duree_maintenance, int identifiant, bool maintenance, string nature_maintenance, int nombre_min_monstre, string nom, bool ouvert, string type_de_besoin) : base(besoin_specifique, duree_maintenance, identifiant, maintenance, nature_maintenance, nombre_min_monstre, nom, ouvert, type_de_besoin)
        {
            this.Type = type;
            this.Nom1 = "Boutique";
        }

        override public string ToString()
        {
            string chaine = "";
            chaine += Nom1 + "\n" + base.ToString() + " Type de boutique : " + Type + "\n";
            return chaine;
        }
    }
}
