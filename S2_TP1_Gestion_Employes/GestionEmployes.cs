using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Gestion_Employes
{
    class GestionEmployes
    {
        private List<Employee> employes = new List<Employee>();

        public void AjouterEmploye(Employee employe)
        {
            employes.Add(employe);
            Console.WriteLine("Employe ajoute");
        }
        public bool SupprimerEmploye(Employee employee)
        {
            if (employes.Contains(employee))
            {
                employes.Remove(employee);
                Console.WriteLine("Employe retire");
                return true;
            }return false;
        }
        public float SalaireTotal()
        {
            float total = 0;
            foreach (var employe in employes)
            {
                total += employe.Salaire;
               
            }
            return total;
        }
        public float CalculerSalaireMoyen()
        {
            if (employes.Count == 0) return 0;
            return SalaireTotal() / employes.Count;
        }
        public void AfficherEmployes()
        {
            if (employes.Count == 0)
            {
                Console.WriteLine("Aucun employe");
                return;
            }
            foreach(var employe in employes)
            {
                Console.WriteLine(employe);
            }
        }



        

    }
}
