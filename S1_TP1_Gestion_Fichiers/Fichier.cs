using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Gestion_Fichiers
{
    class Fichier
    {
        public String Nom { get; set; }
        public String Extension { get; set; }
        public float Taille { get; set; }

        public void Afficher()
        {
            Console.WriteLine($" -{Nom}.{Extension} ({Taille}Ko)");
        }
    }
}