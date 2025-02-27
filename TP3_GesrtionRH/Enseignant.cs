using System;
using System.Collections.Generic;
using TP3_GesrtionRH;

namespace TP3_GestionRH
{
    class Enseignant : Personnel
    {
        private Grade grade;
        private double vh;
        private double heuresSupp;
        private Dictionary<string, List<Etudiant>> groupes = new Dictionary<string, List<Etudiant>>();

        public Enseignant(string code, string nom, string prenom, string bureau, double salaire, double prime) : base(code, nom, prenom, bureau, salaire, prime)
        {
            this.grade = grade;
            this.vh = vh;
            this.heuresSupp = 0;
            this.Prime = prime;
        }

        public Grade Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public double VH
        {
            get { return vh; }
            set { vh = value; }
        }

        public double HeuresSupp
        {
            get { return heuresSupp; }
            set { heuresSupp = value; }
        }
        public Dictionary<string, List<Etudiant>> Groupes
        {
            get { return groupes; }
        }

        public void Afficher_ens()
        {
            Console.WriteLine($"Liste des groupes et etudiants du professeur Mr.{Nom} {Prenom}");
            foreach (var key in groupes.Keys)
            {
                Console.WriteLine($"{key}");
                foreach (var item in groupes[key])
                {
                    item.Afficher_etd();
                }
            }
        }
        public override double CalculerSalaire()
        {
            return Salaire + (int)grade * heuresSupp + Prime;
        }
    }
     
    }
}
