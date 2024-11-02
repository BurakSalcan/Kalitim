using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BeyazEsya esya = new BeyazEsya();
            //esya.Isim = "Deneme";
            //esya.Marka = "Deneme";
            //esya.Fiyat = 50;



            CamasirMakinesi cm = new CamasirMakinesi();
            cm.Marka = "BOSCH";
            cm.ProgramSayisi = 3;
            cm.Kurutma = true;
            cm.Isim = "BO131";
            cm.Fiyat = 10000;

            BulasikMakinesi bm = new BulasikMakinesi();
            bm.Marka = "SIEMENS";
            bm.Isim = "SIE31";
            bm.Fiyat = 11000;
            bm.Kapasite = 300;
            bm.YogunYikama = true;
            bm.EnerjiSinifi = "A+++";

            List<BeyazEsya> esyalar = new List<BeyazEsya>();
            esyalar.Add(cm);
            esyalar.Add(bm);
            for (int i = 0; i < esyalar.Count; i++)
            {
                Console.WriteLine($"{esyalar[i].Marka} {esyalar[i].Isim} {esyalar[i].Fiyat}");
            }
            


        }
    }
}
