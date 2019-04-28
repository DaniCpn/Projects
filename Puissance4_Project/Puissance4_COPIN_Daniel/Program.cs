using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Puissance4_GUI;

namespace Puissance4_COPIN_Daniel
{
    class Program
    {
        [System.STAThreadAttribute()]
        static void Main(string[] args)
        {
            Puissance4();
            Console.ReadKey();
        }

        static void Puissance4()
        {

           
            // Etape 0 Initialisation du jeu 
            int[,] plateaudujeu = new int[6, 7];
            Fenetre gui = new Fenetre(plateaudujeu, 6, 7);
            Afficherlejeu(plateaudujeu);

            // Le  jeu démarre vraiment
            int noJoueur = 2;

            while (PartieGagnée(plateaudujeu, noJoueur) == false)
            {
                // A qui le tour ?
                noJoueur = AQuiLeTour(noJoueur);
                Console.WriteLine("C'est au tour du joueur :" + noJoueur);
                gui.changerMessage("C'est au tour du joueur :" + noJoueur);

                // Etape 2 Dans quelle colonne ?            
                Console.WriteLine("Quelle colonne voulez-vous sélectionner ?");
                gui.changerMessage("Quelle colonne voulez-vous sélectionner ?");
                int colonne = int.Parse(Console.ReadLine());

                // Sélectionner une colonne valide
                while (colonne < 1 || colonne > 7)
                {
                    Console.WriteLine("Veuillez entrer une colonne valide (entre 1 et 7)");
                    gui.changerMessage("Veuillez entrer une colonne valide (entre 1 et 7)");
                    int colonne2 = int.Parse(Console.ReadLine());
                    colonne = colonne2;
                }
              

                // Etape 3 Placer le jeton (attention si colonne déjà remplis)
                Placerlejeton(colonne, plateaudujeu, noJoueur);
                Afficherlejeu(plateaudujeu);
                gui.rafraichirGrille();


                // Partie Gagnée 
                if (PartieGagnée(plateaudujeu, noJoueur))
                {
                    Console.WriteLine("Le Joueur " + noJoueur + " a gagné");
                    gui.changerMessage("Le Joueur " + noJoueur + " a gagné");
                    
                }

                //Cas du match nul
                int l = 0;
                int c = 0;              
                if (plateaudujeu[l, c] != 0 && plateaudujeu[l, c + 1] != 0 && plateaudujeu[l, c + 2] != 0 && plateaudujeu[l, c + 3] != 0 && plateaudujeu[l, c + 4] != 0 && plateaudujeu[l, c + 5] != 0 && plateaudujeu[l, c + 6] != 0)
                {
                    Console.WriteLine("Match Nul");
                    gui.changerMessage("Match Nul");
                    break;
                }        
            }  
}
    

        static int[,] Afficherlejeu(int[,] matrice)
        {
            // Deux compteurs, ligne et colonne
            int l, c;

            for (l = 0; l < matrice.GetLength(0); l++)
            {
                for (c = 0; c < matrice.GetLength(1); c++)
                {
                    Console.Write(matrice[l, c] + " \t");
                }
                Console.WriteLine();
            }
            return matrice;
        }


        static void Placerlejeton(int colonne, int[,] matrice, int jeton)
        {
            
            colonne = colonne - 1;
            // index ligne = l
            int l = 5;

            // Si jamais la colonne est pleine
            int Premièreligne = 0;

            while (matrice[Premièreligne, colonne] != 0)             
            {
                Console.WriteLine("Cette colonne est déjà pleine veuillez en entrer une autre");
                int colonne2 = int.Parse(Console.ReadLine());
                colonne = colonne2 - 1;
            }

            while (matrice[l, colonne] != 0)
            {
                l = l - 1;                            
            }

            matrice[l, colonne] = jeton;
            

        }


        static int AQuiLeTour(int noJoueurActuel)
        {
            return (noJoueurActuel % 2) + 1;
        }


        static bool PartieGagnée(int[,] matrice, int jetonb)
        {
            // Vérification à l'horizontale
            // l= index ligne et c = index colonne
            int l, c;
            for (l = 0; l < matrice.GetLength(0); l++)
            {
                for (c = 0; c < matrice.GetLength(1) - 3 ; c++)
                {
                    if (matrice[l, c] == jetonb && matrice[l, c + 1] == jetonb && matrice[l, c + 2] == jetonb && matrice[l, c + 3] == jetonb)
                    {
                    
                        return true;
                    }
                }           
            }

            //Vérification à la verticale
            for (l = 0; l < matrice.GetLength(0) - 3; l++)
            {
                for (c = 0; c < matrice.GetLength(1); c++)
                {
                    if (matrice[l,c] == jetonb && matrice[l+1,c] == jetonb && matrice[l+2, c] == jetonb && matrice[l+3,c] == jetonb)
                    {
                        
                        return true;
                    }
                }        
            }

            //Vérification à la diagonale descendante
            for (l = 0; l < matrice.GetLength(0) - 3; l++)
            {
                for (c = 0; c < matrice.GetLength(1) - 3; c++)
                {
                    if (matrice[l, c] == jetonb && matrice[l + 1, c + 1] == jetonb && matrice[l + 2, c + 2] == jetonb && matrice[l + 3, c + 3] == jetonb)
                    {
                       
                        return true;
                    }
                }
            }

            //Vérification à la diagonale montante
            for (l = 0; l < matrice.GetLength(0) - 3 ; l++)
            {
                for (c = 2; c < matrice.GetLength(1) ; c++)
                {
                     if (matrice[l, c] == jetonb && matrice[l + 1, c - 1] == jetonb && matrice[l + 2, c - 2] == jetonb && matrice[l + 3, c - 3] == jetonb)
                    {
                        
                        return true;
                    }
                }
            }

            return false;                               
        }
           
    }
}
