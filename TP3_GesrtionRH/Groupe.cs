using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
