using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinthe
{
    class Labyrinthe
    {

        const int V = 0; //V = Vide
        const int M = 1; //M = Mur
        const int D = 2; //D = Départ
        const int A = 3; //A = Arrivé
        const int P = 4; //P = Personnage

    
        public int[,] mtr ; // mtr = matrice
        int nbL; //nbL = nombreLignes
        int nbC; //nbC = nombreColonnes

        Position départ;
        Position arrivé;

        public Labyrinthe(string[] lignes, int nombreLignes, int nombreColonnes)
        {
            this.nbL = nombreLignes;
            this.nbC = nombreColonnes;
            mtr = new int[nombreLignes, nombreColonnes];

            // l correspond à un index, qu'on peut assismiler aux lignes
            for (int l = 0; l < nbL; l++)
            {
                string ligne = lignes[l];
               
                // int valeur = Inconnu;

                // c correspond à un index, qu'on peut assimiler aux colonnes
                for (int c = 0; c < nbC; c++)
                {
                    char cc = ligne[c];
                    if (cc == '*')
                    {
                        mtr[l, c] = 1;
                    }
                    if (cc == ' ')
                    {
                        mtr[l, c] = 0;
                    }
                    if (cc == 'a')
                    {
                        mtr[l, c] = 3;
                        arrivé = new Position(l, c);
                    }
                    if (cc == 'd')
                    {
                        mtr[l, c] = 2;
                        départ = new Position(l, c);
                    }
                    if (cc == '.')
                    {
                        mtr[l, c] = 4;
                    }
                    // matrice[lig, col] = valeur;                   
                }

            }


            /* for (int lig = 0; lig < nbLigne; lig++)
             {
                 string ligne = lignes[lig];
                 /*if (ligne.Length != nbColonne)
                 {
                     Console.WriteLine("Chaque ligne " + ligne + "du fichier doit avoir le même nombre de colonnes (de caractères)");
                     break;
                 }

                 int valeur = Inconnu;

             /*for (int col = 0; col < nbColonne; col++)
             {
                 char c = ligne[col];
                 if (c == '*')
                 {
                     valeur = 1;
                 }           
                 if (c == '-')
                 {
                     valeur = 0;
                 }                  
                 if (c == 'a')
                 {
                     valeur = 3;
                 }
                 if (c == 'd')
                 {
                     valeur = 2;
                 }
                 if (c == '.')
                 {
                     valeur = 4;
                 }
                 matrice[lig, col] = valeur;
             }

         }*/
             }           





        public Position DDepart
        {
            get { return départ; }
            //set { départ = value; }
        }

        public Position AArive
        {
            get { return arrivé; }
           // set { arrivé = value; }
        }

        public int[,] Matrice
        {
            get { return mtr; }
            set { mtr = value; }
        }



        public bool EstUnMur(Position ps)
        {
            bool resultat = false;
            if ((ps.Ligne == Labyrinthe.M) && (ps.Colonne == Labyrinthe.M))
            {
                resultat = true;               
            }
            return resultat;
        }



        public bool EstOccupee(Position ps)
        {
            bool resultat = false;
            if((ps.Ligne != Labyrinthe.V) || (ps.Ligne != Labyrinthe.A) || (ps.Colonne != Labyrinthe.V) || (ps.Colonne != Labyrinthe.A))
            {
                resultat = true;
            }
            return resultat;
        }



       public bool MarquerPassage(Position ps)
        {
            bool resultat = false;
            if((EstUnMur(ps) == false) || (EstOccupee(ps) == false))
            {
                resultat = true;
            }
            return resultat;
        }



        public string toStringg()
        {
            string labos = "";
            // i et j index pour parcourrir la "matrice"
            for(int i = 0; i < nbL; i++)
            {
                for(int j = 0; j < nbC; j++)
                {
                    if (mtr[i, j] == 0)
                    {
                        labos += " ";
                    }                  
                    if (mtr[i, j] == 1)
                    {
                        labos += "*";
                    }
                    if (mtr[i, j] == 2)
                    {
                        labos += "d";
                    }
                    if (mtr[i, j] == 3)
                    {
                        labos += "a";
                    }
                    if (mtr[i, j] == 4)
                    {
                        labos += ".";
                    }                 
                } labos += "\n";
            }

            return labos;
        }
    }
}
