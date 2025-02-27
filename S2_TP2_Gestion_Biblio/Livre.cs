using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_TP2_Gestion_Biblio
{
    class Livre : Document
    {
        private string auteur;
        private int nombrePages;

        public string Auteur{
            get { return auteur; }
            set { auteur = value; }
            }
        

        public Livre(int numero_enregistrement, string titre) : base(titre)
        {
        }

        public Livre(int numero_enregistrement, string titre,string auteur, int nombrePages): base(titre)
        {
            this.auteur = auteur;
            this.nombrePages = nombrePages;
        }
        public override string Description()
        {
            return $"Livre [Numero: {NumeroEnregistrement}, Titre: {Titre}, Auteur: {Auteur}, Pages: {NombrePages}]";
        }
    }
}
