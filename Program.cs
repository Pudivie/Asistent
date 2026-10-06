void sumarization()
{
    int cislo1 = 0;
    int cislo2 = 0;
    int vysledok = 0;

    void VypisVysledok(int vysledokNaVypisanie)
    {
        Console.WriteLine("Vysledok: "+vysledokNaVypisanie);
    }

    int NacitajCislo()
    {
        Console.Write("Zadaj cislo: ");
        int nacitaneCislo = int.Parse(Console.ReadLine());
        return nacitaneCislo;
    }

    Console.WriteLine("Toto je moja kalkulačka");

    cislo1 = NacitajCislo();
    cislo2 = NacitajCislo();
    vysledok = cislo1+cislo2;
    VypisVysledok(vysledok);
    
    Console.WriteLine("Pre ukoncenie programu napis 'exit':");
    Console.ReadLine();
    
    void exit()
    {
        string koniecProgramu = "";
        if (koniecProgramu != "exit")
        {
            Console.WriteLine("Pre ukoncenie programu napis 'exit':");
            Console.ReadLine();
        }
    }
    Console.WriteLine("Ukoncil si program.");
}

sumarization();