using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeudelaVie
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Sélectionnez une taille de grille");
             int taille = int.Parse(Console.ReadLine());
             Console.WriteLine("Sélectionnez un pourcentage de vie");
             int pourcentage = int.Parse(Console.ReadLine());
             Console.WriteLine("Combien de générations voulez-vous?");
             int generations = int.Parse(Console.ReadLine());
            



            //Grille jeu = new Grille(5, 25);
            //jeu.Affiche_Grille();

            // Cellule D = new Cellule(true, 2, 2);
            //Console.WriteLine(D.Etat);
            //Cellule NO = jeu.VoisinNord(D);
            //Console.WriteLine(NO.Etat);
            //Console.WriteLine(NO.toString());


             /*Grille jeu = new Grille(5, 25);
             Grille jeuCl = new Grille(5, 25);

             jeu.Clone(jeuCl);

             jeu.Affiche_Grille();
            Console.WriteLine();
            jeuCl.Affiche_Grille();*/

            /*Cellule D = new Cellule(true, 2, 2);
            Grille jeu = new Grille(5, 80);
            
            jeu.Affiche_Grille();
            Console.WriteLine();
            Cellule No = jeu.Jeuniveau1(D);
            jeu.Affiche_Grille();*/

/*            for (int i = 0; i < taille; i++)
            {
              for(int j = 0; j < taille; j++)
                {
                    //jeuCl.Jeuniveau1(jeuCl.Matrice[i, j]);
                    //Console.WriteLine("toto");
                    
                }
              
            }*/

            Console.ReadKey();

            
            
         
        }
    }
}
