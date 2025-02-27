using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_GesrtionRH
{
    public sealed class Directeur : Personnel
    {
        private static Directeur directeur = null;
        private Directeur(string code, string nom, string prenom, string bureau, double salaire, double prime) : base(code, nom, prenom, bureau, salaire, prime)
        {
        }

        public static Directeur getinstance(string code, string nom, string prenom, string bureau, double salaire, double prime)
        {
            if(directeur == null)
            {
                return new Directeur(code, nom, prenom, bureau, salaire, prime);
            }
            else
            {
                Console.WriteLine("Interdit de creer un nouveau directeur,il est deja cree");
            }
            return directeur;
        }

    }
}
