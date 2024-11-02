using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    internal class BulasikMakinesi : BeyazEsya
    {
        public BulasikMakinesi() { }
        public BulasikMakinesi(string Isim, string Marka, double Fiyat, string EnergiSinifi, int Kapasite, bool YogunYikama) 
            :base(Isim, Marka, Fiyat)
        { 
            this.EnerjiSinifi = EnergiSinifi;
            this.YogunYikama = YogunYikama;
            this.Kapasite = Kapasite;
        }


        public string EnerjiSinifi { get; set; }

        public bool YogunYikama { get; set; }

        public int Kapasite { get; set; }
    }
}
