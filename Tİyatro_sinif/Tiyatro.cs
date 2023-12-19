using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tİyatro_sinif
{
    internal class Tiyatro
    {
       
        int oyunİd;
        string oyunAd;
        int oyunSure;
        string sahne;
        bool muzikal;
        double fiyat;
        DateTime tarihSaat;

        public int Oyunİd { get => oyunİd; set => oyunİd = value; }
        public string OyunAd { get => oyunAd; set => oyunAd = value; }
        public int OyunSure { get => oyunSure; set => oyunSure = value; }
        public string Sahne { get => sahne; set => sahne = value; }
        public bool Muzikal { get => muzikal; set => muzikal = value; }
        public double Fiyat { get => fiyat; set => fiyat = value; }
        public DateTime TarihSaat { get => tarihSaat; set => tarihSaat = value; }

        public Tiyatro(int oyunİd, string oyunAd, int oyunSure, string sahne, bool muzikal, double fiyat, DateTime tarihSaat)
        {
            this.oyunİd = oyunİd;
            this.oyunAd = oyunAd;
            this.oyunSure = oyunSure;
            this.sahne = sahne;
            this.muzikal = muzikal;
            this.fiyat = fiyat;
            this.tarihSaat = tarihSaat;
        }
    }
}
