using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labyrinthe
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string[] schema1 = { "*******", "d  *  a*", "** * ***", "   * ***", " *** ***", " *   **", "   ****" };
            Console.WriteLine("Vous voici dans un labyrinthe, votre but sera de retrouver la sortie ;)");
            Console.WriteLine();
            Console.WriteLine("Mais avant, précisons quelques petites règles. Vous devez toujours sélectionner une case qui soit horizontalement ou verticalement à côté de la case précedente, vous ne pouvez pas passer à travers les murs et vous ne pouvez pas revenir sur vos pas. A vous de jouer maintenant, et bonne chance!");
            Console.WriteLine();
            Console.WriteLine("A chaque tour, saisissez les coordonnées, ligne puis colonne, sachant que le point de départ est de coord 1.0. ");
            Console.WriteLine();


            Labyrinthe labyr = new Labyrinthe(schema1, 7, 7);
            Console.WriteLine(labyr.toStringg());

            Personnage personne = new Personnage(labyr);
            while(personne.EstArrive() == false)
            {
                personne.DeplacementSuivant();
                Console.WriteLine(labyr.toStringg());
            }
            Console.WriteLine("Félicitation, vous avez trouvé la sortie!");

            Console.ReadKey();
        }
    }
}
