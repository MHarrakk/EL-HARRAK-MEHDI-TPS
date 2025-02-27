using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_GesrtionRH
{
    public abstract class Person
    {
        private string code;
        private string nom;
        private string prenom;

        public Person(string code, string nom, string prenom)
        {
            this.code = code;
            this.nom = nom;
            this.prenom = prenom;
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
    }

}