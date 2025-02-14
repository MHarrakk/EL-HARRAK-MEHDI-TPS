using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP5_Gestion_Comptes_Bancaires
{

    class Banque
    {
        private List<Compte> comptes = new List<Compte>();

        public void AjouterCompte()
        {
            Console.Write("Numero du compte : ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Nom : ");
            string nom = Console.ReadLine();

            Console.Write("Prenom : ");
            string prenom = Console.ReadLine();

            comptes.Add(new Compte(numero, nom, prenom));
            Console.WriteLine("Compte créé !");
        }

        public Compte RechercherCompte(int numero)
        {
            for (int i = 0; i < comptes.Count; i++)
            {
                if (comptes[i].Numero == numero)
                    return comptes[i];
            }
            return null;
        }

        public void SupprimerCompte()
        {
            Console.Write("Numero du compte a supprimer : ");
            int numero = int.Parse(Console.ReadLine());

            Compte compte = RechercherCompte(numero);
            if (compte != null)
            {
                comptes.Remove(compte);
                Console.WriteLine("Compte supprime");
            }
            else
                Console.WriteLine("Compte pas trouve");
        }

        public void AfficherComptes()
        {
            if (comptes.Count == 0)
            {
                Console.WriteLine("Y'a aucun compte");
                return;
            }

            foreach (var compte in comptes)
                Console.WriteLine(compte);
        }

        public void OperationSurCompte()
        {
            Console.Write("Numero du compte ? ");
            int numero = int.Parse(Console.ReadLine());

            Compte compte = RechercherCompte(numero);
            if (compte == null)
            {
                Console.WriteLine("pas trouve");
                return;
            }

            while (true)
            {
                Console.WriteLine("\n== MENU OPÉRATION SUR " + numero + " ==");
                Console.WriteLine("1) Ajouter argent");
                Console.WriteLine("2) Retirer argent");
                Console.WriteLine("3) Voir historique");
                Console.WriteLine("4) Retour");
                Console.Write("Choix : ");
                string choix = Console.ReadLine();

                if (choix == "1")
                {
                    Console.Write("Montant : ");
                    double montant = double.Parse(Console.ReadLine());
                    compte.Crediter(montant);
                }
                else if (choix == "2")
                {
                    Console.Write("Montant : ");
                    double montant = double.Parse(Console.ReadLine());
                    compte.Debiter(montant);
                }
                else if (choix == "3")
                {
                    compte.AfficherHistorique();
                }
                else if (choix == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Hein ? Choix pas valide.");
                }
            }
        }
    }

}
