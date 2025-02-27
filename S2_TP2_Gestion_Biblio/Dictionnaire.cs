using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S2_TP2_Gestion_Biblio
{
    class Dictionnaire: Document
    {
        private string langue;
        private int nombreDefinitions;

        public string Langue
        {
            get { return langue; }
            set { langue = value; }
        }
        public int NombreDefinitions
        {
            get { return nombreDefinitions; }
            set { nombreDefinitions = value; }

        }
        public Dictionnaire(string langue, int nombreDefinitions, string titre, int numeroEnregistrement): base(numeroEnregistrement,titre)
        {
            this.langue =langue;
            this.nombreDefinitions = nombreDefinitions;
        }
        public override string Description()
        {
            return $"Dictionnaire [Numero : {NumeroEnregistrement}, Titre: {Titre} , Langue: {Langue} , Nombre de Definitions: {NombreDefinitions}]";
        }
    }
}
