using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_GesrtionRH
{
    class Etudiant: Person
    {
        private string niveau;
        private double moyenne;

        public Etudiant(string code, string nom, string prenom,string niveau,double moyenne) : base(code, nom, prenom)
        {
            this.niveau = niveau;
            this.moyenne = moyenne;
        }

        public string Niveau
        {
            get { return niveau; }
            set { niveau = value; }
        }
        public double Moyenne
        {
            get { return moyenne; }
            set { moyenne = value; }
        }
        public void Afficher_etd()
        {
            Console.WriteLine($"Code:{Code}  Nom:{Nom}  Prenom:{Prenom}  Niveau:{Niveau}  Moyenne annuelle:{Moyenne}");
        }
    }
}