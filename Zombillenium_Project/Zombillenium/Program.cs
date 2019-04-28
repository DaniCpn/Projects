using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zombillenium
{
    class Program
    {

        static void Main(string[] args)
        {          

            Administration A = new Administration();


            //Liste d'horaires pour spectacle
            DateTime horaire1 = new DateTime(2018, 06, 21, 14, 30, 0);
            DateTime horaire2 = new DateTime(2018, 07, 10, 15, 15, 0);
            DateTime horaire3 = new DateTime(2018, 12, 30, 18, 50, 0);                     
            List<DateTime> horaire = new List<DateTime>();
            horaire.Add(horaire1);
            horaire.Add(horaire2);
            horaire.Add(horaire3);

           
            //Différents TimeSpan utilisé
            TimeSpan duration_maintenance = new TimeSpan(0, 0, 0);
            TimeSpan duration_attraction = new TimeSpan(0, 30, 0);
            TimeSpan duration_attraction2 = new TimeSpan(0, 45, 0);


            //ATTRACTIONS 
            DarkRide DR1 = new DarkRide(duration_attraction, false, false, duration_maintenance, 777, false, "/", 10, "DarkRide 1", false, "/");
            DarkRide DR2 = new DarkRide(duration_attraction2, true, false, duration_maintenance, 888, false, "/", 10, "DarkRide 2", false, "/");
            DarkRide DR3 = new DarkRide(duration_attraction, false, false, duration_maintenance, 999, false, "/", 1, "DarkRide 3", false, "/");

            RollerCoaster RC1 = new RollerCoaster(12, TypeCategorie.assise, (float)1.5, false, duration_maintenance, 555, false, "/", 45, "RollerCoaster de la Nuit", false, "/");
            RollerCoaster RC2 = new RollerCoaster(18, TypeCategorie.assise, 160, false, duration_maintenance, 795, false, "/", 5, "Le RC de l'enfer", true, "/");

            Spectacle SP1 = new Spectacle(horaire, 150, "SALABA", false, duration_maintenance, 444, false, "/", 8, "Spectacle 1", false, "/");
            Spectacle SP2 = new Spectacle(horaire, 200, "OKLAOMA", false, duration_maintenance, 458, false, "/", 10, "Le rodéo de l'enfer", true, "/");

            Boutique B1 = new Boutique(TypeBoutique.barbeAPapa, false, duration_maintenance, 236, false, "/", 3, "Barbe A Papa Candice", true, "/");
            Boutique B2 = new Boutique(TypeBoutique.nourriture, false, duration_maintenance, 785, false, "/", 7, "Nourriture des enfers", true, "/");
            Boutique B3 = new Boutique(TypeBoutique.souvenir, false, duration_maintenance, 128, false, "/", 4, "Souvenir Gadji", true, "/");

            Boutique BB = new Boutique(TypeBoutique.barbeAPapa, false, duration_maintenance, 666, false, "/", 1, "Barbe A Papa des Reclus", true, "/");


            //PERSONNEL
            List<string> pouvoirs = new List<string>();
            pouvoirs.Add("levitation");
            pouvoirs.Add("boule de feu");
            pouvoirs.Add("invisibilité");


            Sorcier S1 = new Sorcier(pouvoirs, Grade.giga, "stagiaire", 74563, "Acide", "Jean", TypeSexe.male);
            Sorcier S2 = new Sorcier(pouvoirs, Grade.strata, "comptable", 99154, "Malette", "Anne", TypeSexe.femelle);

            Monstre M1 = new Monstre(DR1, 500, "assistant", 45410, "Truffaut", "Pierre", TypeSexe.autre);
            A.Affectation_Monstre_A_Attraction(M1, DR1);
            Monstre M2 = new Monstre(DR3, 420, "chef de projet", 74420, "Boulot", "Didier", TypeSexe.male);
            A.Affectation_Monstre_A_Attraction(M2, DR3);

            Demon D1 = new Demon(5, DR3, 200, "junior", 88169, "Gudeau", "Patrick", TypeSexe.male);
            A.Affectation_Monstre_A_Attraction(D1, DR3);
            Demon D2 = new Demon(1, RC1, 200, "major", 56942, "Poteau", "Bono", TypeSexe.autre);
            A.Affectation_Monstre_A_Attraction(D2, RC1);

            LoupGarou L1 = new LoupGarou(99.9, RC1, 96, "chef", 20428, "Chou-fleur", "Victor", TypeSexe.male);
            A.Affectation_Monstre_A_Attraction(L1, RC1);
            LoupGarou L2 = new LoupGarou(42.3, SP1, 952, "caissier", 36369, "Plante", "Jean-josé", TypeSexe.autre);
            A.Affectation_Monstre_A_Attraction(L2, SP1);

            Zombie Z1 = new Zombie(8, CouleurZ.bleuatre, DR3, 60, "figurant", 47471, "Chaise", "Bernard", TypeSexe.male);
            A.Affectation_Monstre_A_Attraction(Z1, DR3);
            Zombie Z2 = new Zombie(4, CouleurZ.grisatre, null, 360, "caissier", 69658, "Junot", "Zakari", TypeSexe.autre);

            Vampire V1 = new Vampire((float)84.69, null, 600, "stagiaire", 96203, "Poireau", "Aurélien", TypeSexe.male);
            Vampire V2 = new Vampire((float)12.64, null, 60, "caissier", 66203, "Tableau", "Marcel", TypeSexe.male);

            Fantome F1 = new Fantome(null, 146, "chef de projet", 25111, "Poubelle", "Tanguy", TypeSexe.autre);
            Fantome F2 = new Fantome(DR2, 845, "comptable", 66666, "Satan", "Maurice", TypeSexe.male);
            A.Affectation_Monstre_A_Attraction(F2, DR2);


            //Ajouts
            A.Ajouter_Attraction(DR1);
            A.Ajouter_Attraction(DR2);
            A.Ajouter_Attraction(DR3);
            A.Ajouter_Attraction(RC1);
            A.Ajouter_Attraction(RC2);
            A.Ajouter_Attraction(SP1);
            A.Ajouter_Attraction(SP2);
            A.Ajouter_Attraction(B1);
            A.Ajouter_Attraction(B2);
            A.Ajouter_Attraction(B3);
            A.Ajouter_Attraction(BB);

            A.Ajouter_Personnel(S1);
            A.Ajouter_Personnel(S2);
            A.Ajouter_Personnel(M1);
            A.Ajouter_Personnel(M2);
            A.Ajouter_Personnel(D1);
            A.Ajouter_Personnel(D2);
            A.Ajouter_Personnel(L1);
            A.Ajouter_Personnel(L2);
            A.Ajouter_Personnel(Z1);
            A.Ajouter_Personnel(Z2);
            A.Ajouter_Personnel(V1);
            A.Ajouter_Personnel(V2);


            //Début            
            /*Console.WriteLine("BIENVENUE DANS CE PROGRAMME DEMO \n\n");
            Console.WriteLine("Avant de présenter chacunes des fonctions, affichons l'intégralité du Personnel (Listing CSV + autres données) \n\n");
            A.Afficher_Ensemble_Personnel();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Et l'ensemble des attractions \n");
            Console.WriteLine();
            A.Afficher_Ensemble_Attraction();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("POUR BIEN SUIVRE LE DEROULEMENT DU PROJET : \n\n");
            Console.WriteLine("Dans un fichier appeler RESULTATcsv, se situant à côté du .sln du projet, vous pourrez trouver : \n\n - Liste du Peronnel Initial \n - Liste des Attractions Initiales");
            Console.WriteLine(" - Liste du Personnel Final \n - Liste des Attractions Finales");
            A.Remplissage_CSV_Personnel("Liste_du_Personnel_Initial");
            A.Remplissage_CSV_Attraction("Liste_des_Attractions_Initiales");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("MAINTENANT NOUS ALLONS TESTER LES FONCTIONNALITES DU PROGRAMME : \n\n");
            Console.WriteLine("Il vous suffit d'appuyer sur Entrée pour continuer ");
            Console.ReadKey();
            Console.Clear();
            

            //Ajout d'une attraction
            Console.WriteLine("Fonction : AJOUT D'UNE ATTRACTION (RollerCoaster - RollerCoaster des Abysses)");
            Console.WriteLine("\n\n");
            RollerCoaster RC3 = new RollerCoaster(15, TypeCategorie.bobsleigh, (float)1.9, false, duration_maintenance, 412, false, "/", 45, "RollerCoaster des Abysses", false, "/");
            A.Ajouter_Attraction(RC3);
            A.Afficher_Ensemble_Attraction();
            Console.ReadKey();
            Console.Clear();


            //Ajout d'un personnel
            Console.WriteLine("Fonction : AJOUT D'UN PERSONNEL (Fantome - Sat Patou)");
            Console.WriteLine("\n\n");
            Fantome F3 = new Fantome(DR3, 845, "stagiaire", 85666, "Sat", "Patou", TypeSexe.autre);
            A.Ajouter_Personnel(F3);
            A.Afficher_Ensemble_Personnel();
            Console.ReadKey();
            Console.Clear();


            //Changement de fonction
            Console.WriteLine("Fonction : CHANGER DE FONCTION (Sat Patou(Fantome) - Passage de Stagiaire à Boss)");
            Console.WriteLine("\n\n");
            string nouvelle_fonction = "Boss"; 
            A.Changer_Fonction_Personnel(F3, nouvelle_fonction);
            A.Afficher_Ensemble_Fantome();
            Console.ReadKey();
            Console.Clear();


            //Affectation
            Console.WriteLine("Fonction : AFFECTATION MONSTRE A ATTRACTION (Sat Patou - Affectation au RollerCoaster de la Nuit)");
            Console.WriteLine("\n\n");
            A.Affectation_Monstre_A_Attraction(F3, RC1);
            A.Afficher_Ensemble_Fantome();
            Console.WriteLine("\n--------------------------------\n");
            Console.WriteLine("On vérifie que Sat Patou est présent dans la liste des montres du RollerCoaster de la Nuit : \n");
            Console.WriteLine("--------------------------------\n\n");
            A.Afficher_Ensemble_Des_RollerCoaster();
            Console.ReadKey();
            Console.Clear();


            //Maintenance
            Console.WriteLine("Fonction : FONCTION MISE EN MAINTENANCE (Mise en maintenance - RollerCoaster de la Nuit)");
            Console.WriteLine("\n\n");
            A.Fonction_Mise_En_Maintenance(RC1, "Réparation des projecteurs", 5, 30);
            A.Afficher_Ensemble_Des_RollerCoaster();
            Console.ReadKey();
            Console.Clear();


            //Grade Sorcier
            Console.WriteLine("Fonction : CHANGEMENT DE GRADE DU SORCIER (Jean - Passage de Giga à Novice)");
            Console.WriteLine("\n\n");
            A.Changer_Grade_Sorcier(S1, Grade.novice);
            A.Afficher_Ensemble_Sorcier();
            Console.ReadKey();
            Console.Clear();


            //Différents affichages des Attractions
            Console.WriteLine("Fonction : DIFFERENTS AFFICHAGES DES ATTRACTIONS SELON DES CRITERES");
            Console.WriteLine("\n\n");
            A.Afficher_Ensemble_Attractions_Par_Maintenance();
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Attraction_Par_Nom("Le RC de l'enfer");
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Des_Boutiques();
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Des_DarkRides();
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Des_RollerCoaster();
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Des_Spectacles();
            Console.ReadKey();
            Console.Clear();


            //Différents affichages du Personnel
            Console.WriteLine("Fonction : DIFFERENTS AFFICHAGES DU PERSONNEL SELON DES CRITERES (Partie 1)");
            Console.WriteLine("\n\n");
            A.Afficher_Ensemble_Fantome();
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_LoupGarou();
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Monstre();
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Sorcier();
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Fonction : DIFFERENTS AFFICHAGES DU PERSONNEL SELON DES CRITERES (Partie 2)");
            Console.WriteLine("\n\n");
            A.Afficher_Ensemble_Vampire();
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Zombie();
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Male();
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Femelle();
            Console.ReadKey();
            Console.Clear();


            //Différents tris sur le personnel
            Console.WriteLine("Fonction : DIFFERENTS TRIS SUR LE PERSONNEL");
            Console.WriteLine("\n\n");
            Console.WriteLine("TRI PAR NOM \n");
            A.Affichage_Personnel_Trié(Tri_Nom_Personnel);
            Console.WriteLine();
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("TRI PAR MATRICULE \n");
            A.Affichage_Personnel_Trié(Tri_Nom_Matricule);
            Console.WriteLine();
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("TRI PAR FORCE (Demon)\n");
            A.Affichage_Personnel_Trié(Tri_Force);
            Console.WriteLine();
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("TRI PAR DEGRE DE DECOMPOSITION (Zombie)\n");
            A.Affichage_Personnel_Trié(Tri_Degré_Décomposition);
            Console.WriteLine();
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("TRI PAR INDICE DE LUMINOSITE (Vampire)\n");
            A.Affichage_Personnel_Trié(Tri_Indice_Luminosité);
            Console.WriteLine();
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("TRI DES ZOMBIES EN FONCTION DE LEUR CAGNOTTE \n");
            A.Affichage_Personnel_Trié(Tri_Zombie_Selon_Cagnotte);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();


            //Différents tris sur les attractions
            Console.WriteLine("Fonction : DIFFERENTS TRIS SUR LES ATTRACTIONS");
            Console.WriteLine("\n\n");
            Console.WriteLine("TRI PAR NOM \n");
            A.Affichage_Attractions_Triées(Tri_Nom_Attraction);
            Console.WriteLine();
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("TRI PAR IDENTIFIANT \n");
            A.Affichage_Attractions_Triées(Tri_Nom_Identifiant);
            Console.WriteLine();
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("TRI PAR MAINTENANCE \n");
            A.Affichage_Attractions_Triées(Tri_Maintenance);
            Console.WriteLine();
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("TRI PAR AGE MINIMUM (RollerCoaster) \n");
            A.Affichage_Attractions_Triées(Tri_Age_Minimum);
            Console.WriteLine();
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("TRI PAR DUREE D'ATTRACTION (DarkRide) \n");
            A.Affichage_Attractions_Triées(Tri_Duree_DarkRide);
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();


            //Cagnotte < 50
            Console.WriteLine("Fonction : CAGNOTTE (Test cagnotte en dessous de 50)");
            Console.WriteLine("\n\n");
            A.Afficher_Ensemble_Demon();
            Console.WriteLine();
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("Augmentation de la cagnotte de 100 du Demon Patrick Gudeau : ");
            Console.WriteLine();
            Console.WriteLine("--------------------------------\n");
            A.Augmenter_Cagnotte(D1, 100, BB);
            A.Afficher_Ensemble_Demon();
            Console.WriteLine();
            Console.WriteLine("--------------------------------\n");            
            Console.WriteLine("Puis, diminution de sa cagnotte à moins de 50, ");
            A.Diminuer_Cagnotte(D1, 260, BB);
            Console.WriteLine("Le Demon Patrick Gudeau se retrouve affecter à une boutique barbe à papa.");
            Console.WriteLine();
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Demon();
            Console.WriteLine();
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("On vérifie que le Demon Patrick Gudeau est bien présent dans la liste des montres d'une Boutique Barbe à Papa : \n");
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Des_Boutiques();
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();


            //Cagnotte > 500
            Console.WriteLine("Fonction : CAGNOTTE (Test cagnotte au dessus de 500 pour un zombie)");
            Console.WriteLine("\n\n");
            A.Afficher_Ensemble_Zombie();
            Console.WriteLine();
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("Augmentation de la cagnotte du Zombie Bernard Chaise à plus de 500 : (il n'est alors plus affecté à une attraction)");
            Console.WriteLine();
            Console.WriteLine("--------------------------------\n");
            A.Augmenter_Cagnotte(Z1, 500, BB);
            A.Afficher_Ensemble_Zombie();
            Console.ReadKey();
            Console.Clear();
            

            //Fin
            Console.WriteLine("LA DEMONSTRATION EST A PRESENT TERMINEE \n\n");
            Console.WriteLine("Vous pouvez récupérer les 4 listes .csv, \n");
            Console.WriteLine("Appuyez sur Entrée pour quitter.");
            A.Remplissage_CSV_Personnel("Liste_du_Personnel_Final");
            A.Remplissage_CSV_Attraction("Liste_des_Attractions_Finales");*/


            //Test

            //Ajouter une attraction : VALIDE
            //A.Ajouter_Attraction();
            //A.Afficher_Ensemble_Attraction();

            //Ajout d'un personnel : VALIDE
            //A.Ajouter_Personnel();
            //A.Afficher_Ensemble_Personnel();

            //Changer de fonctions : VALIDE
            //A.Afficher_Ensemble_Vampire();
            //A.Changer_de_Fonction();
            //A.Afficher_Ensemble_Vampire();

            //Affectation : VALIDE 
            //A.Afficher_Ensemble_Vampire();
            //A.Afficher_Ensemble_Des_DarkRides();
            //A.Affectation();
            //A.Afficher_Ensemble_Vampire();
            //A.Afficher_Ensemble_Des_DarkRides();

            //Maintenance : VALIDE
            //A.Afficher_Ensemble_Des_DarkRides();
            //A.Maintenance();
            //A.Afficher_Ensemble_Des_DarkRides();

            //Test affichage attration : VALIDE
            //A.Affichage_Elements_Attractions();

            //Test affichage personnel : VA.IDE
            //A.Affichage_Elements_Personnel();

            //Test Cagnotte : VALIDE 
            //A.Afficher_Ensemble_Vampire();
            //A.Modification_Cagnotte(BB);
            //A.Afficher_Ensemble_Vampire();


            //DEMONSTRATION

            Console.WriteLine("BIENVENUE DANS CE PROGRAMME DEMO \n\n");
            /*Console.WriteLine("Avant de présenter chacunes des fonctions, affichons l'intégralité du Personnel (Listing CSV + autres données) \n\n");
            A.Afficher_Ensemble_Personnel();
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Et l'ensemble des attractions \n");
            Console.WriteLine();
            A.Afficher_Ensemble_Attraction();*/
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("POUR BIEN SUIVRE LE DEROULEMENT DU PROJET : \n\n");
            Console.WriteLine("Dans un fichier appeler RESULTATcsv, se situant à côté du .sln du projet, vous pourrez trouver : \n\n - Liste du Peronnel Initial \n - Liste des Attractions Initiales");
            Console.WriteLine(" - Liste du Personnel Final \n - Liste des Attractions Finales");
            A.Remplissage_CSV_Personnel("Liste_du_Personnel_Initial");
            A.Remplissage_CSV_Attraction("Liste_des_Attractions_Initiales");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("MAINTENANT NOUS ALLONS TESTER LES FONCTIONNALITES DU PROGRAMME : \n\n");
            Console.WriteLine("Il vous suffit d'appuyer sur Entrée pour continuer ");
            Console.ReadKey();
            Console.Clear();

            //Ajout Attraction
            /*Console.WriteLine("Fonction : AJOUT D'UNE ATTRACTION");
            Console.WriteLine("\n\n");
            A.Ajouter_Attraction();
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Attraction();
            Console.ReadKey();
            Console.Clear();

            //Ajout Personnel
            Console.WriteLine("Fonction : AJOUT D'UNE ATTRACTION");
            Console.WriteLine("\n\n");
            A.Ajouter_Personnel();
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Personnel();
            Console.ReadKey();
            Console.Clear();*/

            //Changer de fonction
            /*Console.WriteLine("Fonction : CHANGER DE FONCTION");
            Console.WriteLine("\n\n");
            A.Afficher_Ensemble_Demon();
            Console.WriteLine("--------------------------------\n");
            A.Changer_de_Fonction();
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Demon();
            Console.ReadKey();
            Console.Clear();*/

            //Affectation
            /*Console.WriteLine("Fonction : AFFECTATION");
            Console.WriteLine("\n\n");
            A.Afficher_Ensemble_Demon();
            Console.WriteLine("--------------------------------\n");
            A.Affectation();
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Demon();
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("On vérifie que ce démon fait bien parti de la liste de monstre dans l'attraction à laquelle il a été affecté : \n");
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Des_DarkRides();
            Console.ReadKey();
            Console.Clear();*/

            //Maintenance
            /*Console.WriteLine("Fonction : MISE EN MINATENANCE");
            Console.WriteLine("\n\n");
            A.Afficher_Ensemble_Des_RollerCoaster();
            Console.WriteLine("--------------------------------\n");
            A.Maintenance();
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Des_RollerCoaster();
            Console.ReadKey();
            Console.Clear();*/

            //Affichage selon critères des attractions
            /*Console.WriteLine("Fonction : AFFICHAGE DES ATTRACTIONS SELON UN CRITERE");
            Console.WriteLine("\n\n");
            A.Affichage_Elements_Attractions();
            Console.ReadKey();
            Console.Clear();*/

            //Affichage selon critères du personnel
            /*Console.WriteLine("Fonction : AFFICHAGE DU PERSONNEL SELON UN CRITERE");
            Console.WriteLine("\n\n");
            A.Affichage_Elements_Personnel();
            Console.ReadKey();
            Console.Clear();*/

            //Cagnotte
            /*Console.WriteLine("Fonction : CAGNOTTE");
            Console.WriteLine("\n\n");
            A.Afficher_Ensemble_Zombie();
            Console.WriteLine("--------------------------------\n");
            A.Modification_Cagnotte(BB);
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Zombie();
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Des_Boutiques();*/

            //Fin
            /*Console.WriteLine("LA DEMONSTRATION EST A PRESENT TERMINEE \n\n");
            Console.WriteLine("Vous pouvez récupérer les 4 listes .csv, \n");
            Console.WriteLine("Appuyez sur Entrée pour quitter.");
            A.Remplissage_CSV_Personnel("Liste_du_Personnel_Final");
            A.Remplissage_CSV_Attraction("Liste_des_Attractions_Finales");*/

            //MENU
            while (1 < 2)
            {
                try  // Permet de sélectionner l'action à effectuer (Menu)
                {
                    Console.WriteLine("---- Menu ----\n\n");
                    Console.WriteLine("Quelle action voulez-vous effectuer ?");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine(" 1 - Ajout d'une Attraction");
                    Console.WriteLine();
                    Console.WriteLine(" 2 - Ajout d'un Personnel");
                    Console.WriteLine();
                    Console.WriteLine(" 3 - Changement de Fonction");
                    Console.WriteLine();
                    Console.WriteLine(" 4 - Affectation à une Attraction");
                    Console.WriteLine();
                    Console.WriteLine(" 5 - Mise en Maintenance");
                    Console.WriteLine();
                    Console.WriteLine(" 6 - Affichage des Attractions selon un Critère");
                    Console.WriteLine();
                    Console.WriteLine(" 7 - Affichage du Personnel selon un Critère");
                    Console.WriteLine();
                    Console.WriteLine(" 8 - Affichage du Personnel selon un Tri");
                    Console.WriteLine();
                    Console.WriteLine(" 9 - Affichage des Attractions selon un Tri");
                    Console.WriteLine();
                    Console.WriteLine(" 10 - Remplir les fichiers CSV finaux");
                    Console.WriteLine();
                    Console.WriteLine(" 0 - Quitter le Programme");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Votre choix : ");

                    int choix = int.Parse(Console.ReadLine());

                    if (choix == 1) //Applique la bonne méthode selon le choix
                    {
                        Console.Clear();
                        Ajouter_Attraction_P(A);
                        Console.ReadKey();
                        Console.Clear();
                    }                       
                    if (choix == 2)
                    {
                        Console.Clear();
                        Ajouter_Personnel_P(A);
                        Console.ReadKey();
                        Console.Clear();
                    }                        
                    if (choix == 3)
                    {
                        Console.Clear();
                        Changement_de_Fonction_P(A);
                        Console.ReadKey();
                        Console.Clear();
                    }                     
                    if (choix == 4)
                    {
                        Console.Clear();
                        Affectation_P(A);
                        Console.ReadKey();
                        Console.Clear();
                    }                   
                    if (choix == 5)
                    {
                        Console.Clear();
                        Maintenance_P(A);
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (choix == 6)
                    {
                        Console.Clear();
                        Affichage_Elements_Attractions_P(A);
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (choix == 7)
                    {
                        Console.Clear();
                        Affichage_Elements_Personnel_P(A);
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (choix == 8)
                    {
                        Console.Clear();
                        Console.WriteLine("TRI PAR NOM \n");
                        A.Affichage_Personnel_Trié(Tri_Nom_Personnel);
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------\n");
                        Console.WriteLine("TRI PAR MATRICULE \n");
                        A.Affichage_Personnel_Trié(Tri_Matricule);
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------\n");
                        Console.WriteLine("TRI PAR FORCE (Demon)\n");
                        A.Affichage_Personnel_Trié(Tri_Force);
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------\n");
                        Console.WriteLine("TRI PAR DEGRE DE DECOMPOSITION (Zombie)\n");
                        A.Affichage_Personnel_Trié(Tri_Degré_Décomposition);
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------\n");
                        Console.WriteLine("TRI PAR INDICE DE LUMINOSITE (Vampire)\n");
                        A.Affichage_Personnel_Trié(Tri_Indice_Luminosité);
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------\n");
                        Console.WriteLine("TRI DES ZOMBIES EN FONCTION DE LEUR CAGNOTTE \n");
                        A.Affichage_Personnel_Trié(Tri_Zombie_Selon_Cagnotte);
                        Console.WriteLine();
                        Console.ReadKey();
                        Console.Clear();
                    }
                    if (choix == 9)
                    {
                        Console.Clear();
                        Console.WriteLine("TRI PAR NOM \n");
                        A.Affichage_Attractions_Triées(Tri_Nom_Attraction);
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------\n");
                        Console.WriteLine("TRI PAR IDENTIFIANT \n");
                        A.Affichage_Attractions_Triées(Tri_Nom_Identifiant);
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------\n");
                        Console.WriteLine("TRI PAR MAINTENANCE \n");
                        A.Affichage_Attractions_Triées(Tri_Maintenance);
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------\n");
                        Console.WriteLine("TRI PAR AGE MINIMUM (RollerCoaster) \n");
                        A.Affichage_Attractions_Triées(Tri_Age_Minimum);
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------\n");
                        Console.WriteLine("TRI PAR DUREE D'ATTRACTION (DarkRide) \n");
                        A.Affichage_Attractions_Triées(Tri_Duree_DarkRide);
                        Console.WriteLine();
                        Console.ReadKey();
                        Console.Clear();
                    }

                    if (choix == 0)
                    {
                        Environment.Exit(0);
                    } 
                    
                    if(choix == 10)
                    {
                        Console.Clear();
                        Console.WriteLine("LA DEMONSTRATION EST A PRESENT TERMINEE \n\n");
                        Console.WriteLine("Vous pouvez récupérer les 4 listes .csv, \n");
                        Console.WriteLine("Appuyez sur Entrée pour quitter.");
                        A.Remplissage_CSV_Personnel("Liste_du_Personnel_Final");
                        A.Remplissage_CSV_Attraction("Liste_des_Attractions_Finales");
                        Console.ReadKey();
                    }                    
                }
                catch (FormatException) //Permet de recommencer si l'utilisateur se trompe et sélectionne des lettres
                {
                    string[] arg = { "a", "a" };
                    Console.Clear();
                    Main(arg);
                }
            }
        }


        //Fonctions pour le menu

        static void Ajouter_Attraction_P(Administration A)
        {
            Console.WriteLine("Fonction : AJOUT D'UNE ATTRACTION");
            Console.WriteLine("\n\n");
            A.Ajouter_Attraction();
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Attraction();
        }

        static void Ajouter_Personnel_P(Administration A)
        {
            Console.WriteLine("Fonction : AJOUT D'UNE ATTRACTION");
            Console.WriteLine("\n\n");
            A.Ajouter_Personnel();
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Personnel();
        }

        static void Changement_de_Fonction_P(Administration A)
        {
            Console.WriteLine("Fonction : CHANGER DE FONCTION");
            Console.WriteLine("\n\n");
            A.Afficher_Ensemble_Demon();
            Console.WriteLine("--------------------------------\n");
            A.Changer_de_Fonction();
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Demon();
        }

        static void Affectation_P(Administration A)
        {
            Console.WriteLine("Fonction : AFFECTATION");
            Console.WriteLine("\n\n");
            A.Afficher_Ensemble_Demon();
            Console.WriteLine("--------------------------------\n");
            A.Affectation();
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Demon();
            Console.WriteLine("--------------------------------\n");
            Console.WriteLine("On vérifie que ce démon fait bien parti de la liste de monstre dans l'attraction à laquelle il a été affecté : \n");
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Des_DarkRides();
        }

        static void Maintenance_P(Administration A)
        {
            Console.WriteLine("Fonction : MISE EN MINATENANCE");
            Console.WriteLine("\n\n");
            A.Afficher_Ensemble_Des_RollerCoaster();
            Console.WriteLine("--------------------------------\n");
            A.Maintenance();
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Des_RollerCoaster();
        }

        static void Affichage_Elements_Attractions_P(Administration A)
        {
            Console.WriteLine("Fonction : AFFICHAGE DES ATTRACTIONS SELON UN CRITERE");
            Console.WriteLine("\n\n");
            A.Affichage_Elements_Attractions();
        }

        static void Affichage_Elements_Personnel_P(Administration A)
        {
            Console.WriteLine("Fonction : AFFICHAGE DU PERSONNEL SELON UN CRITERE");
            Console.WriteLine("\n\n");
            A.Affichage_Elements_Personnel();
        }

        static void Modification_Cagnotte_P(Administration A, Boutique barbe_a_papa)
        {
            Console.WriteLine("Fonction : CAGNOTTE");
            Console.WriteLine("\n\n");
            A.Afficher_Ensemble_Zombie();
            Console.WriteLine("--------------------------------\n");
            A.Modification_Cagnotte(barbe_a_papa);
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Zombie();
            Console.WriteLine("--------------------------------\n");
            A.Afficher_Ensemble_Des_Boutiques();
        }

        static void Tri_Sur_Le_Peronnel_P(Administration A)
        {
            Console.WriteLine("Fonction : TRI SUR LE PERONNEL SELON CRITERE");
            Console.WriteLine("1. Tri par le nom \n 2. Tri par le matricule \n 3. Tri des démons par la force \n 4. Tri des zombies par leur degré de décomposition \n 5. Tri des vampires par indice de luminosité \n 6. Tri des zombies selon leur cagnotte \n");
            int reponse = Convert.ToInt32(Console.ReadLine());

            if (reponse == 1)
            {
                Console.WriteLine("\n--------------------------------\n");
                A.Affichage_Personnel_Trié(Tri_Nom_Personnel);
            }

            if (reponse == 2)
            {
                Console.WriteLine("\n--------------------------------\n");
                A.Affichage_Personnel_Trié(Tri_Matricule);
            }

            if (reponse == 3)
            {
                Console.WriteLine("\n--------------------------------\n");
                A.Affichage_Personnel_Trié(Tri_Force);
            }

            if (reponse == 4)
            {
                Console.WriteLine("\n--------------------------------\n");
                A.Affichage_Personnel_Trié(Tri_Nom_Personnel);
            }

            if (reponse == 5)
            {
                Console.WriteLine("\n--------------------------------\n");
                A.Affichage_Personnel_Trié(Tri_Nom_Personnel);
            }

            if (reponse == 6)
            {
                Console.WriteLine("\n--------------------------------\n");
                A.Affichage_Personnel_Trié(Tri_Nom_Personnel);
            }
        }


        //TRI Personnel
        static void Tri_Nom_Personnel(List<Personnel> lst)
        {
            lst.Sort(delegate (Personnel X, Personnel Y)
            {
                return X.Nom.CompareTo(Y.Nom);
            });
            for (int i = 0; i < lst.Count(); i++)
            {
                Console.WriteLine(lst.ElementAt(i).Nom);
            }
        }

        static void Tri_Matricule(List<Personnel> lst)
        {
            lst.Sort(delegate (Personnel X, Personnel Y)
            {
                return X.Matricule.CompareTo(Y.Matricule);
            });
            for (int i = 0; i < lst.Count(); i++)
            {
                Console.WriteLine(lst.ElementAt(i).Matricule);
            }
        }

        static void Tri_Force(List<Personnel> lst)
        {
            List<Demon> liste_demon = new List<Demon>();
            foreach(Personnel pers in lst)
            {
                if (pers is Demon)
                {
                    liste_demon.Add(pers as Demon);
                }
                liste_demon.Sort(delegate (Demon D1, Demon D2) { return D1.Force.CompareTo(D2.Force); });
            }
            for (int i = 0; i < liste_demon.Count(); i++)
            {
                Console.WriteLine(liste_demon.ElementAt(i).Nom);
                Console.WriteLine(liste_demon.ElementAt(i).Force);
            }
        }

        static void Tri_Degré_Décomposition(List<Personnel> lst)
        {
            List<Zombie> liste_demon = new List<Zombie>();
            foreach (Personnel pers in lst)
            {
                if (pers is Zombie)
                {
                    liste_demon.Add(pers as Zombie);
                }
                liste_demon.Sort(delegate (Zombie Z1, Zombie Z2) { return Z1.Degre_decomposition.CompareTo(Z2.Degre_decomposition); });
            }
            for (int i = 0; i < liste_demon.Count(); i++)
            {
                Console.WriteLine(liste_demon.ElementAt(i).Nom);
                Console.WriteLine(liste_demon.ElementAt(i).Degre_decomposition);
            }
        }

        static void Tri_Indice_Luminosité(List<Personnel> lst)
        {
            List<Vampire> liste_demon = new List<Vampire>();
            foreach (Personnel pers in lst)
            {
                if (pers is Vampire)
                {
                    liste_demon.Add(pers as Vampire);
                }
                liste_demon.Sort(delegate (Vampire D1, Vampire D2) { return D1.Indice_luminosite.CompareTo(D2.Indice_luminosite); });
            }
            for (int i = 0; i < liste_demon.Count(); i++)
            {
                Console.WriteLine(liste_demon.ElementAt(i).Nom);
                Console.WriteLine(liste_demon.ElementAt(i).Indice_luminosite);
            }
        }

        static void Tri_Zombie_Selon_Cagnotte(List<Personnel> lst)
        {
            List<Zombie> liste_demon = new List<Zombie>();
            foreach (Personnel pers in lst)
            {
                if (pers is Zombie)
                {
                    liste_demon.Add(pers as Zombie);
                }
                liste_demon.Sort(delegate (Zombie Z1, Zombie Z2) { return Z1.Cagnotte.CompareTo(Z2.Cagnotte); });
            }
            for (int i = 0; i < liste_demon.Count(); i++)
            {
                Console.WriteLine(liste_demon.ElementAt(i).Nom);
                Console.WriteLine(liste_demon.ElementAt(i).Cagnotte);
            }
        }
       

        //TRI Attraction
        static void Tri_Nom_Attraction(List<Attraction> lst)
        {
            lst.Sort(delegate (Attraction X, Attraction Y)
            {
                return X.Nom.CompareTo(Y.Nom);
            });
            for (int i = 0; i < lst.Count(); i++)
            {
                Console.WriteLine(lst.ElementAt(i).Nom);
            }
        }

        static void Tri_Nom_Identifiant(List<Attraction> lst)
        {
            lst.Sort(delegate (Attraction X, Attraction Y)
            {
                return X.Identifiant.CompareTo(Y.Identifiant);
            });
            for (int i = 0; i < lst.Count(); i++)
            {
                Console.WriteLine(lst.ElementAt(i).Identifiant);
            }
        }

        static void Tri_Maintenance(List<Attraction> lst)
        {
            lst.Sort(delegate (Attraction X, Attraction Y)
            {
                return X.Maintenance.CompareTo(Y.Maintenance);
            });
            for (int i = 0; i < lst.Count(); i++)
            {
                Console.WriteLine(lst.ElementAt(i).Maintenance);
                Console.WriteLine(lst.ElementAt(i).Nature_maintenance);
            }
        }

        static void Tri_Age_Minimum(List<Attraction> lst)
        {
            List<RollerCoaster> liste_demon = new List<RollerCoaster>();
            foreach (Attraction att in lst)
            {
                if (att is RollerCoaster)
                {
                    liste_demon.Add(att as RollerCoaster);
                }
                liste_demon.Sort(delegate (RollerCoaster RC1, RollerCoaster RC2) { return RC1.Age_min.CompareTo(RC2.Age_min); });
            }
            for (int i = 0; i < liste_demon.Count(); i++)
            {
                Console.WriteLine(liste_demon.ElementAt(i).Nom);
                Console.WriteLine(liste_demon.ElementAt(i).Age_min);
            }
        }

        static void Tri_Duree_DarkRide(List<Attraction> lst)
        {
            List<DarkRide> liste_demon = new List<DarkRide>();
            foreach (Attraction att in lst)
            {
                if (att is DarkRide)
                {
                    liste_demon.Add(att as DarkRide);
                }
                liste_demon.Sort(delegate (DarkRide D1, DarkRide D2) { return D1.Duree.CompareTo(D2.Duree); });
            }
            for (int i = 0; i < liste_demon.Count(); i++)
            {
                Console.WriteLine(liste_demon.ElementAt(i).Nom);
                Console.WriteLine(liste_demon.ElementAt(i).Duree);
            }
        }

    }
}
