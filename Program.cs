using Lennundussüsteem;

class Program
{
    static void Main()
    {
        List<Lennuk> lennukid = new List<Lennuk>();

        lennukid.Add(new Reisilennuk("Boeing 737", 850, 300, 500, 180));
        lennukid.Add(new Kaubalennuk("Airbus Beluga", 780, 400, 700, 47));
        lennukid.Add(new Hävituslennuk("F-16", 1500, 250, 400, "raketid"));
        lennukid.Add(new Eralennuk("Cessna Citation", 700, 150, 250, "eraomanik"));
        lennukid.Add(new Helikopter("Robinson R44", 240, 80, 120, false));

        bool töötab = true;

        while (töötab)
        {
            Console.WriteLine();
            Console.WriteLine("=== LENNUNDUSSÜSTEEM ===");
            Console.WriteLine("1. Kuva kõik lennukid");
            Console.WriteLine("2. Lenda");
            Console.WriteLine("3. Maandu");
            Console.WriteLine("4. Tangi lennukit");
            Console.WriteLine("5. Välju");
            Console.Write("Vali tegevus: ");

            string valik = Console.ReadLine();

            switch (valik)
            {
                case "1":
                    KuvaKõik(lennukid);
                    break;
                case "2":
                    ValiLennuk(lennukid)?.Lenda();
                    break;
                case "3":
                    ValiLennuk(lennukid)?.Maandu();
                    break;
                case "4":
                    Lennuk valitud = ValiLennuk(lennukid);
                    if (valitud != null)
                    {
                        Console.Write("Sisesta kütuse kogus: ");
                        if (double.TryParse(Console.ReadLine(), out double kogus))
                        {
                            valitud.Tanki(kogus);
                        }
                        else
                        {
                            Console.WriteLine("Palun sisesta number.");
                        }
                    }
                    break;
                case "5":
                    töötab = false;
                    Console.WriteLine("Programm lõpetas töö.");
                    break;
                default:
                    Console.WriteLine("Vale valik.");
                    break;
            }
        }
    }

    static void KuvaKõik(List<Lennuk> lennukid)
    {
        for (int i = 0; i < lennukid.Count; i++)
        {
            Console.Write((i + 1) + ". ");
            lennukid[i].Kirjeldus();
        }
    }

    static Lennuk ValiLennuk(List<Lennuk> lennukid)
    {
        KuvaKõik(lennukid);
        Console.Write("Vali lennuki number: ");

        if (int.TryParse(Console.ReadLine(), out int number))
        {
            if (number >= 1 && number <= lennukid.Count)
            {
                return lennukid[number - 1];
            }
        }

        Console.WriteLine("Vale number.");
        return null;
    }
}