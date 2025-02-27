using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_GesrtionRH
{
    public abstract class Personnel : Person
    {
        private int bureau;
        private double salaire;
        private double prime;

        public Personnel(int bureau, double salaire,double prime, string code, string nom,string prenom):base(code, nom, prenom)
        {
            this.bureau = bureau;
            this.salaire = salaire; 
            this.prime = prime;
        } 

        public int Bureau {  
            get { return bureau; }
            set { bureau = value; } 
        }

        public double Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }

        public double Prime
        {
            get { return prime; }
            set { prime = value; }
        }
    }

}