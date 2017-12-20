using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restauracja_16_12_2017_Najnowsza
{
    class RodzajPlatnosci
    {
        private bool karta;
        private bool gotowka;
        public RodzajPlatnosci(bool karta, bool gotowka)
        {
            this.karta = karta;
            this.gotowka = gotowka;
        }
        public void MetodaPlatnosci()
        {
            if (karta) Console.WriteLine("DOKONUJE PLATNOSCI KARTA");
            else
            {
                Console.WriteLine("DOKONUJE PLATNOSCI GOTOWKA");
            }
        }


    }
}
