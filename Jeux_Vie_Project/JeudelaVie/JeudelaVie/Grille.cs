using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeudelaVie
{
    class Grille
    {
        int taille;
        int pourcentage;
        Cellule[,] grille;
      
       

        public Grille(int taille, int pourcentage)
        {
            this.taille = taille;
            this.pourcentage = pourcentage;
            

            grille = new Cellule[taille, taille];
            for (int i = 0; i < taille; i++)
            {
                for (int j = 0; j < taille; j++)
                {
                    grille[i, j] = new Cellule(false, i, j);
                }
            }

            int Nb = taille * taille;
            int NbCasesARemplir = (pourcentage * Nb) / 100;

            for (int n = 0; n < NbCasesARemplir; n++)
            {
                bool test = false;

                while(test == false)
                {
              

                    Random random = new Random();
                    int l = random.Next(0, taille);
                    int c = random.Next(0, taille);
                    
                    if (grille[l, c].Etat == false)
                    {
                        grille[l, c].Etat = true;
                        test = true;
                    }
                    else
                    {
                        test = false;
                    }

                   
                }
                /*Random ligne = new Random();
                Random colonne = new Random();

                int l = ligne.Next(0, taille);
                int c = colonne.Next(0, taille);

                if (grille[l, c].Etat == true)
                {
                    n--;
                }

                grille[l, c].Etat = true;*/
            }
        }


       /* public Grille(int taille)
        {
            grille = new int[taille, taille];

           for(int i = 0; i <= taille; i++)
            {
                for(int j =0; j <= taille; j++)
                {
                    Console.Write(grille[i, j]);
                }
                Console.WriteLine();
            }
        }*/



        /*public Grille( int taille,  int pourcentage, int inconnu)
        {*/
            /* for (int i = 0; i < taille; i++)
             {
                 for (int j = 0; j < taille; j++)
                 {
                     grille[i, j] = 0;
                 }
             }*/

           /* grille = new Cellule[taille, taille];
            for (int i = 0; i < taille; i++)
            {
                for (int j = 0; j < taille; j++)
                {
                    grille[i, j] = new Cellule(false, i, j);
                }
            }

            int Nb = taille * taille;
            int NbCasesARemplir = (pourcentage * Nb) / 100;

            for (int n = 0; n < NbCasesARemplir; n++)
            {
                Random ligne = new Random();
                Random colonne = new Random();

                Random random = new Random();

                int l = random.Next(0, taille);
                int c = random.Next(0, taille);

                if (grille[l, c].Etat == true)
                {
                    n--;
                }

                grille[l, c].Etat = true;
            }
        }*/


        


        public void Affiche_Grille()           //Cette méthode permet de créer un tableau de cellule aléatoire suivant la taille et le pourcentage
        {
      
           for (int i = 0; i < taille; i++)
            {
                for (int j = 0; j < taille; j++)
                {
                    if(grille[i,j].Etat == true)
                    {
                        Console.Write("V" + "\t");
                    }
                    else
                    {
                        Console.Write("o" + "\t");
                    }             
                }
                Console.WriteLine();
            }
        }


        #region Voisin
        public Cellule VoisinNordEst(Cellule macase)
        {
            //Cellule C = grille[0, 0];
            Cellule C = new Cellule(true, 0, 0);

            taille = taille - 1;

            int i = macase.PPX;
            int j = macase.PPY;


            //Console.WriteLine("PPX : " + i);

            if (i > 0 && j < taille)
            {
                C = grille[i - 1, j + 1];
                // C = new Cellule(true, i - 1 , j + 1);                     
            }
            if ((i == taille) && (j == taille))
            {
                C = grille[taille, 0];
                //C = new Cellule(true, taille, 0);
            }
            if (i > 0 && j == taille)
            {
                C = grille[i - 1, 0];
                //C = new Cellule(true, i - 1, 0);
            }
            if (i == 0 && j < taille)
            {
                C = grille[taille, j + 1];
                // C = new Cellule(true, taille, j + 1);
            }
            if (i == 0 && j == taille)
            {
                C = grille[taille, 0];
                //C = new Cellule(true, taille, 0);                       
            }

            return C;
        }


        public Cellule VoisinNord(Cellule macase)      //Toutes les méthodes voisins permettent de trouver le "voisin" par rapport a la case traitée
        {
            //Cellule C = grille[0, 0];
           Cellule C = new Cellule(true, 0, 0);
            taille = taille - 1;

            int i = macase.PPX;
            int j = macase.PPY;

            if (i == 0)
                    {
               C = grille[taille, j];
              //  C = new Cellule(true, i + taille, j);                    
                    }
                    else
                    {
               C = grille[i - 1, j];
              // C = new Cellule(true, i - 1, j);                        
                    }
          
            return C;
        }
        





        



        public Cellule VoisinNordOuest(Cellule macase)
        {
            Cellule C = new Cellule(true, 0, 0);
           
            taille = taille - 1;

            int i = macase.PPX;
            int j = macase.PPY;

                    if (i > 0 && j >0)
                    {
                C = grille[i - 1, j - 1];
                       // C = new Cellule(true, i - 1, j - 1);
                    }
                    if(i == 0 && j == 0)
                    {
                C = grille[taille, taille];
                        //C = new Cellule(true, taille, taille);
                    }
                    if(i == 0 && j > 0)
                    {
                C = grille[taille, j - 1];
                       // C = new Cellule(true, taille, j - 1);
                    }
                    if(i > 0 && j == 0)
                    {
                C = grille[i - 1, taille];
                        //C = new Cellule(true, i - 1, taille);
                    }
                             
            return C;
        }




        public Cellule VoisinSud(Cellule macase)
        {
            Cellule C = new Cellule(true, 1, 1);

            taille = taille - 1;

            int i = macase.PPX;
            int j = macase.PPY;

                    if(i == taille)
                    {
                C = grille[0, j];
                      //  C = new Cellule(true, 0, j);
                    }
                    else
                    {
                C = grille[i + 1, j];
                       // C = new Cellule(true, i + 1, j);
                    }
          
            return C;
        }



        public Cellule VoisinSudEst(Cellule macase)
        {
            Cellule C = new Cellule(true, 1, 1);

            taille = taille - 1;

            int i = macase.PPX;
            int j = macase.PPY;

                    if(i < taille && j < taille)
                    {
                C = grille[i + 1, j + 1];
                        //C = new Cellule(true, i + 1, j + 1);
                    }
                    if(i == taille && j == taille)
                    {
                C = grille[0, 0];
                       // C = new Cellule(true, 0, 0);
                    }
                    if(i < taille && j == taille)
                    {
                C = grille[i + 1, 0];
                        //C = new Cellule(true, i + 1, 0);
                    }
                    if(i == taille && j < taille)
                    {
                C = grille[0, j + 1];
                        //C = new Cellule(true, 0, j + 1);
                    }
 
            return C;
        }




        public Cellule VoisinSudOuest(Cellule macase)
        {
            Cellule C = new Cellule(true, 1, 1);

            taille = taille - 1;

            int i = macase.PPX;
            int j = macase.PPY;

            if (j > 0)
                    {
                C = grille[i + 1, j - 1];
                       // C = new Cellule(true, i + 1, j - 1);
                    }
                    if (i == taille && j == 0)
                    {
                C = grille[0, taille];
                      //  C = new Cellule(true, 0, taille);
                    }
                    if (i < taille && j == 0)
                    {
                C = grille[i + 1, taille];
                       // C = new Cellule(true, i + 1, taille);
                    }
                    if (i == taille && j > 0)
                    {
                C = grille[0, j - 1];
                      //  C = new Cellule(true, 0, j - 1);
                    }
    
            return C;
        }


        public Cellule VoisinOuest(Cellule macase)
        {
            Cellule C = new Cellule(true, 1, 1);
            taille = taille - 1;

            int i = macase.PPX;
            int j = macase.PPY;

            if (j == 0)
                    {
                C = grille[i, taille];
                        //C = new Cellule(true, i, taille);
                    }
                    else
                    {
                C = grille[i, j - 1];
                       // C = new Cellule(true, i, j - 1);
                    }
        
            return C; 
        }


        public Cellule VoisinEst(Cellule macase)
        {
            Cellule C = new Cellule(true, 1, 1);

            taille = taille - 1;

            int i = macase.PPX;
            int j = macase.PPY;

            if (j == taille)
                    {
                C = grille[i, 0];
                       // C = new Cellule(true, i, 0);
                    }
                    else
                    {
                C = grille[i, j + 1];
                       // C = new Cellule(true, i, j + 1);
                    }
       
            return C;
        }
        #endregion

        public Cellule Jeuniveau1(Cellule macase)
        {
            int cellulesvoisines = 0;

            if(VoisinNord(macase).Etat == true)
            {
                cellulesvoisines = cellulesvoisines + 1;
            }
            if(VoisinEst(macase).Etat == true)
            {
                cellulesvoisines = cellulesvoisines + 1;
            }
            if(VoisinNordEst(macase).Etat == true)
            {
                cellulesvoisines = cellulesvoisines + 1;
            }
            if(VoisinNordOuest(macase).Etat == true)
            {
                cellulesvoisines = cellulesvoisines + 1;
            }
            if(VoisinOuest(macase).Etat == true)
            {
                cellulesvoisines = cellulesvoisines + 1;
            }
            if(VoisinSud(macase).Etat == true)
            {
                cellulesvoisines = cellulesvoisines + 1;
            }
            if(VoisinSudEst(macase).Etat == true)
            {
                cellulesvoisines = cellulesvoisines + 1;
            }
            if(VoisinSudOuest(macase).Etat == true)
            {
                cellulesvoisines = cellulesvoisines + 1;
            }


            if (cellulesvoisines == 2 || cellulesvoisines == 3)
            {
                macase.Etat = true;
            }
           /* else
            {
                macase.Etat = false;
            }*/
            if(cellulesvoisines >= 4 || cellulesvoisines <= 1)
            {
                macase.Etat = false;
            }
            if(macase.Etat = false && cellulesvoisines == 3)
            {
                macase.Etat = true;
            }
            return macase;
        }


     
        public void Clone(Grille grilleC)
        {
            taille = grilleC.taille;
            pourcentage = grilleC.pourcentage;
            grille = grilleC.grille;
        }
        
        /*public void Clone2(Grille grilleC)
        {
            for(int i =0; i< taille; i++)
            {
                for(int j =0; j < taille; j++)
                {
                    this.grille[i, j].Clone(grilleC.grille[i, j]);
                }
            }
        }*/
        
       
        #region VoisinBis
        /*public Cellule VoisinNord(Cellule macase)
        {
            return grille[macase.PPX, (macase.PPY - 1 + taille) % taille];
        }

        public Cellule VoisinNordEst(Cellule macase)
        {
            return grille[(macase.PPX + 1 + taille) % taille, (macase.PPY - 1 + taille) % taille];
        }

        public Cellule VoisinNordOuest(Cellule macase)
        {
            return grille[(macase.PPX - 1 + taille) % taille, (macase.PPY - 1 + taille) % taille];
        }

        public Cellule VoisinSud(Cellule macase)
        {
            return grille[macase.PPX, (macase.PPY + 1 + taille) % taille];
        }

        public Cellule VoisinSudEst(Cellule macase)
        {
            return grille[(macase.PPX + 1 + taille) % taille, (macase.PPY + 1 + taille) % taille];
        }

        public Cellule VoisinSudOuest(Cellule macase)
        {
            return grille[(macase.PPX - 1 + taille) % taille, (macase.PPY + 1 + taille) % taille];
        }

        public Cellule VoisinOuest(Cellule macase)
        {
            return grille[(macase.PPX - 1 + taille) % taille, macase.PPY];
        }

        public Cellule VoisinEst(Cellule macase)
        {
            return grille[(macase.PPX + 1 + taille) % taille, macase.PPY];
        }*/
        #endregion




        public Cellule[,] Matrice
        {
            get { return grille; }
            set { grille = value; }
        }

        public int Taille
        {
            get { return taille; }
            set { taille = value; }

        }

        public int Pourcentage
        {
            get { return pourcentage; }
            set { taille = value; }
        }
    }
}
