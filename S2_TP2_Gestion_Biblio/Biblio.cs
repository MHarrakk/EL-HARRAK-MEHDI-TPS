using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_TP2_Gestion_Biblio
{
    class Biblio
    {
        private List<Document> documents = new List<Document>();

        public void ajouterDocument(Document doc) 
        {
            if (doc != null)
            {
                documents.Add(doc);
            }
        }
        public int nombredelivres()
        {
            int compteur = 0;
            foreach (var document in documents)
            {
                if (document is Livre)
                {
                    compteur++;
                }
            }
            return compteur;
        }
        public void AfficherDictionnaires()
        {
            foreach(var document in documents)
            {
                if (document is Dictionnaire)
                {
                    Console.WriteLine(document.Description());
                }
            }
        }
        public void TousLesAuteurs()
        {
            foreach (var document in documents)
            {
                if (document is Livre livre)
                {
                    Console.WriteLine($"Numero: {livre.NumeroEnregistrement}, Auteur: {livre.Auteur}");
                }
                else
                {
                    Console.WriteLine($"Numero: {document.NumeroEnregistrement}, Pas d’auteur");
                }
            }
        }

        public void ToutesLesDescriptions()
        {
            foreach (var document in documents)
            {
                Console.WriteLine(document.Description());
            }
        }


    }
}
