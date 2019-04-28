using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeudelaVie
{
    class Cellule
    {
        bool etat;
        int PX;
        int PY;
   

        public Cellule(bool etat, int PX, int PY)
        {
            this.etat = etat;
            this.PX = PX;
            this.PY = PY;
      
        }


        public int PPX
        {
            get { return PX; }
            set { PX = value; }
        }

        public int PPY
        {
            get { return PY; }
            set { PY = value; }
        }

        public bool Etat
        {
            get { return etat; }
            set { etat = value; }
        }


        public string toString()
        {
            string chaine = "abcisse " + PX + " ordonné " + PY + " et a pour état : " + etat;
            return chaine;
        }


        public void Clone(Cellule mycell)
        {
            PX = mycell.PX;
            PY = mycell.PY;
            etat = mycell.etat;
       
        }




    }
}
