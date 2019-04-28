using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinthe
{
    class Personnage
    {
        //p = Position qu'on initialisera comment la case de départ, pour pas ne pas l'initialiser
        private Position p;
        private Labyrinthe labyrinthe;

        public Personnage(Labyrinthe laby)
        {
            this.labyrinthe = laby;
            p = labyrinthe.DDepart;   
        }


        public bool EstArrive()
        {
            bool resultat = false;
            if(p.EstEgale(labyrinthe.AArive) == true)
            {
                resultat = true;
            }
            return resultat;
        }


        public void DeplacementSuivant()
        {
            int l = -1;
            int c = -1;

            while ((c < 0 || l < 0 || Math.Abs(p.Ligne - l) > 1 || Math.Abs(p.Colonne - c) > 1))
            {
                Console.WriteLine("Saisir les coordonnées, ligne puis colonne");
                //Console.WriteLine();
                l = int.Parse(Console.ReadLine());
                c = int.Parse(Console.ReadLine());

                /*if (labyrinthe.MarquerPassage(p)== false)
                {
                    Console.WriteLine("VOUS AVEZ TRICHE VOUS ETES PASSE A TRAVERS UN MUR");
                    Console.WriteLine();
                    //l = l - 1;
                   //c = c - 1;
                  
                }*/
               /* else
                {
                    p = new Position(l, c);
                    labyrinthe.MarquerPassage(p);
                    labyrinthe.mtr[p.Ligne, p.Colonne] = 4;

                }*/

                if(c >= 0 || l >= 0 || Math.Abs(p.Ligne - l) <= 1 || Math.Abs(p.Colonne - c) <= 1)
                {
                    Console.WriteLine("Vous ne pouvez pas effectuer ce mouvement, veuillez saisir de nouvelles coordonnées valides");
                    Console.WriteLine();
                }
            } 
            //else
       


            
            p = new Position(l, c);
            labyrinthe.MarquerPassage(p);
            labyrinthe.mtr[p.Ligne, p.Colonne] = 4;                       
        }
    }
}
