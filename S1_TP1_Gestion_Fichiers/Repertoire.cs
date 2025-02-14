using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Gestion_Fichiers
{
    class Repertoire
    {
        public String Nom { get; set; }
        public int Nbr_fichiers { get; private set; }
        private Fichier[] fichiers;

        public Repertoire(string nom)
        {
            Nom = nom;
            Nbr_fichiers = 0;
            fichiers = new Fichier[30];
        }

        public void Afficher()
        {
            Console.WriteLine("Le nom du repertoire est : " + Nom);
            Console.WriteLine("Le nombre des fichiers est :" + Nbr_fichiers);

            if (Nbr_fichiers == 0)
            {
                Console.WriteLine("Le repertoire est vide");
            }
            else
            {
                Console.WriteLine("Liste des fichiers :");
                for (int i = 0; i < Nbr_fichiers; i++)
                {
                    fichiers[i].Afficher();
                }
            }
        }

        public int Rechercher(String nom)
        {
            for (int i = 0; i < Nbr_fichiers; i++)
            {
                if (fichiers[i] != null && fichiers[i].Nom.Equals(nom, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Ajouter(Fichier fichier)
        {
            if (fichier == null)
            {
                Console.WriteLine("Le fichier est null");
                return false;
            }
            if (Nbr_fichiers < 30)
            {
                fichiers[Nbr_fichiers] = fichier;
                Nbr_fichiers++;
                return true;
            }
            return false;
        }

        public void RechercherPDF()
        {
            Console.WriteLine("Fichiers avec l'extension PDF :");
            bool found = false;
            for (int i = 0; i < Nbr_fichiers; i++)
            {
                if (fichiers[i].Extension.Equals("pdf", StringComparison.OrdinalIgnoreCase))
                {
                    fichiers[i].Afficher();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Aucun fichier PDF trouvé.");
            }
        }

        public bool Supprimer(String nom)
        {
            int index = Rechercher(nom);
            if (index != -1)
            {
                for (int i = index; i < Nbr_fichiers - 1; i++)
                {
                    fichiers[i] = fichiers[i + 1];
                }
                fichiers[Nbr_fichiers - 1] = null;
                Nbr_fichiers--;
                return true;
            }
            return false;
        }

        public bool Renommer(String ancienNom, String nouveauNom)
        {
            int index = Rechercher(ancienNom);
            if (index != -1)
            {
                fichiers[index].Nom = nouveauNom;
                return true;
            }
            return false;
        }

        public bool Modifier(String nom, float nouvelleTaille)
        {
            int index = Rechercher(nom);
            if (index != -1 && nouvelleTaille > 0)
            {
                fichiers[index].Taille = nouvelleTaille;
                return true;
            }
            return false;
        }

        public float GetTaille()
        {
            float tailleTotal = 0;
            for (int i = 0; i < Nbr_fichiers; i++)
            {
                tailleTotal += fichiers[i].Taille;
            }
            return tailleTotal / 1024;
        }
    }
}

