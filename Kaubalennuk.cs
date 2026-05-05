using System;
using System.Collections.Generic;
using System.Text;

namespace Lennundussüsteem
{
    public class Kaubalennuk : Lennuk
    {
        public double KaubaKaal { get; private set; }

        public Kaubalennuk(string nimi, int kiirus, double kütusekogus, double maxMaht, double kaubaKaal)
            : base(nimi, kiirus, kütusekogus, maxMaht)
        {
            KaubaKaal = kaubaKaal;
        }

        public override void Kirjeldus()
        {
            Console.WriteLine("Kaubalennuk: " + Nimi + ", kiirus: " + Kiirus + " km/h, kaup: " + KaubaKaal + " tonni");
            TankiInfo();
        }
    }
}
