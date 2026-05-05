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
        public string punkt = "A";

        public Lennuk(string nimi, int kiirus, double kütusekogus, double maxMaht)
        {
            Nimi = nimi;
            Kiirus = kiirus;
            Kütusekogus = kütusekogus;
            MaxMaht = maxMaht;
        }

        public void Lenda()
        {
            if (Kütusekogus > 0)
            {
                onOhus = true;

                if (punkt == "A")
                    punkt = "B";
                else if (punkt == "B")
                    punkt = "C";

                Console.WriteLine(Nimi + " võtab õhku.");
                Kütusekogus -= 10;

                if (Kütusekogus < 0)
                    Kütusekogus = 0;
            }
            else
            {
                Console.WriteLine(Nimi + " ei saa lennata, sest kütus on otsas.");
            }
        }

        public void Maandu()
        {
            onOhus = false;
            Console.WriteLine(Nimi + " maandub.");
        }

        public void Tanki(double kogus)
        {
            if (onOhus)
            {
                Console.WriteLine("Õhus ei saa tankida.");
            }
            else if (kogus <= 0)
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

        public string AnnaStaatus()
        {
            if (onOhus)
                return "õhus";
            else
                return "maandunud";
        }

        public abstract void Kirjeldus();
    }
}