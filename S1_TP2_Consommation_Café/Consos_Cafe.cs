using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Consommation_Café
{
    class Consos_Cafe
    {
        public int NoSemaine;
        public int ProgrammeurId;
        public int NbTasses;

        public Consos_Cafe(int noSemaine, int programmeurId, int nbTasses)
        {
            NoSemaine = noSemaine;
            ProgrammeurId = programmeurId;
            NbTasses = nbTasses;
        }

        public override string ToString()
        {
            return "Semaine " + NoSemaine + ", Programmeur " + ProgrammeurId + ", Tasses: " + NbTasses;
        }
    }
}
