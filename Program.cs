using System;

class Program
{
    static void Main()
    {
        Asistent();
    }

    static void Asistent()
    {
        while (true)
        {
            Console.WriteLine("Ahoj, vitaj v mojom pocitacom Asistentovi. Zadaj funkciu, ktoru si prajes mat splnenu.");
            Console.Write("(Pre pomoc s vyhladanim prikazov zadaj 'help'): ");
            string prikaz = Console.ReadLine()?.ToLower();

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

    static void VykonajSum()
    {
        Console.Write("Napis cislo 1: ");
        if (!double.TryParse(Console.ReadLine(), out double cislo1))
        {
            Console.WriteLine("Neplatny vstup.");
            return;
        }

        Console.Write("Napis cislo 2: ");
        if (!double.TryParse(Console.ReadLine(), out double cislo2))
        {
            Console.WriteLine("Neplatny vstup.");
            return;
        }

        double vysledok = cislo1 + cislo2;
        Console.WriteLine("Vysledok scitania:"+cislo1+"+"+cislo2+"je:" +vysledok);
    }

    static void VykonajOdm()
    {
        Console.Write("Napis cislo: ");
        if (!double.TryParse(Console.ReadLine(), out double cislo))
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
            Console.WriteLine($"Odmocnina z cisla {cislo} je: {vysledok}");
        }
    }

    static void VykonajFind()
    {
        Console.Write("Napis vetu: ");
        string veta = Console.ReadLine() ?? "";
        Console.Write("Napis ake slovo chces najst: ");
        string slovo = Console.ReadLine() ?? "";

        int pozicia = veta.IndexOf(slovo);

        if (pozicia != -1)
        {
            Console.WriteLine("Hladany podretazec sa vo vete nachadza na pozicii"+pozicia + 1);
        }
        else
        {
            Console.WriteLine("Podretazec"+slovo+" sa vo vete nenachadza.");
        }
    }

    static void VykonajHelp()
    {
        Console.WriteLine("Podporovane prikazy:");
        Console.WriteLine("sum  - scitanie dvoch cisel");
        Console.WriteLine("odm  - druha odmocnina zo zadaneho cisla");
        Console.WriteLine("find - hladanie podretazca vo vete a vypis jeho pozicie");
        Console.WriteLine("rect - zapne mod merania obdlznika");
        Console.WriteLine("help - zobrazenie tohto zoznamu prikazov");
        Console.WriteLine("exit - ukoncenie programu");
    }

    static void VykonajRect()
    {
        Console.WriteLine("Vypisanim 2 stran vytvoris obdlznik.");

        Console.Write("Napis dlzku prvej strany: ");
        if (!double.TryParse(Console.ReadLine(), out double strana1) || strana1 <= 0)
        {
            Console.WriteLine("Neplatna strana obdlznika (musi byt cislo vacsie ako 0).");
            return;
        }

        Console.Write("Napis dlzku druhej strany: ");
        if (!double.TryParse(Console.ReadLine(), out double strana2) || strana2 <= 0)
        {
            Console.WriteLine("Neplatna strana obdlznika (musi byt cislo vacsie ako 0).");
            return;
        }

        Console.WriteLine("Mame obdlznik s rozmermi"+strana1+"x"+strana2);

        while (true)
        {
            Console.Write("Co potrebujes odmerat? (area / perimeter / diagonal / help / exit): ");
            string prikaz = Console.ReadLine()?.ToLower();

            if (prikaz == "exit")
            {
                Console.WriteLine("Funkcia obdlznika ukoncena.");
                break;
            }
            else if (prikaz == "area" || prikaz == "obsah")
            {
                double vysledok = VypocitajObsah(strana1, strana2);
                Console.WriteLine("Obsah obdlznika s rozmermi"+strana1+"x"+strana2+"je:" +vysledok);
            }
            else if (prikaz == "perimeter" || prikaz == "obvod")
            {
                double vysledok = VypocitajObvod(strana1, strana2);
                Console.WriteLine("Obvod obdlznika s rozmermi"+strana1+"x"+strana2+"je:" +vysledok);
            }
            else if (prikaz == "diagonal" || prikaz == "uhlopriecka")
            {
                double vysledok = VypocitajUhlopriecku(strana1, strana2);
                Console.WriteLine("Uhlopriecka obdlznika s rozmermi"+strana1+"x"+strana2+"je:" +vysledok);
            }
            else if (prikaz == "help")
            {
                Console.WriteLine("Podporovane prikazy pre obdlznik:");
                Console.WriteLine("area (obsah)       - vypocita obsah obdlznika");
                Console.WriteLine("perimeter (obvod)  - vypocita obvod obdlznika");
                Console.WriteLine("diagonal (uhlopriecka) - vypocita dĺžku uhlopriečky");
                Console.WriteLine("help               - zobrazi tuto pomoc");
                Console.WriteLine("exit               - opusti mod obdlznika");
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
}