using System;
using System.Collections.Generic;
using System.Text;

namespace Lennundussüsteem
{
    public class Helikopter : Lennuk
    {
        public bool VajabMaandumisrada { get; private set; }

        public Helikopter(string nimi, int kiirus, double kütusekogus, double maxMaht, bool vajabMaandumisrada)
            : base(nimi, kiirus, kütusekogus, maxMaht)
        {
            VajabMaandumisrada = vajabMaandumisrada;
        }

        public override void Kirjeldus()
        {
            Console.WriteLine("Helikopter: " + Nimi + ", kiirus: " + Kiirus + " km/h, vajab maandumisrada: " + VajabMaandumisrada + ", staatus: " + AnnaStaatus() + ", punkt: " + punkt);
            TankiInfo();
        }
    }
}
