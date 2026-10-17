Asistent();
    static void Asistent()
    {
        while (true)
        {
            Console.WriteLine("Ahoj, vitaj v mojom pocitacom Asistentovi. Zadaj funkciu, ktoru si prajes mat splnenu.");
            Console.Write("(Pre pomoc s vyhladanim prikazov zadaj 'help'): ");
            string prikaz = Console.ReadLine();
            prikaz = prikaz.ToLower();

            if (prikaz == "exit")
            {
                Console.WriteLine("Asistent ukonceny.");
                break;
            }
            else if (prikaz == "sum")
            {
                VykonajSum();
            }
            else if (prikaz == "odm")
            {
                VykonajOdm();
            }
            else if (prikaz == "find")
            {
                VykonajFind();
            }
            else if (prikaz == "rect")
            {
                VykonajRect();
            }
            else if (prikaz == "array")
            {
                VykonajArray();
            }
            else if (prikaz == "help")
            {
                VykonajHelp();
            }
            else
            {
                Console.WriteLine("Neznamy prikaz. Zadaj 'help' pre zoznam prikazov.");
            }
        }
    }

    // faza 1
    // extremny rework, chcel som to sprehladnit ako si nam na hodinach spominal

    static void VykonajSum()
    {
        Console.Write("Napis cislo 1: ");
        string text1 = Console.ReadLine();
        if (!double.TryParse(text1, out double cislo1))
        {
            Console.WriteLine("Neplatny vstup.");
            return;
        }

        Console.Write("Napis cislo 2: ");
        string text2 = Console.ReadLine();
        if (!double.TryParse(text2, out double cislo2))
        {
            Console.WriteLine("Neplatny vstup.");
            return;
        }

        double vysledok = cislo1 + cislo2;
        Console.WriteLine("Vysledok scitania " + cislo1 + " + " + cislo2 + " je: " + vysledok);
    }

    static void VykonajOdm()
    {
        Console.Write("Napis cislo: ");
        string text = Console.ReadLine();
        if (!double.TryParse(text, out double cislo))
        {
            Console.WriteLine("Neplatny vstup.");
            return;
        }

        if (cislo < 0)
        {
            Console.WriteLine("Zaporne cislo sa neda odmocnit.");
        }
        else
        {
            double vysledok = Math.Sqrt(cislo);
            Console.WriteLine("Odmocnina z cisla " + cislo + " je: " + vysledok);
        }
    }

    static void VykonajFind()
    {
        Console.Write("Napis vetu: ");
        string veta = Console.ReadLine();
        Console.Write("Napis ake slovo chces najst: ");
        string slovo = Console.ReadLine();

        int pozicia = veta.IndexOf(slovo);

        if (pozicia != -1)
        {
            int cisloPozicie = pozicia + 1;
            Console.WriteLine("Hladany podretazec sa vo vete nachadza na pozicii " + cisloPozicie + ".");
        }
        else
        {
            Console.WriteLine("Podretazec '" + slovo + "' sa vo vete nenachadza.");
        }
    }

    static void VykonajHelp()
    {
        Console.WriteLine("\nPodporovane prikazy:");
        Console.WriteLine("sum   - scitanie dvoch cisel");
        Console.WriteLine("odm   - druha odmocnina zo zadaneho cisla");
        Console.WriteLine("find  - hladanie podretazca vo vete a vypis jeho pozicie");
        Console.WriteLine("rect  - zapne mod merania obdlznika");
        Console.WriteLine("array - zapne mod prace s ciselnym polom");
        Console.WriteLine("help  - zobrazenie tohto zoznamu prikazov");
        Console.WriteLine("exit  - ukoncenie programu");
    }

    // faza 2

    static void VykonajRect()
    {
        Console.WriteLine("\nVypisanim 2 stran vytvoris obdlznik.");

        Console.Write("Napis dlzku prvej strany: ");
        string textStrana1 = Console.ReadLine();
        if (!double.TryParse(textStrana1, out double strana1) || strana1 <= 0)
        {
            Console.WriteLine("Neplatna strana obdlznika (musi byt cislo vacsie ako 0).");
            return;
        }

        Console.Write("Napis dlzku druhej strany: ");
        string textStrana2 = Console.ReadLine();
        if (!double.TryParse(textStrana2, out double strana2) || strana2 <= 0)
        {
            Console.WriteLine("Neplatna strana obdlznika (musi byt cislo vacsie ako 0).");
            return;
        }

        Console.WriteLine("Mame obdlznik s rozmermi " + strana1 + " x " + strana2 + ".");

        while (true)
        {
            Console.Write("\nCo potrebujes odmerat? (area / perimeter / diagonal / help / exit): ");
            string prikaz = Console.ReadLine();
            prikaz = prikaz.ToLower();

            if (prikaz == "exit")
            {
                Console.WriteLine("Funkcia obdlznika ukoncena.");
                break;
            }
            else if (prikaz == "area" || prikaz == "obsah")
            {
                double vysledok = VypocitajObsah(strana1, strana2);
                Console.WriteLine("Obsah obdlznika s rozmermi " + strana1 + "x" + strana2 + " je: " + vysledok);
            }
            else if (prikaz == "perimeter" || prikaz == "obvod")
            {
                double vysledok = VypocitajObvod(strana1, strana2);
                Console.WriteLine("Obvod obdlznika s rozmermi " + strana1 + "x" + strana2 + " je: " + vysledok);
            }
            else if (prikaz == "diagonal" || prikaz == "uhlopriecka")
            {
                double vysledok = VypocitajUhlopriecku(strana1, strana2);
                Console.WriteLine("Uhlopriecka obdlznika s rozmermi " + strana1 + "x" + strana2 + " je: " + vysledok);
            }
            else if (prikaz == "help")
            {
                Console.WriteLine("Podporovane prikazy pre obdlznik:");
                Console.WriteLine("area (obsah)           - vypocita obsah obdlznika");
                Console.WriteLine("perimeter (obvod)      - vypocita obvod obdlznika");
                Console.WriteLine("diagonal (uhlopriecka) - vypocita dlzku uhlopriecky");
                Console.WriteLine("help                   - zobrazi tuto pomoc");
                Console.WriteLine("exit                   - opusti mod obdlznika");
            }
            else
            {
                Console.WriteLine("Neznamy prikaz v mode rect. Zadaj 'help'.");
            }
        }
    }

    static double VypocitajObsah(double dlzka, double sirka)
    {
        return dlzka * sirka;
    }

    static double VypocitajObvod(double dlzka, double sirka)
    {
        return 2 * (dlzka + sirka);
    }

    static double VypocitajUhlopriecku(double dlzka, double sirka)
    {
        return Math.Sqrt(dlzka * dlzka + sirka * sirka);
    }

    // faza 3

    static void VykonajArray()
    {
        Console.WriteLine("Zadaj ciselne pole (cisla oddelene medzerou):");
        Console.Write("> ");
        string vstup = Console.ReadLine();

        string[] casti = vstup.Split(' ');

        if (casti.Length == 0)
        {
            Console.WriteLine("Zadal si prazdne pole.");
            return;
        }

        int[] pole = new int[casti.Length];
        for (int i = 0; i < casti.Length; i++)
        {
            if (!int.TryParse(casti[i], out pole[i]))
            {
                Console.WriteLine("Chyba: '" + casti[i] + "' nie je platne cele cislo.");
                return;
            }
        }

        while (true)
        {
            Console.Write("\nCo chces urobit? (find / min / sort / help / exit): ");
            string prikaz = Console.ReadLine();
            prikaz = prikaz.ToLower();

            if (prikaz == "exit")
            {
                Console.WriteLine("Mod prace s polom ukonceny.");
                break;
            }
            else if (prikaz == "find")
            {
                Console.Write("Ake cislo chces najst?> ");
                string textHladane = Console.ReadLine();
                if (int.TryParse(textHladane, out int hladaneCislo))
                {
                    NajdiVPoli(pole, hladaneCislo);
                }
                else
                {
                    Console.WriteLine("Neplatne cislo.");
                }
            }
            else if (prikaz == "min")
            {
                int minHodnota = NajdiMin(pole);
                Console.WriteLine("Najmensia hodnota v poli je: " + minHodnota);
            }
            else if (prikaz == "sort")
            {
                ZoradPole(pole);
                string zoznamPola = string.Join(" ", pole);
                Console.WriteLine("Zoradil som pre teba pole. Teraz vypada takto: " + zoznamPola);
            }
            else if (prikaz == "help")
            {
                Console.WriteLine("Podporovane prikazy pre pole:");
                Console.WriteLine("find - najde zadanu hodnotu v poli a vypise jej poziciu");
                Console.WriteLine("min  - najde najmensiu hodnotu v poli");
                Console.WriteLine("sort - zoradi pole od najmensej po najvacsiu hodnotu");
                Console.WriteLine("help - zobrazi tuto pomoc");
                Console.WriteLine("exit - opusti mod pola");
            }
            else
            {
                Console.WriteLine("Neznamy prikaz v mode array. Zadaj 'help'.");
            }
        }
    }

    static void NajdiVPoli(int[] pole, int cislo)
    {
        int index = -1;
        for (int i = 0; i < pole.Length; i++)
        {
            if (pole[i] == cislo)
            {
                index = i;
                break;
            }
        }

        if (index != -1)
        {
            int pozicia = index + 1;
            Console.WriteLine("Hodnota " + cislo + " sa v poli nachadza na pozicii " + pozicia + ".");
        }
        else
        {
            Console.WriteLine("Hodnota " + cislo + " sa v poli nenachadza.");
        }
    }

    static int NajdiMin(int[] pole)
    {
        int min = pole[0];
        for (int i = 1; i < pole.Length; i++)
        {
            if (pole[i] < min)
            {
                min = pole[i];
            }
        }

        return min;
    }

    static void ZoradPole(int[] pole)
    {
        Array.Sort(pole);
    }