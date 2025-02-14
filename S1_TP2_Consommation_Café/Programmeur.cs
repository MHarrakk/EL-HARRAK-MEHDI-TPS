using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Consommation_Café
{
    class Programmeur
    {

        public int Id;
        public string Nom;
        public string Prenom;
        public int Bureau;

        public Programmeur(int id, string nom, string prenom, int bureau)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Bureau = bureau;
        }

        public override string ToString()
        {
            return "ID: " + Id + ", Nom: " + Nom + ", Prénom: " + Prenom + ", Bureau: " + Bureau;
        }
    }
}
