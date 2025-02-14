using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using TP5_Gestion_Comptes_Bancaires;

class Program
{
    static Dictionary<string, string> utilisateurs = new Dictionary<string, string>();
    static Banque banque = new Banque();

    static void Main()
    {
        ChargerUtilisateurs();

        if (!AuthentifierUtilisateur()) return;

        while (true)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1) Ajouter compte");
            Console.WriteLine("2) Rechercher compte");
            Console.WriteLine("3) Supprimer compte");
            Console.WriteLine("4) Faire une opération");
            Console.WriteLine("5) Voir tous les comptes");
            Console.WriteLine("6) Quitter");
            Console.Write("Choix : ");

            string choix = Console.ReadLine();
            if (choix == "1") banque.AjouterCompte();
            else if (choix == "2")
            {
                Console.Write("Numéro du compte ? ");
                int numero = int.Parse(Console.ReadLine());
                Compte compte = banque.RechercherCompte(numero);
                Console.WriteLine(compte != null ? compte.ToString() : "Pas trouve");
            }
            else if (choix == "3") banque.SupprimerCompte();
            else if (choix == "4") banque.OperationSurCompte();
            else if (choix == "5") banque.AfficherComptes();
            else if (choix == "6") return;
            else Console.WriteLine("Choix inconnu !");
        }
    }

    static void ChargerUtilisateurs()
    {
        if (File.Exists("utilisateurs.json"))
        {
            string json = File.ReadAllText("utilisateurs.json");
            utilisateurs = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }
    }

    static bool AuthentifierUtilisateur()
    {
        Console.Write("Login : ");
        string login = Console.ReadLine();
        Console.Write("Mot de passe : ");
        string mdp = Console.ReadLine();

        if (utilisateurs.ContainsKey(login) && utilisateurs[login] == mdp)
        {
            Console.WriteLine("Connexion OK");
            return true;
        }

        Console.WriteLine(" identifiants incorrects");
        return false;
    }
}
