using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP3_GestionRH;

namespace TP3_GesrtionRH
{
    public class RessourcesHumaines : IRessourcesHumaines 
    {
        public List<Person> GRH;

        public RessourcesHumaines()
        {
            GRH = new List<Person>();
        }
        public void AjouterPersonne(Person p)
        {
            if (p != null)
            {
                GRH.Add(p);
            }
        }
        public void Afficher_Enseignants()
        {
            foreach (var person in GRH)
            {
                if (person is Enseignant)
                {
                    Console.WriteLine(person);
                }
            }
            
        }
        public int Rechercher_Ens(string code)
        {
            for (int i = 0; i < GRH.Count; i++)
            {
                if (GRH[i].Code == code)
                {
                    return i;
                }
            }
            return -1;

        }



    }
}
