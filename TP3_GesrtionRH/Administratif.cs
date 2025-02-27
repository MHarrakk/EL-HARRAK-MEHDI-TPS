using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_GesrtionRH
{
    public class Administratif : Personnel
    {
        public Administratif(int bureau, double salaire, double prime, string code, string nom, string prenom) : base(bureau, salaire, prime, code, nom, prenom)
        {
        }
    }
}
