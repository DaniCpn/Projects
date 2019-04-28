using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinthe
{
    class Position
    {
        int ligne;
        int colonne;

        public Position(int ligne, int colonne)
        {
            this.ligne = ligne;
            this.colonne = colonne;
        }

        public int Ligne
        {
            get { return ligne; }
            set { ligne = value; }
        }

        public int Colonne
        {
            get { return colonne; }
            set { Colonne = value; }
        }


        public string toString()
        {
            return ("Votre personnagne est en abscisse" + ligne + " et en ordonné " + colonne);
        }

        /*public bool EstEgale(Position pos)
        {
            bool resulat = false;
            if((this.ligne == pos.ligne) && (this.colonne == pos.colonne))
            {
                resulat = true;
            }
            return resulat;
        }*/

        public bool EstEgale(Position ps)
        {
            bool resulat = false;
            if ((ps.ligne == this.ligne) && (ps.colonne == this.colonne))
            {
                resulat = true;
            }
            return resulat;
        }

       /* public bool EstEgale2(Position position)
        {
            bool resultat = false;
            if (position.ligne == this.ligne && position.colonne == this.colonne) resultat = true;
            return resultat;
        }*/
    }
}
