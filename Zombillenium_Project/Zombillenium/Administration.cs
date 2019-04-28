using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Zombillenium
{
    class Administration
    {
        protected List<Attraction> attractions;
        protected List<Personnel> tout_le_personnel;

        //Delegate pour les tris
        public delegate void TriPersonnel(List<Personnel> pers);
        public delegate void TriAttractions(List<Attraction> att);

        public Administration()
        {
            attractions = new List<Attraction>();
            tout_le_personnel = new List<Personnel>();

            List<Personnel> liste1 = new List<Personnel>();
            liste1 = Lecture_Fichier("Listing.csv");

            List<Attraction> liste_At = new List<Attraction>();
            liste_At = Lecture_Fichier_Attraction("Listing.csv");

            for (int i = 0; i < liste1.Count(); i++)
            {
                tout_le_personnel.Add(liste1[i]);
            }

            for (int i = 0; i < liste_At.Count(); i++)
            {
                attractions.Add(liste_At[i]);
            }
        }


        //Fonction d'affichage de tris
        public void Affichage_Personnel_Trié(TriPersonnel tri)
        {
            tri(tout_le_personnel);
        }

        public void Affichage_Attractions_Triées(TriAttractions tri)
        {
            tri(attractions);
        }



        //Fonctions d'ajouts

        //Fonctions simples
        public void Ajouter_Attraction(Attraction A)
        {
            attractions.Add(A);
        }

        public void Ajouter_Personnel(Personnel P)
        {
            tout_le_personnel.Add(P);
        }

        //Fonctions complexes
        public void Ajouter_Attraction()
        {
            TimeSpan duration = new TimeSpan(0, 0, 0);

            Console.WriteLine("Quelle type d'attractions voulez vous ajouter ? (Boutique - Spectable - RollerCoaster - DarkRide)");
            {
                string reponse = Console.ReadLine();

                if (reponse == "Boutique")
                {

                    Console.WriteLine("Quelle type de Boutique ? (souvenir - barbeAPapa - nourriture)");
                    TypeBoutique type_boutique = (TypeBoutique)Enum.Parse(typeof(TypeBoutique), Console.ReadLine());

                    Console.WriteLine("Identifiant : (int)");
                    int identifiant = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Nombre de monstres minimum : (int)");
                    int nomre_monstres_min = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Nom de la Boutique : (string)");
                    string nom = Console.ReadLine();

                    Console.WriteLine("Besoin spécifique : (true - false)");
                    bool besoin_specifique = Convert.ToBoolean(Console.ReadLine());
                    if (besoin_specifique == true)
                    {
                        Console.WriteLine("Type de spécificité : (string)");
                        string type_de_besoin = Console.ReadLine();
                        Boutique B = new Boutique(type_boutique, besoin_specifique, duration, identifiant, false, "/", nomre_monstres_min, nom, false, type_de_besoin);
                        Console.WriteLine("Boutique ajoutée !");
                        Console.WriteLine();
                        Console.WriteLine(B.ToString());
                        attractions.Add(B);
                    }
                    else
                    {
                        Boutique B = new Boutique(type_boutique, besoin_specifique, duration, identifiant, false, "/", nomre_monstres_min, nom, false, "/");
                        Console.WriteLine("Boutique ajoutée !");
                        Console.WriteLine();
                        Console.WriteLine(B.ToString());
                        attractions.Add(B);
                    }
                }


                if (reponse == "Spectacle")
                {

                    Console.WriteLine("Nombre de place : (int)");
                    int nombre_de_places = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Nom de salle : (string)");
                    string nom_salle = Console.ReadLine();


                    Console.WriteLine("Identifiant : (int)");
                    int identifiant = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Nombre de monstres minimum : (int)");
                    int nomre_monstres_min = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Nom du RollerCoaster : (string)");
                    string nom = Console.ReadLine();

                    List<DateTime> horaires = new List<DateTime>();

                    Console.WriteLine("Combien d'horaires voulez vous donner pour ce spectacle ?");
                    int compteur = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < compteur; i++)
                    {
                        Console.WriteLine("Entrez les heures : (int)");
                        int heures = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Entrez les minutes : (int)");
                        int minutes = Convert.ToInt32(Console.ReadLine());
                        DateTime horaire = new DateTime(2018, 12, 30, heures, minutes, 0);
                        horaires.Add(horaire);
                    }


                    Console.WriteLine("Besoin spécifique : (true - false)");
                    bool besoin_specifique = Convert.ToBoolean(Console.ReadLine());
                    if (besoin_specifique == true)
                    {
                        Console.WriteLine("Type de spécificité : (string)");
                        string type_de_besoin = Console.ReadLine();
                        Spectacle S = new Spectacle(horaires, nombre_de_places, nom_salle, besoin_specifique, duration, identifiant, false, "/", nomre_monstres_min, nom, false, type_de_besoin);
                        Console.WriteLine("Spectacle ajoutée !");
                        Console.WriteLine();
                        Console.WriteLine(S.ToString());
                        attractions.Add(S);
                    }
                    else
                    {
                        Spectacle S = new Spectacle(horaires, nombre_de_places, nom_salle, besoin_specifique, duration, identifiant, false, "/", nomre_monstres_min, nom, false, "/");
                        Console.WriteLine("Spectacle ajoutée !");
                        Console.WriteLine();
                        Console.WriteLine(S.ToString());
                        attractions.Add(S);
                    }
                }



                if (reponse == "RollerCoaster")
                {

                    Console.WriteLine("Age minimum : (int)");
                    int age_minimum = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Taille minimum : (float)");
                    float taille_minimum = (float)Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Catégorie : (assise - inversee - bobsleigh)");
                    TypeCategorie type_categorie = (TypeCategorie)Enum.Parse(typeof(TypeCategorie), Console.ReadLine());

                    Console.WriteLine("Identifiant : (int)");
                    int identifiant = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Nombre de monstres minimum : (int)");
                    int nomre_monstres_min = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Nom du RollerCoaster : (string)");
                    string nom = Console.ReadLine();

                    Console.WriteLine("Besoin spécifique : (true - false)");
                    bool besoin_specifique = Convert.ToBoolean(Console.ReadLine());
                    if (besoin_specifique == true)
                    {
                        Console.WriteLine("Type de spécificité : (string)");
                        string type_de_besoin = Console.ReadLine();
                        RollerCoaster RC = new RollerCoaster(age_minimum, type_categorie, taille_minimum, besoin_specifique, duration, identifiant, false, "/", nomre_monstres_min, nom, false, type_de_besoin);
                        Console.WriteLine("RollerCoaster ajouté !");
                        Console.WriteLine();
                        Console.WriteLine(RC.ToString());
                        attractions.Add(RC);
                    }
                    else
                    {
                        RollerCoaster RC = new RollerCoaster(age_minimum, type_categorie, taille_minimum, besoin_specifique, duration, identifiant, false, "/", nomre_monstres_min, nom, false, "/");
                        Console.WriteLine("RollerCoaster ajouté !");
                        Console.WriteLine();
                        Console.WriteLine(RC.ToString());
                        attractions.Add(RC);
                    }
                }



                if (reponse == "DarkRide")
                {
                    TimeSpan duree = new TimeSpan(0, 0, 0);

                    Console.WriteLine("Véhicule : (true - false)");
                    bool vehicule = Convert.ToBoolean(Console.ReadLine());

                    Console.WriteLine("Catégorie : (assise - inversee - bobsleigh)");
                    TypeCategorie type_categorie = (TypeCategorie)Enum.Parse(typeof(TypeCategorie), Console.ReadLine());

                    Console.WriteLine("Identifiant : (int)");
                    int identifiant = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Nombre de monstres minimum : (int)");
                    int nomre_monstres_min = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Nom du DarkRide : (string)");
                    string nom = Console.ReadLine();

                    Console.WriteLine("Temps de l'attraction : ");
                    Console.WriteLine("Entrez les heures : (int)");
                    int heures = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Entrez les minutes : (int)");
                    int minutes = Convert.ToInt32(Console.ReadLine());

                    TimeSpan duree_attraction = new TimeSpan(heures, minutes, 00);

                    Console.WriteLine("Besoin spécifique : (true - false)");
                    bool besoin_specifique = Convert.ToBoolean(Console.ReadLine());
                    if (besoin_specifique == true)
                    {
                        Console.WriteLine("Type de spécificité : (string)");
                        string type_de_besoin = Console.ReadLine();
                        DarkRide DR = new DarkRide(duree_attraction, vehicule, besoin_specifique, duration, identifiant, false, "/", nomre_monstres_min, nom, false, type_de_besoin);
                        Console.WriteLine("DarkRide ajouté !");
                        Console.WriteLine();
                        Console.WriteLine(DR.ToString());
                        attractions.Add(DR);
                    }
                    else
                    {
                        DarkRide DR = new DarkRide(duree, vehicule, besoin_specifique, duration, identifiant, false, "/", nomre_monstres_min, nom, false, "/");
                        Console.WriteLine("DarkRide ajouté !");
                        Console.WriteLine();
                        Console.WriteLine(DR.ToString());
                        attractions.Add(DR);
                    }
                }
            }
        }

        public void Ajouter_Personnel()
        {
            TimeSpan duration = new TimeSpan(0, 0, 0);

            Console.WriteLine("Quelle type de personnel voulez vous ajouter ? (Sorcier - Monstre - Demon - Fantome - LoupGarou - Vampire - Zombie)");
            {
                string reponse = Console.ReadLine();

                if (reponse == "Sorcier")
                {
                    List<string> pouvoirs = new List<string>();

                    Console.WriteLine("Pouvoirs : (séparés par des -)");

                    /*string value = Console.ReadLine();
                    char delimiter = '-';
                    string[] sub = value.Split(delimiter);

                    for (int i = 0; i < sub.Length; i++)
                    {
                        pouvoirs.Add(sub[i]);
                    }*/

                    Console.WriteLine("Grade : (novice - mega - giga - strata)");
                    Grade grade = (Grade)Enum.Parse(typeof(Grade), Console.ReadLine());

                    Console.WriteLine("Fonction : (string)");
                    string fonction = Console.ReadLine();

                    Console.WriteLine("Matricule : (int)");
                    int matricule = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Nom : (string)");
                    string nom = Console.ReadLine();

                    Console.WriteLine("Prénom : (string)");
                    string prenom = Console.ReadLine();

                    Console.WriteLine("Type de sexe : male - femelle - autre");
                    TypeSexe sexe = (TypeSexe)Enum.Parse(typeof(TypeSexe), Console.ReadLine());

                    Sorcier S = new Sorcier(pouvoirs, grade, fonction, matricule, nom, prenom, sexe);
                    Console.WriteLine();
                    Console.WriteLine(S.ToString());
                    tout_le_personnel.Add(S);

                }




                TimeSpan duree2 = new TimeSpan(0, 0, 0);

                if (reponse == "Monstre")
                {

                    Console.WriteLine("Cagnotte : (int)");
                    int cagnotte = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Fonction : (string)");
                    string fonction = Console.ReadLine();

                    Console.WriteLine("Matricule : (int)");
                    int matricule = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Nom : (string)");
                    string nom = Console.ReadLine();

                    Console.WriteLine("Prénom : (string)");
                    string prenom = Console.ReadLine();

                    Console.WriteLine("Type de sexe : male - femelle - autre");
                    TypeSexe sexe = (TypeSexe)Enum.Parse(typeof(TypeSexe), Console.ReadLine());


                    Console.WriteLine("Voulez-vous l'affecter à une attraction ? (oui - non)");
                    string reponse2 = Console.ReadLine();
                    if (reponse2 == "oui")
                    {
                        Console.WriteLine("Pour l'affecter à une attraction par identifiant, entrez 1, sinon par le nom de l'attraction, entrez 2");
                        int reponse3 = Convert.ToInt32(Console.ReadLine());

                        if (reponse3 == 1)
                        {
                            Console.WriteLine("Identifiant : (int)");
                            int identifiant = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < attractions.Count(); i++)
                            {
                                if (attractions.ElementAt(i).Identifiant == identifiant)
                                {
                                    Monstre M = new Monstre(attractions.ElementAt(i), cagnotte, fonction, matricule, nom, prenom, sexe);
                                    Console.WriteLine();
                                    Console.WriteLine(M.ToString());
                                    tout_le_personnel.Add(M);
                                    attractions.ElementAt(i).Equipe.Add(M);
                                }
                            }
                        }

                        if (reponse3 == 2)
                        {
                            Console.WriteLine("Nom de l'attraction : (string)");
                            string nom_attraction = Console.ReadLine();
                            for (int i = 0; i < attractions.Count(); i++)
                            {
                                if (attractions.ElementAt(i).Nom == nom_attraction)
                                {
                                    Monstre M = new Monstre(attractions.ElementAt(i), cagnotte, fonction, matricule, nom, prenom, sexe);
                                    Console.WriteLine();
                                    Console.WriteLine(M.ToString());
                                    tout_le_personnel.Add(M);
                                    attractions.ElementAt(i).Equipe.Add(M);
                                }
                            }
                        }
                    }

                    if (reponse2 == "non")
                    {
                        Monstre M = new Monstre(null, cagnotte, fonction, matricule, nom, prenom, sexe);
                        Console.WriteLine();
                        Console.WriteLine(M.ToString());
                        tout_le_personnel.Add(M);
                    }
                }


                if (reponse == "Demon")
                {
                    Console.WriteLine("Force : (int)");
                    int force = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Cagnotte : (int)");
                    int cagnotte = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Fonction : (string)");
                    string fonction = Console.ReadLine();

                    Console.WriteLine("Matricule : (int)");
                    int matricule = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Nom : (string)");
                    string nom = Console.ReadLine();

                    Console.WriteLine("Prénom : (string)");
                    string prenom = Console.ReadLine();

                    Console.WriteLine("Type de sexe : male - femelle - autre");
                    TypeSexe sexe = (TypeSexe)Enum.Parse(typeof(TypeSexe), Console.ReadLine());


                    Console.WriteLine("Voulez-vous l'affecter à une attraction ? (oui - non)");
                    string reponse2 = Console.ReadLine();
                    if (reponse2 == "oui")
                    {
                        Console.WriteLine("Pour l'affecter à une attraction par identifiant, entrez 1, sinon par le nom de l'attraction, entrez 2");
                        int reponse3 = Convert.ToInt32(Console.ReadLine());

                        if (reponse3 == 1)
                        {
                            Console.WriteLine("Identifiant : (int)");
                            int identifiant = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < attractions.Count(); i++)
                            {
                                if (attractions.ElementAt(i).Identifiant == identifiant)
                                {
                                    Demon D = new Demon(force, attractions.ElementAt(i), cagnotte, fonction, matricule, nom, prenom, sexe);
                                    Console.WriteLine();
                                    Console.WriteLine(D.ToString());
                                    tout_le_personnel.Add(D);
                                    attractions.ElementAt(i).Equipe.Add(D);
                                }
                            }
                        }

                        if (reponse3 == 2)
                        {
                            Console.WriteLine("Nom de l'attraction : (string)");
                            string nom_attraction = Console.ReadLine();
                            for (int i = 0; i < attractions.Count(); i++)
                            {
                                if (attractions.ElementAt(i).Nom == nom_attraction)
                                {
                                    Demon D = new Demon(force, attractions.ElementAt(i), cagnotte, fonction, matricule, nom, prenom, sexe);
                                    Console.WriteLine();
                                    Console.WriteLine(D.ToString());
                                    tout_le_personnel.Add(D);
                                    attractions.ElementAt(i).Equipe.Add(D);
                                }
                            }
                        }
                    }

                    if (reponse2 == "non")
                    {
                        Demon D = new Demon(force, null, cagnotte, fonction, matricule, nom, prenom, sexe);
                        Console.WriteLine();
                        Console.WriteLine(D.ToString());
                        tout_le_personnel.Add(D);
                    }
                }


                if (reponse == "Fantome")
                {

                    Console.WriteLine("Cagnotte : (int)");
                    int cagnotte = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Fonction : (string)");
                    string fonction = Console.ReadLine();

                    Console.WriteLine("Matricule : (int)");
                    int matricule = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Nom : (string)");
                    string nom = Console.ReadLine();

                    Console.WriteLine("Prénom : (string)");
                    string prenom = Console.ReadLine();

                    Console.WriteLine("Type de sexe : male - femelle - autre");
                    TypeSexe sexe = (TypeSexe)Enum.Parse(typeof(TypeSexe), Console.ReadLine());


                    Console.WriteLine("Voulez-vous l'affecter à une attraction ? (oui - non)");
                    string reponse2 = Console.ReadLine();
                    if (reponse2 == "oui")
                    {
                        Console.WriteLine("Pour l'affecter à une attraction par identifiant, entrez 1, sinon par le nom de l'attraction, entrez 2");
                        int reponse3 = Convert.ToInt32(Console.ReadLine());

                        if (reponse3 == 1)
                        {
                            Console.WriteLine("Identifiant : (int)");
                            int identifiant = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < attractions.Count(); i++)
                            {
                                if (attractions.ElementAt(i).Identifiant == identifiant)
                                {
                                    Fantome F = new Fantome(attractions.ElementAt(i), cagnotte, fonction, matricule, nom, prenom, sexe);
                                    Console.WriteLine();
                                    Console.WriteLine(F.ToString());
                                    tout_le_personnel.Add(F);
                                    attractions.ElementAt(i).Equipe.Add(F);
                                }
                            }
                        }

                        if (reponse3 == 2)
                        {
                            Console.WriteLine("Nom de l'attraction : (string)");
                            string nom_attraction = Console.ReadLine();
                            for (int i = 0; i < attractions.Count(); i++)
                            {
                                if (attractions.ElementAt(i).Nom == nom_attraction)
                                {
                                    Fantome F = new Fantome(attractions.ElementAt(i), cagnotte, fonction, matricule, nom, prenom, sexe);
                                    Console.WriteLine();
                                    Console.WriteLine(F.ToString());
                                    tout_le_personnel.Add(F);
                                    attractions.ElementAt(i).Equipe.Add(F);
                                }
                            }
                        }
                    }

                    if (reponse2 == "non")
                    {
                        Fantome F = new Fantome(null, cagnotte, fonction, matricule, nom, prenom, sexe);
                        Console.WriteLine();
                        Console.WriteLine(F.ToString());
                        tout_le_personnel.Add(F);
                    }
                }



                if (reponse == "LoupGarou")
                {
                    Console.WriteLine("Indice de cruauté : (double)");
                    double cruaute = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Cagnotte : (int)");
                    int cagnotte = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Fonction : (string)");
                    string fonction = Console.ReadLine();

                    Console.WriteLine("Matricule : (int)");
                    int matricule = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Nom : (string)");
                    string nom = Console.ReadLine();

                    Console.WriteLine("Prénom : (string)");
                    string prenom = Console.ReadLine();

                    Console.WriteLine("Type de sexe : male - femelle - autre");
                    TypeSexe sexe = (TypeSexe)Enum.Parse(typeof(TypeSexe), Console.ReadLine());


                    Console.WriteLine("Voulez-vous l'affecter à une attraction ? (oui - non)");
                    string reponse2 = Console.ReadLine();
                    if (reponse2 == "oui")
                    {
                        Console.WriteLine("Pour l'affecter à une attraction par identifiant, entrez 1, sinon par le nom de l'attraction, entrez 2");
                        int reponse3 = Convert.ToInt32(Console.ReadLine());

                        if (reponse3 == 1)
                        {
                            Console.WriteLine("Identifiant : (int)");
                            int identifiant = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < attractions.Count(); i++)
                            {
                                if (attractions.ElementAt(i).Identifiant == identifiant)
                                {
                                    LoupGarou LG = new LoupGarou(cruaute, attractions.ElementAt(i), cagnotte, fonction, matricule, nom, prenom, sexe);
                                    Console.WriteLine();
                                    Console.WriteLine(LG.ToString());
                                    tout_le_personnel.Add(LG);
                                    attractions.ElementAt(i).Equipe.Add(LG);
                                }
                            }
                        }

                        if (reponse3 == 2)
                        {
                            Console.WriteLine("Nom de l'attraction : (string)");
                            string nom_attraction = Console.ReadLine();
                            for (int i = 0; i < attractions.Count(); i++)
                            {
                                if (attractions.ElementAt(i).Nom == nom_attraction)
                                {
                                    LoupGarou LG = new LoupGarou(cruaute, attractions.ElementAt(i), cagnotte, fonction, matricule, nom, prenom, sexe);
                                    Console.WriteLine();
                                    Console.WriteLine(LG.ToString());
                                    tout_le_personnel.Add(LG);
                                    attractions.ElementAt(i).Equipe.Add(LG);
                                }
                            }
                        }
                    }

                    if (reponse2 == "non")
                    {
                        LoupGarou LG = new LoupGarou(cruaute, null, cagnotte, fonction, matricule, nom, prenom, sexe);
                        Console.WriteLine();
                        Console.WriteLine(LG.ToString());
                        tout_le_personnel.Add(LG);
                    }
                }




                if (reponse == "Vampire")
                {
                    Console.WriteLine("Indice de luminosité : (float)");
                    float luminisote = (float)Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Cagnotte : (int)");
                    int cagnotte = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Fonction : (string)");
                    string fonction = Console.ReadLine();

                    Console.WriteLine("Matricule : (int)");
                    int matricule = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Nom : (string)");
                    string nom = Console.ReadLine();

                    Console.WriteLine("Prénom : (string)");
                    string prenom = Console.ReadLine();

                    Console.WriteLine("Type de sexe : male - femelle - autre");
                    TypeSexe sexe = (TypeSexe)Enum.Parse(typeof(TypeSexe), Console.ReadLine());


                    Console.WriteLine("Voulez-vous l'affecter à une attraction ? (oui - non)");
                    string reponse2 = Console.ReadLine();
                    if (reponse2 == "oui")
                    {
                        Console.WriteLine("Pour l'affecter à une attraction par identifiant, entrez 1, sinon par le nom de l'attraction, entrez 2");
                        int reponse3 = Convert.ToInt32(Console.ReadLine());

                        if (reponse3 == 1)
                        {
                            Console.WriteLine("Identifiant : (int)");
                            int identifiant = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < attractions.Count(); i++)
                            {
                                if (attractions.ElementAt(i).Identifiant == identifiant)
                                {
                                    Vampire V = new Vampire(luminisote, attractions.ElementAt(i), cagnotte, fonction, matricule, nom, prenom, sexe);
                                    Console.WriteLine();
                                    Console.WriteLine(V.ToString());
                                    tout_le_personnel.Add(V);
                                    attractions.ElementAt(i).Equipe.Add(V);
                                }
                            }
                        }

                        if (reponse3 == 2)
                        {
                            Console.WriteLine("Nom de l'attraction : (string)");
                            string nom_attraction = Console.ReadLine();
                            for (int i = 0; i < attractions.Count(); i++)
                            {
                                if (attractions.ElementAt(i).Nom == nom_attraction)
                                {
                                    Vampire V = new Vampire(luminisote, attractions.ElementAt(i), cagnotte, fonction, matricule, nom, prenom, sexe);
                                    Console.WriteLine();
                                    Console.WriteLine(V.ToString());
                                    tout_le_personnel.Add(V);
                                    attractions.ElementAt(i).Equipe.Add(V);
                                }
                            }
                        }
                    }

                    if (reponse2 == "non")
                    {
                        Vampire V = new Vampire(luminisote, null, cagnotte, fonction, matricule, nom, prenom, sexe);
                        Console.WriteLine();
                        Console.WriteLine(V.ToString());
                        tout_le_personnel.Add(V);
                    }
                }


                if (reponse == "Zombie")
                {
                    Console.WriteLine("Degré de décomposition : (int)");
                    int decomposition = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Type de sexe : male - femelle - autre");
                    CouleurZ teint = (CouleurZ)Enum.Parse(typeof(CouleurZ), Console.ReadLine());

                    Console.WriteLine("Cagnotte : (int)");
                    int cagnotte = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Fonction : (string)");
                    string fonction = Console.ReadLine();

                    Console.WriteLine("Matricule : (int)");
                    int matricule = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Nom : (string)");
                    string nom = Console.ReadLine();

                    Console.WriteLine("Prénom : (string)");
                    string prenom = Console.ReadLine();

                    Console.WriteLine("Type de sexe : male - femelle - autre");
                    TypeSexe sexe = (TypeSexe)Enum.Parse(typeof(TypeSexe), Console.ReadLine());


                    Console.WriteLine("Voulez-vous l'affecter à une attraction ? (oui - non)");
                    string reponse2 = Console.ReadLine();
                    if (reponse2 == "oui")
                    {
                        Console.WriteLine("Pour l'affecter à une attraction par identifiant, entrez 1, sinon par le nom de l'attraction, entrez 2");
                        int reponse3 = Convert.ToInt32(Console.ReadLine());

                        if (reponse3 == 1)
                        {
                            Console.WriteLine("Identifiant : (int)");
                            int identifiant = Convert.ToInt32(Console.ReadLine());
                            for (int i = 0; i < attractions.Count(); i++)
                            {
                                if (attractions.ElementAt(i).Identifiant == identifiant)
                                {
                                    Zombie Z = new Zombie(decomposition, teint, attractions.ElementAt(i), cagnotte, fonction, matricule, nom, prenom, sexe);
                                    Console.WriteLine();
                                    Console.WriteLine(Z.ToString());
                                    tout_le_personnel.Add(Z);
                                    attractions.ElementAt(i).Equipe.Add(Z);
                                }
                            }
                        }

                        if (reponse3 == 2)
                        {
                            Console.WriteLine("Nom de l'attraction : (string)");
                            string nom_attraction = Console.ReadLine();
                            for (int i = 0; i < attractions.Count(); i++)
                            {
                                if (attractions.ElementAt(i).Nom == nom_attraction)
                                {
                                    Zombie Z = new Zombie(decomposition, teint, attractions.ElementAt(i), cagnotte, fonction, matricule, nom, prenom, sexe);
                                    Console.WriteLine();
                                    Console.WriteLine(Z.ToString());
                                    tout_le_personnel.Add(Z);
                                    attractions.ElementAt(i).Equipe.Add(Z);
                                }
                            }
                        }
                    }

                    if (reponse2 == "non")
                    {
                        Zombie Z = new Zombie(decomposition, teint, null, cagnotte, fonction, matricule, nom, prenom, sexe);
                        Console.WriteLine();
                        Console.WriteLine(Z.ToString());
                        tout_le_personnel.Add(Z);
                    }
                }
            }
        }






        //Fonctions d'évolution

        //Fonctions simples
        public void Changer_Fonction_Personnel(Personnel P, string nouvelle_fonction)
        {
            P.Fonction = nouvelle_fonction;
        }

        public void Affectation_Monstre_A_Attraction(Monstre monstre, Attraction attraction)
        {
            monstre.Affectation = attraction;
            attraction.Equipe.Add(monstre);
        }

        public void Fonction_Mise_En_Maintenance(Attraction A, string nature_maintenance, int heures, int minutes)
        {
            A.Maintenance = true;
            A.Nature_maintenance = nature_maintenance;

            TimeSpan duree_maintenance = new TimeSpan(heures, minutes, 00);

            A.Duree_maintenance = duree_maintenance;

            for (int j = 0; j < A.Equipe.Count(); j++)
            {
                A.Equipe[j].Affectation = null;
            }

            A.Equipe = null;

            A.Ouvert = false;
        }

        public void Changer_Grade_Sorcier(Sorcier S, Grade nouveau_grade)
        {
            S.Tatouage = nouveau_grade;
        }

        //Fonctions complexes

        public void Changer_de_Fonction()
        {
            Console.WriteLine("Entrez le nom de la personne dont vous voulez changer la fonction : (string)");
            string nom_personne = Console.ReadLine();

            for (int i = 0; i < tout_le_personnel.Count(); i++)
            {
                if (tout_le_personnel.ElementAt(i).Nom == nom_personne)
                {
                    Personnel P = tout_le_personnel.ElementAt(i);
                    Console.WriteLine("Quelle nouvelle fonction voulez vous lui attribuer ? (string)");
                    string nouvelle_fonction = Console.ReadLine();

                    P.Fonction = nouvelle_fonction;
                }
            }
        }

        public void Affectation()
        {
            Console.WriteLine("Entrez le nom de la personne que vous voulez affecter à une attraction : (string)");
            string nom_personne = Console.ReadLine();

            for (int i = 0; i < tout_le_personnel.Count(); i++)
            {
                if (tout_le_personnel.ElementAt(i).Nom == nom_personne)
                {

                    Console.WriteLine("Pour l'affecter à une attraction par identifiant, entrez 1, sinon par le nom de l'attraction, entrez 2");
                    int reponse3 = Convert.ToInt32(Console.ReadLine());

                    if (reponse3 == 1)
                    {
                        Console.WriteLine("Identifiant : (int)");
                        int identifiant = Convert.ToInt32(Console.ReadLine());

                        for (int j = 0; j < attractions.Count(); j++)
                        {
                            if (attractions.ElementAt(j).Identifiant == identifiant)
                            {
                                (tout_le_personnel.ElementAt(i) as Monstre).Affectation = attractions.ElementAt(j);
                                attractions.ElementAt(j).Equipe.Add((tout_le_personnel.ElementAt(i) as Monstre));
                            }
                        }
                    }

                    if (reponse3 == 2)
                    {
                        Console.WriteLine("Nom de l'attraction : (string)");
                        string nom_attraction = Console.ReadLine();

                        for (int j = 0; j < attractions.Count(); j++)
                        {
                            if (attractions.ElementAt(j).Nom == nom_attraction)
                            {
                                (tout_le_personnel.ElementAt(i) as Monstre).Affectation = attractions.ElementAt(j);
                                attractions.ElementAt(j).Equipe.Add((tout_le_personnel.ElementAt(i) as Monstre));
                            }
                        }
                    }
                }
            }
        }

        public void Maintenance()
        {
            Console.WriteLine("Veuillez entrer l'identifiant de l'attraction que vous voulez mettre en maintenance");
            int identifiant = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < attractions.Count(); i++)
            {
                if (attractions.ElementAt(i).Identifiant == identifiant)
                {
                    attractions.ElementAt(i).Maintenance = true;
                    Console.WriteLine("Type de maintenance : (string)");
                    string nature_maintenance = Console.ReadLine();
                    attractions.ElementAt(i).Nature_maintenance = nature_maintenance;

                    Console.WriteLine("Durée de la maintenance : ");
                    Console.WriteLine("Entrez les heures : (int)");
                    int heures = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Entrez les minutes : (int)");
                    int minutes = Convert.ToInt32(Console.ReadLine());

                    TimeSpan duree_maintenance = new TimeSpan(heures, minutes, 00);

                    attractions.ElementAt(i).Duree_maintenance = duree_maintenance;

                    for (int j = 0; j < attractions.ElementAt(i).Equipe.Count(); j++)
                    {
                        attractions.ElementAt(i).Equipe[j].Affectation = null;
                    }

                    attractions.ElementAt(i).Equipe = null;

                    attractions.ElementAt(i).Ouvert = false;


                }
            }
        }







        //Fonctions d'affichages selon des critères sur les attractions

        //Fonctions simples
        public void Afficher_Ensemble_Attractions_Par_Maintenance()
        {
            Console.WriteLine("ENSEMBLE DES ATTRACTIONS EN MAINTENANCE : \n");
            for (int i = 0; i < attractions.Count(); i++)
            {
                if (attractions.ElementAt(i).Maintenance == true)
                {
                    Console.WriteLine(attractions.ElementAt(i).ToString());
                }
            }
        }

        public void Afficher_Attraction_Par_Nom(string nom_attraction)
        {
            Console.WriteLine("ATTRACTION PAR SON NOM : \n");
            for (int i = 0; i < attractions.Count(); i++)
            {
                if (attractions.ElementAt(i).Nom == nom_attraction)
                {
                    Console.WriteLine(attractions.ElementAt(i).ToString());
                }
            }
        }

        public void Afficher_Ensemble_Des_Boutiques()
        {
            Console.WriteLine("ENSEMBLE DES BOUTIQUES : \n");

            for (int i = 0; i < attractions.Count(); i++)
            {
                if (attractions.ElementAt(i) is Boutique)
                {
                    Console.WriteLine(attractions.ElementAt(i).ToString());
                }
            }
        }

        public void Afficher_Ensemble_Des_Spectacles()
        {
            Console.WriteLine("ENSEMBLE DES SPECTACLES : \n");

            for (int i = 0; i < attractions.Count(); i++)
            {
                if (attractions.ElementAt(i) is Spectacle)
                {
                    Console.WriteLine(attractions.ElementAt(i).ToString());
                }
            }
        }

        public void Afficher_Ensemble_Des_RollerCoaster()
        {
            Console.WriteLine("ENSEMBLE DES ROLLERCOASTERS : \n");

            for (int i = 0; i < attractions.Count(); i++)
            {
                if (attractions.ElementAt(i) is RollerCoaster)
                {
                    Console.WriteLine(attractions.ElementAt(i).ToString());
                }
            }
        }

        public void Afficher_Ensemble_Des_DarkRides()
        {
            Console.WriteLine("ENSEMBLE DES DARKRIDES : \n");

            for (int i = 0; i < attractions.Count(); i++)
            {
                if (attractions.ElementAt(i) is DarkRide)
                {
                    Console.WriteLine(attractions.ElementAt(i).ToString());
                }
            }
        }

        public void Afficher_Ensemble_Attraction()
        {
            Console.WriteLine("ENSEMBLE DES ATTRACTIONS : \n");

            foreach (Attraction attraction in attractions)
            {
                Console.WriteLine(attraction.ToString());
            }
        }


        //Fonction complexe

        public void Affichage_Elements_Attractions()
        {
            Console.WriteLine("Que voulez vous sortir comme attractions suivant quel critère ? (maintenance - type - nom)");
            string reponse = Console.ReadLine();

            if (reponse == "maintenance")
            {
                Console.WriteLine("\n--------------------------------\n");
                Afficher_Ensemble_Attractions_Par_Maintenance();
            }

            if (reponse == "type")
            {
                Console.WriteLine("Quel type ? (Boutique - Spectacle - RollerCoaster - DarkRide)");
                string reponse2 = Console.ReadLine();
                if (reponse2 == "Boutique")
                {
                    Console.WriteLine("\n--------------------------------\n");
                    Afficher_Ensemble_Des_Boutiques();
                }
                if (reponse2 == "Spectacle")
                {
                    Console.WriteLine("\n--------------------------------\n");
                    Afficher_Ensemble_Des_Spectacles();
                }
                if (reponse2 == "RollerCoaster")
                {
                    Console.WriteLine("\n--------------------------------\n");
                    Afficher_Ensemble_Des_RollerCoaster();
                }
                if (reponse2 == "DarkRide")
                {
                    Console.WriteLine("\n--------------------------------\n");
                    Afficher_Ensemble_Des_DarkRides();
                }
            }

            if (reponse == "nom")
            {
                Console.WriteLine("Veillez entrer le nom de l'attraction : ");
                string reponse3 = Console.ReadLine();

                Console.WriteLine("\n--------------------------------\n");
                Afficher_Attraction_Par_Nom(reponse3);
            }



        }





        //Fonctions d'affichages selon des critères sur le peronnel

        //Fonctions simples
        public void Afficher_Ensemble_Personnel()
        {
            Console.WriteLine("ENSEMBLE DU PERSONNEL : \n");

            foreach (Personnel personnel in tout_le_personnel)
            {
                Console.WriteLine(personnel.ToString());
            }
        }

        public void Afficher_Ensemble_Sorcier()
        {
            Console.WriteLine("ENSEMBLE DES SORCIERS : \n");

            for (int i = 0; i < tout_le_personnel.Count(); i++)
            {
                if (tout_le_personnel.ElementAt(i) is Sorcier)
                {
                    Console.WriteLine((tout_le_personnel.ElementAt(i) as Sorcier).ToString());
                }
            }
        }

        public void Afficher_Ensemble_Monstre()
        {
            Console.WriteLine("ENSEMBLE DES MONSTRES : \n");

            for (int i = 0; i < tout_le_personnel.Count(); i++)
            {
                if (tout_le_personnel.ElementAt(i) is Monstre)
                {
                    Console.WriteLine((tout_le_personnel.ElementAt(i) as Monstre).ToString());
                }
            }
        }

        public void Afficher_Ensemble_Zombie()
        {
            Console.WriteLine("ENSEMBLE DES ZOMBIES : \n");

            for (int i = 0; i < tout_le_personnel.Count(); i++)
            {
                if (tout_le_personnel.ElementAt(i) is Zombie)
                {
                    Console.WriteLine((tout_le_personnel.ElementAt(i) as Zombie).ToString());
                }
            }
        }

        public void Afficher_Ensemble_Demon()
        {
            Console.WriteLine("ENSEMBLE DES DEMONS : \n");

            for (int i = 0; i < tout_le_personnel.Count(); i++)
            {
                if (tout_le_personnel.ElementAt(i) is Demon)
                {
                    Console.WriteLine((tout_le_personnel.ElementAt(i) as Demon).ToString());
                }
            }
        }

        public void Afficher_Ensemble_LoupGarou()
        {
            Console.WriteLine("ENSEMBLE DES LOUP-GAROUS : \n");

            for (int i = 0; i < tout_le_personnel.Count(); i++)
            {
                if (tout_le_personnel.ElementAt(i) is LoupGarou)
                {
                    Console.WriteLine((tout_le_personnel.ElementAt(i) as LoupGarou).ToString());
                }
            }
        }

        public void Afficher_Ensemble_Fantome()
        {
            Console.WriteLine("ENSEMBLE DES FANTOMES : \n");

            for (int i = 0; i < tout_le_personnel.Count(); i++)
            {
                if (tout_le_personnel.ElementAt(i) is Fantome)
                {
                    Console.WriteLine((tout_le_personnel.ElementAt(i) as Fantome).ToString());
                }
            }
        }

        public void Afficher_Ensemble_Vampire()
        {
            Console.WriteLine("ENSEMBLE DES VAMPIRES : \n");

            for (int i = 0; i < tout_le_personnel.Count(); i++)
            {
                if (tout_le_personnel.ElementAt(i) is Vampire)
                {
                    Console.WriteLine((tout_le_personnel.ElementAt(i) as Vampire).ToString());
                }
            }
        }

        public void Afficher_Ensemble_Male()
        {
            Console.WriteLine("ENSEMBLE DES MALES : \n");

            for(int i = 0; i < tout_le_personnel.Count(); i++)
            {
                if(tout_le_personnel.ElementAt(i).Sexe == TypeSexe.male)
                {
                    Console.WriteLine(tout_le_personnel.ElementAt(i).ToString());
                }
            }
        }

        public void Afficher_Ensemble_Femelle()
        {
            Console.WriteLine("ENSEMBLE DES FEMELLES : \n");

            for (int i = 0; i < tout_le_personnel.Count(); i++)
            {
                if (tout_le_personnel.ElementAt(i).Sexe == TypeSexe.femelle)
                {
                    Console.WriteLine(tout_le_personnel.ElementAt(i).ToString());
                }
            }
        }


        //Fonction complexe
        public void Affichage_Elements_Personnel()
        {
            Console.WriteLine("Quel ensemble du personnel voulez-vous sortir parmis la liste ci-dessous ? (Entrez le numéro souhaité) ");
            Console.WriteLine(" 0. Emsemble Personnel \n 1. Ensemble Montres \n 2. Ensemble Sorciers \n 3. Ensemble Demons \n 4. Ensemble Fantomes \n 5. Ensemble Loup-Garous \n 6. Ensemble Vampire \n 7. Ensemble Zombies \n 8. Ensemble Males \n 9. Ensemble Femelles");
            int reponse = Convert.ToInt32(Console.ReadLine());

            if (reponse == 1)
            {
                Console.WriteLine("\n--------------------------------\n");
                Afficher_Ensemble_Monstre();
            }

            if (reponse == 2)
            {
                Console.WriteLine("\n--------------------------------\n");
                Afficher_Ensemble_Sorcier();
            }

            if (reponse == 3)
            {
                Console.WriteLine("\n--------------------------------\n");
                Afficher_Ensemble_Demon();
            }

            if (reponse == 4)
            {
                Console.WriteLine("\n--------------------------------\n");
                Afficher_Ensemble_Fantome();
            }

            if (reponse == 5)
            {
                Console.WriteLine("\n--------------------------------\n");
                Afficher_Ensemble_LoupGarou();
            }

            if (reponse == 6)
            {
                Console.WriteLine("\n--------------------------------\n");
                Afficher_Ensemble_Vampire();
            }

            if (reponse == 7)
            {
                Console.WriteLine("\n--------------------------------\n");
                Afficher_Ensemble_Zombie();                
            }

            if(reponse == 8)
            {
                Console.WriteLine("\n--------------------------------\n");
                Afficher_Ensemble_Male();
            }

            if(reponse == 9)
            {
                Console.WriteLine("\n--------------------------------\n");
                Afficher_Ensemble_Femelle();
            }

            if(reponse == 0)
            {
                Console.WriteLine("\n--------------------------------\n");
                Afficher_Ensemble_Personnel();
            }
        }








        //Fonctions pour la cagnotte

        //Fonctions simples

        public void Augmenter_Cagnotte(Monstre monstre, int montant, Boutique barbe_a_papa)
        {
            monstre.Cagnotte = monstre.Cagnotte + montant;

            if (monstre.Cagnotte < 50)
            {
                monstre.Affectation = barbe_a_papa;
                barbe_a_papa.Equipe.Add(monstre);
            }

            if (monstre is Demon && monstre.Cagnotte > 500)
            {
                if (monstre.Affectation != null)
                {
                    if (monstre.Affectation.Equipe.Count() > monstre.Affectation.Nombre_min_monstre)
                    {
                        monstre.Affectation = null;
                    }
                }
            }

            if (monstre is Zombie && monstre.Cagnotte > 500)
            {
                if (monstre.Affectation != null)
                {
                    if (monstre.Affectation.Equipe.Count() > monstre.Affectation.Nombre_min_monstre)
                    {
                        monstre.Affectation = null;
                    }
                }
            }
        }

        public void Diminuer_Cagnotte(Monstre monstre, int montant, Boutique barbe_a_papa)
        {
            monstre.Cagnotte = monstre.Cagnotte - montant;

            if (monstre.Cagnotte < 50)
            {
                monstre.Affectation = barbe_a_papa;
                barbe_a_papa.Equipe.Add(monstre);
            }

            if (monstre is Demon && monstre.Cagnotte > 500)
            {
                if (monstre.Affectation != null)
                {
                    if (monstre.Affectation.Equipe.Count() > monstre.Affectation.Nombre_min_monstre)
                    {
                        monstre.Affectation = null;
                    }
                }
            }

            if (monstre is Zombie && monstre.Cagnotte > 500)
            {
                if (monstre.Affectation != null)
                {
                    if (monstre.Affectation.Equipe.Count() > monstre.Affectation.Nombre_min_monstre)
                    {
                        monstre.Affectation = null;
                    }
                }
            }
        }

        //Fonction complexe

        public void Modification_Cagnotte(Boutique barbe_a_papa)
        {
            Console.WriteLine("Entrez le nom de la personne dont vous voulez modifier la cagnotte");
            string nom_personne = Console.ReadLine();

            for (int i = 0; i < tout_le_personnel.Count(); i++)
            {
                if (tout_le_personnel.ElementAt(i).Nom == nom_personne && tout_le_personnel.ElementAt(i) is Monstre)
                {

                    Console.WriteLine("Voulez-vous incrementer (tapez 1) ou decrementer (tapez 2) la cagnotte?");
                    int reponse = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("De combien ? (int)");
                    int montant = Convert.ToInt32(Console.ReadLine());

                    if (reponse == 1)
                    {
                        Augmenter_Cagnotte((tout_le_personnel.ElementAt(i) as Monstre), montant, barbe_a_papa); 
                    }
                    if(reponse == 2)
                    {
                        Diminuer_Cagnotte((tout_le_personnel.ElementAt(i) as Monstre), montant, barbe_a_papa);
                    }
                }
            }

        }








        //Fonction de lecture fichier
        static List<Personnel> Lecture_Fichier(string nom_fichier)
        {

            List<Personnel> liste = new List<Personnel>();
            try
            {
                StreamReader monStreamReader = new StreamReader(nom_fichier);
                string ligne = monStreamReader.ReadLine();

                while (ligne != null)
                {
                    string[] temp = ligne.Split(';');




                    if (temp[0] == "Sorcier")
                    {
                        try
                        {
                            List<string> liste_pouvoirs = new List<string>();
                            string value = temp[7];
                            char delimiter = '-';
                            string[] sub = value.Split(delimiter);

                            for (int i = 0; i < sub.Length; i++)
                            {
                                liste_pouvoirs.Add(sub[i]);
                            }
                            Sorcier S = new Sorcier(liste_pouvoirs, (Grade)Enum.Parse(typeof(Grade), temp[6]), temp[5], Convert.ToInt32(temp[1]), temp[2], temp[3], (TypeSexe)Enum.Parse(typeof(TypeSexe), temp[4]));
                            liste.Add(S);
                        }

                        catch (Exception)
                        {
                            Console.WriteLine("Ajout Impossible");
                        }

                        //Console.WriteLine("Sorcier ");
                    }




                    if (temp[0] == "Monstre")
                    {

                        try
                        {
                            if (temp[7] != "")
                            {
                                TimeSpan duration = new TimeSpan(0, 0, 0);
                                Attraction A = new Attraction(true, duration, Convert.ToInt32(temp[7]), true, "", 1, "", true, "");
                                Monstre M = new Monstre(A, Convert.ToInt32(temp[6]), temp[5], Convert.ToInt32(temp[1]), temp[2], temp[3], (TypeSexe)Enum.Parse(typeof(TypeSexe), temp[4]));
                                liste.Add(M);
                            }
                            else
                            {
                                Monstre M = new Monstre(null, Convert.ToInt32(temp[6]), temp[5], Convert.ToInt32(temp[1]), temp[2], temp[3], (TypeSexe)Enum.Parse(typeof(TypeSexe), temp[4]));
                                liste.Add(M);
                            }

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Ajout Impossible");
                        }

                        //Console.WriteLine("Monstre ");

                    }




                    if (temp[0] == "Demon")
                    {
                        try
                        {
                            if (temp[7] == "neant" || temp[7] == "")
                            {
                                Demon D = new Demon(Convert.ToInt32(temp[8]), null, Convert.ToInt32(temp[6]), temp[5], Convert.ToInt32(temp[1]), temp[2], temp[3], (TypeSexe)Enum.Parse(typeof(TypeSexe), temp[4]));
                                liste.Add(D);
                            }
                            else
                            {
                                TimeSpan duration = new TimeSpan(0, 0, 0);
                                Attraction A = new Attraction(true, duration, Convert.ToInt32(temp[7]), true, "", 1, "", true, "");
                                Demon D = new Demon(Convert.ToInt32(temp[8]), A, Convert.ToInt32(temp[6]), temp[5], Convert.ToInt32(temp[1]), temp[2], temp[3], (TypeSexe)Enum.Parse(typeof(TypeSexe), temp[4]));
                                liste.Add(D);
                            }

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Ajout Impossible");
                        }

                        //Console.WriteLine("Démon ");
                    }




                    if (temp[0] == "Fantome")
                    {
                        try
                        {
                            if (temp[7] == "neant" || temp[7] == "" || temp[7] == "parc")
                            {
                                Fantome F = new Fantome(null, Convert.ToInt32(temp[6]), temp[5], Convert.ToInt32(temp[1]), temp[2], temp[3], (TypeSexe)Enum.Parse(typeof(TypeSexe), temp[4]));
                                liste.Add(F);
                            }
                            else
                            {
                                TimeSpan duration = new TimeSpan(0, 0, 0);
                                Attraction A = new Attraction(true, duration, Convert.ToInt32(temp[7]), true, "", 1, "", true, "");
                                Fantome F = new Fantome(A, Convert.ToInt32(temp[6]), temp[5], Convert.ToInt32(temp[1]), temp[2], temp[3], (TypeSexe)Enum.Parse(typeof(TypeSexe), temp[4]));
                                liste.Add(F);
                            }

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Ajout Impossible");
                        }

                        //Console.WriteLine("Fantome ");
                    }




                    if (temp[0] == "LoupGarou")
                    {
                        try
                        {
                            if (temp[7] == "neant" || temp[7] == "" || temp[7] == "parc")
                            {
                                LoupGarou LG = new LoupGarou(Convert.ToDouble(temp[8]), null, Convert.ToInt32(temp[6]), temp[5], Convert.ToInt32(temp[1]), temp[2], temp[3], (TypeSexe)Enum.Parse(typeof(TypeSexe), temp[4]));
                                liste.Add(LG);
                            }
                            else
                            {
                                TimeSpan duration = new TimeSpan(0, 0, 0);
                                Attraction A = new Attraction(true, duration, Convert.ToInt32(temp[7]), true, "", 1, "", true, "");
                                LoupGarou LG = new LoupGarou(Convert.ToDouble(temp[8]), A, Convert.ToInt32(temp[6]), temp[5], Convert.ToInt32(temp[1]), temp[2], temp[3], (TypeSexe)Enum.Parse(typeof(TypeSexe), temp[4]));
                                liste.Add(LG);
                            }

                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Ajout Impossible");
                        }

                        //Console.WriteLine("LoupGarou ");
                    }




                    if (temp[0] == "Vampire")
                    {
                        try
                        {
                            if (temp[7] == "neant" || temp[7] == "" || temp[7] == "parc")
                            {
                                Vampire V = new Vampire((float)Convert.ToDouble(temp[8]), null, Convert.ToInt32(temp[6]), temp[5], Convert.ToInt32(temp[1]), temp[2], temp[3], (TypeSexe)Enum.Parse(typeof(TypeSexe), temp[4]));
                                liste.Add(V);
                            }
                            else
                            {
                                TimeSpan duration = new TimeSpan(0, 0, 0);
                                Attraction A = new Attraction(true, duration, Convert.ToInt32(temp[7]), true, "", 1, "", true, "");
                                Vampire V = new Vampire((float)Convert.ToDouble(temp[8]), A, Convert.ToInt32(temp[6]), temp[5], Convert.ToInt32(temp[1]), temp[2], temp[3], (TypeSexe)Enum.Parse(typeof(TypeSexe), temp[4]));
                                liste.Add(V);
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Ajout Impossible");
                        }

                        //Console.WriteLine("Vampire ");
                    }




                    if (temp[0] == "Zombie")
                    {
                        try
                        {
                            if (temp[7] == "neant" || temp[7] == "" || temp[7] == "parc")
                            {
                                Zombie Z = new Zombie(Convert.ToInt32(temp[9]), (CouleurZ)Enum.Parse(typeof(CouleurZ), temp[8]), null, Convert.ToInt32(temp[6]), temp[5], Convert.ToInt32(temp[1]), temp[2], temp[3], (TypeSexe)Enum.Parse(typeof(TypeSexe), temp[4]));
                                liste.Add(Z);
                            }
                            else
                            {
                                TimeSpan duration = new TimeSpan(0, 0, 0);
                                Attraction A = new Attraction(true, duration, Convert.ToInt32(temp[7]), true, "", 1, "", true, "");
                                Zombie Z = new Zombie(Convert.ToInt32(temp[9]), (CouleurZ)Enum.Parse(typeof(CouleurZ), temp[8]), A, Convert.ToInt32(temp[6]), temp[5], Convert.ToInt32(temp[1]), temp[2], temp[3], (TypeSexe)Enum.Parse(typeof(TypeSexe), temp[4]));
                                liste.Add(Z);
                            }
                        }

                        catch (Exception)
                        {
                            Console.WriteLine("Ajout Impossible");
                        }

                        //Console.WriteLine("Zombie ");
                    }

                    ligne = monStreamReader.ReadLine();
                }
                monStreamReader.Close();

                /*Console.WriteLine();
                foreach (Personnel val in liste)
                {
                    Console.WriteLine("     " + val.ToString());
                }*/
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            return liste;
        }

        static List<Attraction> Lecture_Fichier_Attraction(string nom_fichier)
        {

            List<Attraction> liste = new List<Attraction>();
            try
            {
                StreamReader monStreamReader = new StreamReader(nom_fichier);
                string ligne = monStreamReader.ReadLine();

                while (ligne != null)
                {
                    string[] temp = ligne.Split(';');

                    if (temp[0] == "Boutique")
                    {

                        try
                        {
                            TimeSpan duration = new TimeSpan(0, 0, 0);
                            Boutique B = new Boutique((TypeBoutique)Enum.Parse(typeof(TypeBoutique), temp[6]), Convert.ToBoolean(temp[4]), duration, Convert.ToInt32(temp[1]), false, "/", Convert.ToInt32(temp[3]), temp[2], true, temp[5]);
                            liste.Add(B);
                        }

                        catch (Exception)
                        {
                            Console.WriteLine("Ajout Impossible");
                        }

                        //Console.WriteLine("Boutique ");
                    }


                    if (temp[0] == "DarkRide")
                    {

                        try
                        {
                            TimeSpan duration = new TimeSpan(0, 0, 0);
                            DarkRide DR = new DarkRide(duration, Convert.ToBoolean(temp[7]), Convert.ToBoolean(temp[4]), duration, Convert.ToInt32(temp[1]), false, "/", Convert.ToInt32(temp[3]), temp[2], true, temp[5]);
                            liste.Add(DR);
                        }

                        catch (Exception)
                        {
                            Console.WriteLine("Ajout Impossible");
                        }

                        //Console.WriteLine("DarkRide ");
                    }


                    if (temp[0] == "RollerCoaster")
                    {

                        try
                        {
                            TimeSpan duration = new TimeSpan(0, 0, 0);
                            RollerCoaster RC = new RollerCoaster(Convert.ToInt32(temp[7]), (TypeCategorie)Enum.Parse(typeof(TypeCategorie), temp[6]), (float)Convert.ToDouble(temp[8]), Convert.ToBoolean(temp[4]), duration, Convert.ToInt32(temp[1]), false, "/", Convert.ToInt32(temp[3]), temp[2], true, temp[5]);
                            liste.Add(RC);
                        }

                        catch (Exception)
                        {
                            Console.WriteLine("Ajout Impossible");
                        }

                        //Console.WriteLine("RollerCoaster ");
                    }


                    if (temp[0] == "Spectacles")
                    {
                        List<DateTime> horaires = new List<DateTime>();
                        string value = temp[8];
                        char delimiter = ' ';
                        string[] sub = value.Split(delimiter);

                        for (int i = 0; i < sub.Length; i++)
                        {
                            horaires.Add(Convert.ToDateTime(sub[i]));
                        }
                        try
                        {
                            TimeSpan duration = new TimeSpan(0, 0, 0);

                            Spectacle S = new Spectacle(horaires, Convert.ToInt32(temp[7]), temp[6], Convert.ToBoolean(temp[4]), duration, Convert.ToInt32(temp[1]), false, "/", Convert.ToInt32(temp[3]), temp[2], true, temp[5]);
                            liste.Add(S);
                        }

                        catch (Exception)
                        {
                            Console.WriteLine("Ajout Impossible");
                        }

                        //Console.WriteLine("Spectacle ");
                    }

                    ligne = monStreamReader.ReadLine();
                }
                monStreamReader.Close();

                /*Console.WriteLine();
                foreach (Attraction val in liste)
                {
                    Console.WriteLine("     " + val.ToString());
                }*/
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            return liste;
        }


        //Remplissage CSV
        public void Remplissage_CSV_Personnel(string NomFichier)
        {
            StreamWriter ecriture = new StreamWriter(@".\..\..\..\RESULTATcsv\" + NomFichier + ".csv");
            var ligne = "";

            for (int i = 0; i < tout_le_personnel.Count(); i++)
            {
                if (tout_le_personnel.ElementAt(i) is Monstre && (tout_le_personnel.ElementAt(i) as Monstre).Affectation != null)
                {
                    if (tout_le_personnel.ElementAt(i) is Demon)
                    {
                        ligne = (tout_le_personnel.ElementAt(i) as Demon).Nom1 + ";" + (tout_le_personnel.ElementAt(i) as Demon).Affectation.Nom + ";" + Convert.ToString((tout_le_personnel.ElementAt(i) as Demon).Cagnotte) + ";" + tout_le_personnel.ElementAt(i).Fonction + ";" + Convert.ToString(tout_le_personnel.ElementAt(i).Matricule) + ";" + tout_le_personnel.ElementAt(i).Nom + ";" + tout_le_personnel.ElementAt(i).Prenom + ";" + tout_le_personnel.ElementAt(i).Sexe + ";" + Convert.ToString((tout_le_personnel.ElementAt(i) as Demon).Force);
                        ecriture.WriteLine(ligne);
                    }

                    if (tout_le_personnel.ElementAt(i) is Vampire)
                    {
                        ligne = (tout_le_personnel.ElementAt(i) as Vampire).Nom1 + ";" + (tout_le_personnel.ElementAt(i) as Vampire).Affectation.Nom + ";" + Convert.ToString((tout_le_personnel.ElementAt(i) as Vampire).Cagnotte) + ";" + tout_le_personnel.ElementAt(i).Fonction + ";" + Convert.ToString(tout_le_personnel.ElementAt(i).Matricule) + ";" + tout_le_personnel.ElementAt(i).Nom + ";" + tout_le_personnel.ElementAt(i).Prenom + ";" + tout_le_personnel.ElementAt(i).Sexe + ";" + Convert.ToString((tout_le_personnel.ElementAt(i) as Vampire).Indice_luminosite);
                        ecriture.WriteLine(ligne);
                    }

                    if (tout_le_personnel.ElementAt(i) is LoupGarou)
                    {
                        ligne = (tout_le_personnel.ElementAt(i) as LoupGarou).Nom1 + ";" + (tout_le_personnel.ElementAt(i) as LoupGarou).Affectation.Nom + ";" + Convert.ToString((tout_le_personnel.ElementAt(i) as LoupGarou).Cagnotte) + ";" + tout_le_personnel.ElementAt(i).Fonction + ";" + Convert.ToString(tout_le_personnel.ElementAt(i).Matricule) + ";" + tout_le_personnel.ElementAt(i).Nom + ";" + tout_le_personnel.ElementAt(i).Prenom + ";" + tout_le_personnel.ElementAt(i).Sexe + ";" + Convert.ToString((tout_le_personnel.ElementAt(i) as LoupGarou).Indice_cruaute);
                        ecriture.WriteLine(ligne);
                    }

                    if (tout_le_personnel.ElementAt(i) is Zombie)
                    {
                        ligne = (tout_le_personnel.ElementAt(i) as Zombie).Nom1 + ";" + (tout_le_personnel.ElementAt(i) as Zombie).Affectation.Nom + ";" + Convert.ToString((tout_le_personnel.ElementAt(i) as Zombie).Cagnotte) + ";" + tout_le_personnel.ElementAt(i).Fonction + ";" + Convert.ToString(tout_le_personnel.ElementAt(i).Matricule) + ";" + tout_le_personnel.ElementAt(i).Nom + ";" + tout_le_personnel.ElementAt(i).Prenom + ";" + tout_le_personnel.ElementAt(i).Sexe + ";" + Convert.ToString((tout_le_personnel.ElementAt(i) as Zombie).Degre_decomposition) + ";" + (tout_le_personnel.ElementAt(i) as Zombie).Teint;
                        ecriture.WriteLine(ligne);
                    }

                    if (tout_le_personnel.ElementAt(i) is Fantome)
                    {
                        ligne = (tout_le_personnel.ElementAt(i) as Fantome).Nom1 + ";" + (tout_le_personnel.ElementAt(i) as Fantome).Affectation.Nom + ";" + Convert.ToString((tout_le_personnel.ElementAt(i) as Fantome).Cagnotte) + ";" + tout_le_personnel.ElementAt(i).Fonction + ";" + Convert.ToString(tout_le_personnel.ElementAt(i).Matricule) + ";" + tout_le_personnel.ElementAt(i).Nom + ";" + tout_le_personnel.ElementAt(i).Prenom + ";" + tout_le_personnel.ElementAt(i).Sexe;
                        ecriture.WriteLine(ligne);
                    }

                    if (tout_le_personnel.ElementAt(i) is Monstre && (tout_le_personnel.ElementAt(i) is Demon == false) && (tout_le_personnel.ElementAt(i) is Vampire == false) && (tout_le_personnel.ElementAt(i) is LoupGarou == false) && (tout_le_personnel.ElementAt(i) is Zombie == false) && (tout_le_personnel.ElementAt(i) is Fantome == false))
                    {
                        ligne = "Monstre" + ";" + (tout_le_personnel.ElementAt(i) as Monstre).Affectation.Nom + ";" + Convert.ToString((tout_le_personnel.ElementAt(i) as Monstre).Cagnotte) + ";" + tout_le_personnel.ElementAt(i).Fonction + ";" + Convert.ToString(tout_le_personnel.ElementAt(i).Matricule) + ";" + tout_le_personnel.ElementAt(i).Nom + ";" + tout_le_personnel.ElementAt(i).Prenom + ";" + tout_le_personnel.ElementAt(i).Sexe;
                        ecriture.WriteLine(ligne);
                    }

                }
                else
                {
                    if (tout_le_personnel.ElementAt(i) is Demon)
                    {
                        ligne = (tout_le_personnel.ElementAt(i) as Demon).Nom1 + ";" + "null" + ";" + Convert.ToString((tout_le_personnel.ElementAt(i) as Demon).Cagnotte) + ";" + tout_le_personnel.ElementAt(i).Fonction + ";" + Convert.ToString(tout_le_personnel.ElementAt(i).Matricule) + ";" + tout_le_personnel.ElementAt(i).Nom + ";" + tout_le_personnel.ElementAt(i).Prenom + ";" + tout_le_personnel.ElementAt(i).Sexe + ";" + Convert.ToString((tout_le_personnel.ElementAt(i) as Demon).Force);
                        ecriture.WriteLine(ligne);
                    }

                    if (tout_le_personnel.ElementAt(i) is Vampire)
                    {
                        ligne = (tout_le_personnel.ElementAt(i) as Vampire).Nom1 + ";" + "null" + ";" + Convert.ToString((tout_le_personnel.ElementAt(i) as Vampire).Cagnotte) + ";" + tout_le_personnel.ElementAt(i).Fonction + ";" + Convert.ToString(tout_le_personnel.ElementAt(i).Matricule) + ";" + tout_le_personnel.ElementAt(i).Nom + ";" + tout_le_personnel.ElementAt(i).Prenom + ";" + tout_le_personnel.ElementAt(i).Sexe + ";" + Convert.ToString((tout_le_personnel.ElementAt(i) as Vampire).Indice_luminosite);
                        ecriture.WriteLine(ligne);
                    }

                    if (tout_le_personnel.ElementAt(i) is LoupGarou)
                    {
                        ligne = (tout_le_personnel.ElementAt(i) as LoupGarou).Nom1 + ";" + "null" + ";" + Convert.ToString((tout_le_personnel.ElementAt(i) as LoupGarou).Cagnotte) + ";" + tout_le_personnel.ElementAt(i).Fonction + ";" + Convert.ToString(tout_le_personnel.ElementAt(i).Matricule) + ";" + tout_le_personnel.ElementAt(i).Nom + ";" + tout_le_personnel.ElementAt(i).Prenom + ";" + tout_le_personnel.ElementAt(i).Sexe + ";" + Convert.ToString((tout_le_personnel.ElementAt(i) as LoupGarou).Indice_cruaute);
                        ecriture.WriteLine(ligne);
                    }

                    if (tout_le_personnel.ElementAt(i) is Zombie)
                    {
                        ligne = (tout_le_personnel.ElementAt(i) as Zombie).Nom1 + ";" + "null" + ";" + Convert.ToString((tout_le_personnel.ElementAt(i) as Zombie).Cagnotte) + ";" + tout_le_personnel.ElementAt(i).Fonction + ";" + Convert.ToString(tout_le_personnel.ElementAt(i).Matricule) + ";" + tout_le_personnel.ElementAt(i).Nom + ";" + tout_le_personnel.ElementAt(i).Prenom + ";" + tout_le_personnel.ElementAt(i).Sexe + ";" + Convert.ToString((tout_le_personnel.ElementAt(i) as Zombie).Degre_decomposition) + ";" + (tout_le_personnel.ElementAt(i) as Zombie).Teint;
                        ecriture.WriteLine(ligne);
                    }

                    if (tout_le_personnel.ElementAt(i) is Fantome)
                    {
                        ligne = (tout_le_personnel.ElementAt(i) as Fantome).Nom1 + ";" + "null" + ";" + Convert.ToString((tout_le_personnel.ElementAt(i) as Fantome).Cagnotte) + ";" + tout_le_personnel.ElementAt(i).Fonction + ";" + Convert.ToString(tout_le_personnel.ElementAt(i).Matricule) + ";" + tout_le_personnel.ElementAt(i).Nom + ";" + tout_le_personnel.ElementAt(i).Prenom + ";" + tout_le_personnel.ElementAt(i).Sexe;
                        ecriture.WriteLine(ligne);
                    }

                    if (tout_le_personnel.ElementAt(i) is Monstre && (tout_le_personnel.ElementAt(i) is Demon == false) && (tout_le_personnel.ElementAt(i) is Vampire == false) && (tout_le_personnel.ElementAt(i) is LoupGarou == false) && (tout_le_personnel.ElementAt(i) is Zombie == false) && (tout_le_personnel.ElementAt(i) is Fantome == false))
                    {
                        ligne = "Monstre" + ";" + "null" + ";" + Convert.ToString((tout_le_personnel.ElementAt(i) as Monstre).Cagnotte) + ";" + tout_le_personnel.ElementAt(i).Fonction + ";" + Convert.ToString(tout_le_personnel.ElementAt(i).Matricule) + ";" + tout_le_personnel.ElementAt(i).Nom + ";" + tout_le_personnel.ElementAt(i).Prenom + ";" + tout_le_personnel.ElementAt(i).Sexe;
                        ecriture.WriteLine(ligne);
                    }
                }

                if (tout_le_personnel.ElementAt(i) is Sorcier)
                {

                    ligne = (tout_le_personnel.ElementAt(i) as Sorcier).Nom1 + ";" + "telekinesie-transformations d'objets" + ";" + (tout_le_personnel.ElementAt(i) as Sorcier).Tatouage + ";" + tout_le_personnel.ElementAt(i).Fonction + ";" + Convert.ToString(tout_le_personnel.ElementAt(i).Matricule) + ";" + tout_le_personnel.ElementAt(i).Nom + ";" + tout_le_personnel.ElementAt(i).Prenom + ";" + tout_le_personnel.ElementAt(i).Sexe;
                    ecriture.WriteLine(ligne);

                }
            }

            ecriture.Close();
        }

        public void Remplissage_CSV_Attraction(string NomFichier)
        {
            StreamWriter ecriture = new StreamWriter(@".\..\..\..\RESULTATcsv\" + NomFichier + ".csv");
            var ligne = "";

            for (int i = 0; i < attractions.Count(); i++)
            {

                if (attractions.ElementAt(i) is Boutique)
                {
                    if ((attractions.ElementAt(i) as Boutique).Type_de_besoin != null)
                    {
                        ligne = (attractions.ElementAt(i) as Boutique).Nom1 + ";" + Convert.ToString(attractions.ElementAt(i).Besoin_specifique) + ";" + Convert.ToString(attractions.ElementAt(i).Duree_maintenance) + ";" + Convert.ToString(attractions.ElementAt(i).Identifiant) + ";" + Convert.ToString(attractions.ElementAt(i).Maintenance) + ";" + attractions.ElementAt(i).Nature_maintenance + ";" + Convert.ToString(attractions.ElementAt(i).Nombre_min_monstre) + ";" + attractions.ElementAt(i).Nom + ";" + Convert.ToString(attractions.ElementAt(i).Ouvert) + ";" + attractions.ElementAt(i).Type_de_besoin + ";" + (attractions.ElementAt(i) as Boutique).Type;
                        ecriture.WriteLine(ligne);
                    }
                    else
                    {
                        ligne = (attractions.ElementAt(i) as Boutique).Nom1 + ";" + Convert.ToString(attractions.ElementAt(i).Besoin_specifique) + ";" + Convert.ToString(attractions.ElementAt(i).Duree_maintenance) + ";" + Convert.ToString(attractions.ElementAt(i).Identifiant) + ";" + Convert.ToString(attractions.ElementAt(i).Maintenance) + ";" + attractions.ElementAt(i).Nature_maintenance + ";" + Convert.ToString(attractions.ElementAt(i).Nombre_min_monstre) + ";" + attractions.ElementAt(i).Nom + ";" + Convert.ToString(attractions.ElementAt(i).Ouvert) + ";" + "null" + (attractions.ElementAt(i) as Boutique).Type;
                        ecriture.WriteLine(ligne);
                    }
                }


                if (attractions.ElementAt(i) is DarkRide)
                {
                    ligne = (attractions.ElementAt(i) as DarkRide).Nom1 + ";" + Convert.ToString(attractions.ElementAt(i).Besoin_specifique) + ";" + Convert.ToString(attractions.ElementAt(i).Duree_maintenance) + ";" + Convert.ToString(attractions.ElementAt(i).Identifiant) + ";" + Convert.ToString(attractions.ElementAt(i).Maintenance) + ";" + attractions.ElementAt(i).Nature_maintenance + ";" + Convert.ToString(attractions.ElementAt(i).Nombre_min_monstre) + ";" + attractions.ElementAt(i).Nom + ";" + Convert.ToString(attractions.ElementAt(i).Ouvert) + ";" + attractions.ElementAt(i).Type_de_besoin + ";" + Convert.ToString((attractions.ElementAt(i) as DarkRide).Duree) + ";" + Convert.ToString((attractions.ElementAt(i) as DarkRide).Vehicule);
                    ecriture.WriteLine(ligne);
                }

                if (attractions.ElementAt(i) is RollerCoaster)
                {
                    ligne = (attractions.ElementAt(i) as RollerCoaster).Nom1 + ";" + Convert.ToString(attractions.ElementAt(i).Besoin_specifique) + ";" + Convert.ToString(attractions.ElementAt(i).Duree_maintenance) + ";" + Convert.ToString(attractions.ElementAt(i).Identifiant) + ";" + Convert.ToString(attractions.ElementAt(i).Maintenance) + ";" + attractions.ElementAt(i).Nature_maintenance + ";" + Convert.ToString(attractions.ElementAt(i).Nombre_min_monstre) + ";" + attractions.ElementAt(i).Nom + ";" + Convert.ToString(attractions.ElementAt(i).Ouvert) + ";" + attractions.ElementAt(i).Type_de_besoin + ";" + Convert.ToString((attractions.ElementAt(i) as RollerCoaster).Age_min) + ";" + Convert.ToString((attractions.ElementAt(i) as RollerCoaster).Categorie) + ";" + Convert.ToString((attractions.ElementAt(i) as RollerCoaster).Taille_minimum);
                    ecriture.WriteLine(ligne);
                }

                if (attractions.ElementAt(i) is Spectacle)
                {
                    if ((attractions.ElementAt(i) as Spectacle).Type_de_besoin != null)
                    {
                        ligne = (attractions.ElementAt(i) as Spectacle).Nom1 + ";" + Convert.ToString(attractions.ElementAt(i).Besoin_specifique) + ";" + Convert.ToString(attractions.ElementAt(i).Duree_maintenance) + ";" + Convert.ToString(attractions.ElementAt(i).Identifiant) + ";" + Convert.ToString(attractions.ElementAt(i).Maintenance) + ";" + attractions.ElementAt(i).Nature_maintenance + ";" + Convert.ToString(attractions.ElementAt(i).Nombre_min_monstre) + ";" + attractions.ElementAt(i).Nom + ";" + Convert.ToString(attractions.ElementAt(i).Ouvert) + ";" + attractions.ElementAt(i).Type_de_besoin + ";" + Convert.ToString((attractions.ElementAt(i) as Spectacle).Nom_salle) + ";" + Convert.ToString((attractions.ElementAt(i) as Spectacle).Nombre_place) + ";" + "10:15 12:15 14:15 16:15";
                        ecriture.WriteLine(ligne);
                    }
                    else
                    {
                        ligne = (attractions.ElementAt(i) as Spectacle).Nom1 + ";" + Convert.ToString(attractions.ElementAt(i).Besoin_specifique) + ";" + Convert.ToString(attractions.ElementAt(i).Duree_maintenance) + ";" + Convert.ToString(attractions.ElementAt(i).Identifiant) + ";" + Convert.ToString(attractions.ElementAt(i).Maintenance) + ";" + attractions.ElementAt(i).Nature_maintenance + ";" + Convert.ToString(attractions.ElementAt(i).Nombre_min_monstre) + ";" + attractions.ElementAt(i).Nom + ";" + Convert.ToString(attractions.ElementAt(i).Ouvert) + ";" + "null" + ";" + Convert.ToString((attractions.ElementAt(i) as Spectacle).Nom_salle) + ";" + Convert.ToString((attractions.ElementAt(i) as Spectacle).Nombre_place) + ";" + "10:15 12:15 14:15 16:15";
                        ecriture.WriteLine(ligne);
                    }
                }
            }

            ecriture.Close();

            // System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("message8.csv");
            // System.Diagnostics.Process.Start(psi);
        }



        //Fonction ToString
        override public string ToString()
        {
            string chaine = "";

            chaine += "\n" + " Liste du Personnel : " + "\n\n";
            for (int i = 0; i < tout_le_personnel.Count(); i++)
            {
                chaine += tout_le_personnel.ElementAt(i) + "\n";         
            }

            chaine += "\n" + " Liste des Attractions : " + "\n";
            for (int i = 0; i < attractions.Count(); i++)
            {
                chaine += attractions.ElementAt(i);
            }

            return chaine;
        }

    }
}
