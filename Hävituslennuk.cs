using System;
using System.Collections.Generic;
using System.Text;

namespace Lennundussüsteem
{
    public class Hävituslennuk : Lennuk
    {
        public string Relv { get; private set; }

        public Hävituslennuk(string nimi, int kiirus, double kütusekogus, double maxMaht, string relv)
            : base(nimi, kiirus, kütusekogus, maxMaht)
        {
            Relv = relv;
        }

        public override void Kirjeldus()
        {
            Console.WriteLine("Hävituslennuk: " + Nimi + ", kiirus: " + Kiirus + " km/h, relv: " + Relv + ", staatus: " + AnnaStaatus() + ", punkt: " + punkt);
            TankiInfo();
        }
    }
}
