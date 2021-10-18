using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipiobjektnoorijentiranogprogramiranjaZadatak2
{
    class Zrakoplov
    {
        private string Naziv;
        private double SnagaMotora;
        private int DosegLeta;
        public Zrakoplov(string naziv, double snaga, int doseg)
        {
            Naziv = naziv;
            SnagaMotora = snaga;
            DosegLeta = doseg;
        }
    }
}
