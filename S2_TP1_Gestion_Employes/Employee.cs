using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Gestion_Employes
{
    class Employee
    {
        private string nom;
        private string prenom;
        private float salaire;
        private string poste;
        private DateOnly date_embauche;

        public Employee(string nom, string prenom, float salaire, string poste, DateOnly date_Embauche)
        {
            Nom = nom;
            Prenom = prenom;
            Salaire = salaire;
            Poste = poste;
            Date_Embauche = date_Embauche;
        }

        public String Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public String Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public float Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }
        public String Poste
        {
            get { return poste; }
            set { poste = value; }
        }
        public DateOnly Date_Embauche
        {
            get { return date_embauche; }
            set { date_embauche=value;}
        }
        public override string ToString()
        {
            return $"{Nom}- {Prenom} -{Salaire} dhs -Embauche le{Date_Embauche.ToShortDateString()} ";
        }




    }
}
