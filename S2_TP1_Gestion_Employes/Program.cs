using System;


namespace TP1_Gestion_Employes
{
    class Program
    {
        static void Main(string[] args)
        {
            GestionEmployes gestionEmployes = new GestionEmployes();

            gestionEmployes.AjouterEmploye(new Employee("Harrak", "Mehdi", 10000, "Chef de projet", new DateOnly(2020, 7, 15)));
            gestionEmployes.AjouterEmploye(new Employee("El Matni", "Adam", 8000, "Backend", new DateOnly(2022, 8, 25)));
            gestionEmployes.AjouterEmploye(new Employee("Kontar", "Riham", 7000, "Frontend", new DateOnly(2024, 9, 10)));

            Directeur directeur = Directeur.GetInstance();

            directeur.SetGestionEmployes(gestionEmployes);

            Console.WriteLine("La liste des employes est:");
            directeur.AfficherEmployes();

            Console.WriteLine("\nSalaire total de l'entreprise : " + directeur.GetSalaireTotal() + " dhs");


            Console.WriteLine("Salaire moyen des employes : " + directeur.GetSalaireMoyen() + " dhs");


        }
    }
}