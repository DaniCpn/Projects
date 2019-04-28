using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zombillenium
{
    class RollerCoaster : Attraction
    {
        private int age_min;
        private TypeCategorie categorie;
        private float taille_minimum;
        private string nom;

        public int Age_min
        {
            get
            {
                return age_min;
            }

            set
            {
                age_min = value;
            }
        }

        internal TypeCategorie Categorie
        {
            get
            {
                return categorie;
            }

            set
            {
                categorie = value;
            }
        }

        public float Taille_minimum
        {
            get
            {
                return taille_minimum;
            }

            set
            {
                taille_minimum = value;
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

        public RollerCoaster(int age_min, TypeCategorie categorie, float taille_minimum, bool besoin_specifique, TimeSpan duree_maintenance, int identifiant, bool maintenance, string nature_maintenance, int nombre_min_monstre, string nom, bool ouvert, string type_de_besoin) : base(besoin_specifique, duree_maintenance, identifiant, maintenance, nature_maintenance, nombre_min_monstre, nom, ouvert, type_de_besoin)
        {
            this.Age_min = age_min;
            this.Categorie = categorie;
            this.Taille_minimum = taille_minimum;
            this.Nom1 = "RollerCoaster";
        }

        override public string ToString()
        {
            string chaine = "";
            chaine += Nom1 + "\n" + base.ToString() + " Age minimum : " + Age_min + "\n" + " Catégorie : " + Categorie + "\n" + " Taille minimum : " + Taille_minimum + "\n";
            return chaine;
        }
    }
}
