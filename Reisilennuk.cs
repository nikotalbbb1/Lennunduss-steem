using System;
using System.Collections.Generic;
using System.Text;

namespace Lennundussüsteem
{
    public class Reisilennuk : Lennuk
    {
        public int ReisijateArv { get; private set; }

        public Reisilennuk(string nimi, int kiirus, double kütusekogus, double maxMaht, int reisijateArv)
            : base(nimi, kiirus, kütusekogus, maxMaht)
        {
            ReisijateArv = reisijateArv;
        }

        public override void Kirjeldus()
        {
            Console.WriteLine("Reisilennuk: " + Nimi + ", kiirus: " + Kiirus + " km/h, reisijaid: " + ReisijateArv + "Punkt : ");
            TankiInfo();
        }
    }

}
