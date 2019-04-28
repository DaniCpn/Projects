using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jeu_de_la_vie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            int level, percentage, generations, height;
            string source, destination;
            Grille grille, temp;

            Console.WriteLine(" JEU DE LA VIE ");
            Console.WriteLine();

            Console.WriteLine("Séléctionner un niveau (1 ou 2)");
            Console.Write("Niveau : ");
            level = Convert.ToInt32(Console.ReadLine());
            while (level != 1 && level != 2)
            {
                Console.WriteLine("Séléctionner un niveau (1 ou 2)");
                Console.Write("Niveau : ");
                level = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine("Selectionner pourcentage (0 à 100)");
            Console.Write("Pourcentage : ");
            percentage = Convert.ToInt32(Console.ReadLine());
            while (percentage >= 100 || percentage < 0)
            {
                Console.WriteLine("Selectionner pourcentage (0 à 100)");
                Console.Write("Pourcentage : ");
                percentage = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine("Séléctionner génération (nombre entier)");
            Console.Write("Générations : ");
            generations = Convert.ToInt32(Console.ReadLine());
            while (generations <= 0)
            {
                Console.WriteLine("Séléctionner génération (nombre entier)");
                Console.Write("Générations : ");
                generations = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            Console.WriteLine("Retrieve from file ? (SOURCE or No)");
            Console.Write("Retrieve (put source or No) : ");
            source = Console.ReadLine();

            if (source != "No")
            {
                grille = new Grille(source);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Select height (uint)");
                Console.Write("Height : ");
                height = Convert.ToInt32(Console.ReadLine());
                if (level == 1)
                    grille = new Grille(height, percentage);
                else
                    grille = new Grille(height, percentage, "V", 0, 1);
            }
            Console.Clear();

            temp = new Grille(grille.height);

            for (int i = 0; i < generations; i++)
            {
                Console.Clear();
                Console.WriteLine("Level : " + level + " | Generation : " + (i + 1));
                Console.WriteLine();
                grille.afficheGrille("");
                System.Threading.Thread.Sleep(400);
                grille.traversal(temp);
                grille.life();
            }

            Console.WriteLine();
            Console.WriteLine("Wanna save into a file ? (DESTINATION or No)");
            Console.Write("Destination : ");
            destination = Console.ReadLine();
            for (int i = 0; i < 3; i++)
            {
                Console.Write(".");
                System.Threading.Thread.Sleep(250);
            }
            grille.ecritureGrille(destination);

            Console.WriteLine(" GRID SAVED !");
            Console.WriteLine();
            Console.Write("< PRESS ENTER TO QUIT >");
            Console.Read();
        }
    }
}
