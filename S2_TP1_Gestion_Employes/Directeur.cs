using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Gestion_Employes
{
    class Directeur
    {
        private static Directeur instance;
        private GestionEmployes gestionEmployes;
        
        private Directeur()
        {
            gestionEmployes = new GestionEmployes();
        }
        public static Directeur GetInstance()
        {
            if (instance == null)
            {
                instance = new Directeur();

            }
            return instance;
        }
        public void SetGestionEmployes(GestionEmployes gestion)
        {
            this.gestionEmployes = gestion;
        }
        public float GetSalaireTotal()
        {
            return gestionEmployes.SalaireTotal();
        }
        public float GetSalaireMoyen()
        {
            return gestionEmployes.CalculerSalaireMoyen();
        }
        public void AfficherEmployes()
        {
            gestionEmployes.AfficherEmployes();
        }
    }
}
