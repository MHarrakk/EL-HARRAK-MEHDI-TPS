using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_Gestion_Comptes_Bancaires
{

    class Compte
    {
        public int Numero;
        public string Nom;
        public string Prenom;
        public double Solde;
        public List<string> Historique;

        public Compte(int numero, string nom, string prenom)
        {
            Numero = numero;
            Nom = nom;
            Prenom = prenom;
            Solde = 0;
            Historique = new List<string>();
        }

        public void Crediter(double montant)
        {
            Solde += montant;
            Historique.Add("Ajoute " + montant + " dhs, solde = " + Solde);
        }

        public bool Debiter(double montant)
        {
            if (montant > Solde)
            {
                Console.WriteLine("Pas assez d'argent !");
                return false;
            }

            Solde -= montant;
            Historique.Add("Retire " + montant + " dhs, reste = " + Solde);
            return true;
        }

        public void AfficherHistorique()
        {
            Console.WriteLine("\n== Historique du compte " + Numero + " ==");
            foreach (var entry in Historique)
                Console.WriteLine(entry);
        }

        public override string ToString()
        {
            return Numero + " - " + Nom + " " + Prenom + " - " + Solde + " dhs";
        }
    }

}
