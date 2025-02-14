using System;
using TP2_Consommation_Café;

class Program
{
    static void Main()
    {
        Projet projet = new Projet(1, "Projet Café", 10);

        Programmeur p1 = new Programmeur(1, "Mehdi", "Harrak", 205);
        Programmeur p2 = new Programmeur(2, "Adam", "Matni-", 566);
        Programmeur p3 = new Programmeur(2, "Riham", "Kontar", 510);


        projet.AjouterProgrammeur(p1);
        projet.AjouterProgrammeur(p2);
        projet.AjouterProgrammeur(p3);


        projet.AjouterConsommation(1, 1, 4);
        projet.AjouterConsommation(2, 1, 5);
        projet.AjouterConsommation(1, 2, 6);
        projet.AjouterConsommation(2, 2, 3);

        Console.WriteLine("\nListe prog :");
        projet.AfficherListeProgrammeurs();

        projet.ChangerBureau(1, 300);

        Console.WriteLine("\nCafé semaine 1 : " + projet.TotalCafesParSemaine(1));

        projet.SupprimerProgrammeur(2);

        Console.WriteLine("\nListe prog après suppression :");
        projet.AfficherListeProgrammeurs();
    }
}
