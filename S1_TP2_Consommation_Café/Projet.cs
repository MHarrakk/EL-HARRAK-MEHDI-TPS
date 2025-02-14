using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Consommation_Café
{
    class Projet
    {
        public int Code;
        public string Sujet;
        public int DureeSemaines;
        public List<Programmeur> Programmeurs;
        public List<Consos_Cafe> Consommations;

        public Projet(int code, string sujet, int dureeSemaines)
        {
            Code = code;
            Sujet = sujet;
            DureeSemaines = dureeSemaines;
            Programmeurs = new List<Programmeur>();
            Consommations = new List<Consos_Cafe>();
        }

        public void AjouterProgrammeur(Programmeur prog)
        {
            Programmeurs.Add(prog);
            Console.WriteLine("prog ajouté");
        }

        public Programmeur RechercherProgrammeur(int id)
        {
            for (int i = 0; i < Programmeurs.Count; i++)
            {
                if (Programmeurs[i].Id == id)
                {
                    return Programmeurs[i];
                }
            }
            return null;
        }

        public void AfficherProgrammeur(int id)
        {
            Programmeur prog = RechercherProgrammeur(id);
            if (prog != null)
                Console.WriteLine(prog);
            else
                Console.WriteLine("pas de programmeur");
        }

        public void AfficherListeProgrammeurs()
        {
            for (int i = 0; i < Programmeurs.Count; i++)
            {
                Console.WriteLine(Programmeurs[i]);
            }
        }

        public void SupprimerProgrammeur(int id)
        {
            for (int i = 0; i < Programmeurs.Count; i++)
            {
                if (Programmeurs[i].Id == id)
                {
                    Programmeurs.RemoveAt(i);
                    Console.WriteLine("prog supprimé");
                    return;
                }
            }
            Console.WriteLine("pas trouvé");
        }

        public void AjouterConsommation(int semaine, int programmeurId, int nbTasses)
        {
            if (RechercherProgrammeur(programmeurId) != null)
            {
                Consommations.Add(new Consos_Cafe(semaine, programmeurId, nbTasses));
                Console.WriteLine("Ajout café");
            }
            else
            {
                Console.WriteLine("programmeur pas là");
            }
        }

        public int TotalCafesParSemaine(int noSemaine)
        {
            int total = 0;
            for (int i = 0; i < Consommations.Count; i++)
            {
                if (Consommations[i].NoSemaine == noSemaine)
                {
                    total += Consommations[i].NbTasses;
                }
            }
            return total;
        }

        public void ChangerBureau(int programmeurId, int nouveauBureau)
        {
            Programmeur prog = RechercherProgrammeur(programmeurId);
            if (prog != null)
            {
                prog.Bureau = nouveauBureau;
                Console.WriteLine("Bureau changé");
            }
            else
            {
                Console.WriteLine("aucun prog trouvé");
            }
        }
    }
}
