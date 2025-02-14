using System;

namespace TP1_Gestion_Fichiers
{
    class Program
    {
        static void Main(string[] args)
        {
            Repertoire monRepertoire = new Repertoire("Mes Documents");

            Fichier fichier1 = new Fichier { Nom = "Rapport", Extension = "pdf", Taille = 1500 };
            Fichier fichier2 = new Fichier { Nom = "Image", Extension = "jpg", Taille = 500 };
            Fichier fichier3 = new Fichier { Nom = "Projet", Extension = "docx", Taille = 2500 };
            Fichier fichier4 = new Fichier { Nom = "Cours", Extension = "pdf", Taille = 3000 };

            monRepertoire.Ajouter(fichier1);
            monRepertoire.Ajouter(fichier2);
            monRepertoire.Ajouter(fichier3);
            monRepertoire.Ajouter(fichier4);

            monRepertoire.Afficher();

            Console.WriteLine("\nRecherche du fichier 'Projet':");
            int index = monRepertoire.Rechercher("Projet");
            Console.WriteLine(index != -1 ? $"Fichier trouvé à l'index {index}" : "Fichier non trouvé");

            Console.WriteLine("\nRecherche des fichiers PDF:");
            monRepertoire.RechercherPDF();

            Console.WriteLine("\nRenommage du fichier 'Projet' en 'Projet_Final'");
            bool renommé = monRepertoire.Renommer("Projet", "Projet_Final");
            Console.WriteLine(renommé ? "Renommage réussi" : "Fichier non trouvé");

            Console.WriteLine("\nModification de la taille du fichier 'Image' à 700 Ko");
            bool modifié = monRepertoire.Modifier("Image", 700);
            Console.WriteLine(modifié ? "Modification réussie" : "Fichier non trouvé ou taille invalide");

            Console.WriteLine("\nSuppression du fichier 'Rapport'");
            bool supprimé = monRepertoire.Supprimer("Rapport");
            Console.WriteLine(supprimé ? "Suppression réussie" : "Fichier non trouvé");

            //apres changement 
            Console.WriteLine("\nÉtat du répertoire après modifications :");
            monRepertoire.Afficher();

            //afficher la taille en Mo 
            Console.WriteLine($"\nTaille totale du répertoire : {monRepertoire.GetTaille()} Mo");

            Console.ReadLine();
        }
    }
}
