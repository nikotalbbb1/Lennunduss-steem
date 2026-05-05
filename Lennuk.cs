using System;
using System.Collections.Generic;
using System.Text;

namespace Lennundussüsteem
{
    public abstract class Lennuk : ILendav
    {
        public string Nimi { get; private set; }
        public int Kiirus { get; private set; }
        public double Kütusekogus { get; private set; }
        public double MaxMaht { get; private set; }
        public bool onOhus = false;

        public Lennuk(string nimi, int kiirus, double kütusekogus, double maxMaht)
        {
            if (string.IsNullOrWhiteSpace(nimi))
                throw new ArgumentException("Nimi ei tohi olla tühi.");

            if (kiirus <= 0)
                throw new ArgumentException("Kiirus peab olema suurem kui 0.");

            if (kütusekogus < 0 || kütusekogus > maxMaht)
                throw new ArgumentException("Kütusekogus on vigane.");

            Nimi = nimi;
            Kiirus = kiirus;
            Kütusekogus = kütusekogus;
            MaxMaht = maxMaht;
        }

        public void Lenda()
        {
            onOhus = true;
            Console.WriteLine("Lennuk tõusis õhku.");
        }

        public void Maandu()
        {
            onOhus = false;
            Console.WriteLine("Lennuk maandus.");
        }
        public void Tanki(double kogus)
        {
            if (kogus <= 0)
            {
                Console.WriteLine("Kütuse kogus peab olema suurem kui 0.");
            }
            else if (Kütusekogus + kogus > MaxMaht)
            {
                Console.WriteLine("Nii palju kütust ei mahu paaki.");
            }
            else
            {
                Kütusekogus += kogus;
                Console.WriteLine(Nimi + " tangiti. Praegu on kütust: " + Kütusekogus);
            }
        }

        public void TankiInfo()
        {
            Console.WriteLine("Kütus: " + Kütusekogus + "/" + MaxMaht);
        }

        public abstract void Kirjeldus();
    }

}
