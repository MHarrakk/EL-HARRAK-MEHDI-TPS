using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_TP2_Gestion_Biblio
{
    class Document
    {
        private static int compteur = 1;
        private int numeroEnregistrement;
        private string titre;

        public Document( string titre)
        {
            this.numeroEnregistrement = compteur++;
            this.titre = titre;
        }
        public int NumeroEnregistrement
        {
            get { return numeroEnregistrement; }
        }
        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }
        public virtual string Description()
        {
            return $"Document [Numero: {NumeroEnregistrement}, Titre: {Titre}]";
        }
    }
}
