using System;
using System.Collections.Generic;
using System.Text;

namespace Lennundussüsteem
{
    public class Eralennuk : Lennuk
    {
        public string Omanik { get; private set; }

        public Eralennuk(string nimi, int kiirus, double kütusekogus, double maxMaht, string omanik)
            : base(nimi, kiirus, kütusekogus, maxMaht)
        {
            Omanik = omanik;
        }

        public override void Kirjeldus()
        {
            Console.WriteLine("Eralennuk: " + Nimi + ", kiirus: " + Kiirus + " km/h, omanik: " + Omanik);
            TankiInfo();
        }
    }
}
