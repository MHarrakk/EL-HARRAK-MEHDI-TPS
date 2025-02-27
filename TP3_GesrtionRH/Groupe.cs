using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_GestionRH;

namespace TP3_GesrtionRH
{
    internal class Groupe
    {
        private string nom;
        private List<Etudiant> etudiants;

        public Groupe(string nom){
            this.nom=nom;
            this.etudiants = new List<Etudiant>();
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public List<Etudiant> Etudiants
        {
            get { return etudiants; }
        }

        public bool Ajouter_etudiant(Etudiant etudiant) 
        {
            if (etudiant != null && !this.etudiants.Contains(etudiant))
            {
                this.etudiants.Add(etudiant);
                return true;
            }
            return false;
        }

        public void Afficher_grp()
        {
            Console.WriteLine($"Groupe {Nom}:");
            foreach(var etudiant in etudiants) 
            {
                Console.WriteLine($"Code:{etudiant.Code}  Nom:{etudiant.Nom}  Prenom:{etudiant.Prenom}");
            }
        }

        public bool Ajouter_groupe(Enseignant enseignant)
        {
            if (!enseignant.Groupes.ContainsKey(Nom))
            {
                enseignant.Groupes.Add(Nom, etudiants);
                return true;
            }
            return false;
        }


    }
}
