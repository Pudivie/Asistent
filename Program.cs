    while (true)
    {
        Console.Write("Pre pomoc s vyhladanim prikazov zadaj 'help': ");
        string prikaz = Console.ReadLine();
        
        if (prikaz == "exit")
        {
            Console.WriteLine("Asistent ukonceny");
            break;
        }

        if (prikaz == "sum")
        {
            sum();
        }

        if (prikaz == "odm")
        {
            odm();
        }

        if (prikaz == "find")
        {
            find();
        }
        
        void sum()
            {
                Console.WriteLine("Napis cislo 1");
                int cislo1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Napis cislo 2");
                int cislo2 = Convert.ToInt32(Console.ReadLine());
                
                int vysledok = cislo1 + cislo2;
                Console.WriteLine($"Vysledok scitanie je {vysledok}");
                }

        void odm()
            {
                Console.WriteLine("Napis cislo ");
                int cislo = Convert.ToInt32(Console.ReadLine());
                
                if (cislo < 0)
                {
                    Console.WriteLine("Zaporne cislo sa neda odmocnit");
                }

                else
                {
                    double vysledok = Math.Sqrt(cislo);
                    Console.WriteLine($"Odmocnina z cisla {cislo} je: {vysledok}");
                }
            }

        void find()
        {
            Console.WriteLine("Napis vetu");
            string veta = Console.ReadLine();
            Console.WriteLine("Napis ake slovo chces najst");
            string slovo = Console.ReadLine();

            int pozicia = veta.IndexOf(slovo);

            if (pozicia != -1)
            {
                Console.WriteLine($"Hladany podretazec sa vo vete nachadza na pozicii {pozicia+1}.");
            }
            else
            {
                Console.WriteLine($"Podretazec '{slovo}' sa vo vete nenachadza.");
            }
        }

        void rect()
        {
            Console.WriteLine("Odmeraj obdlznik: ");
            Console.WriteLine("Napis dlzku prvej strany: ");
            int strana1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Napis dlzku druhej strany");
            int strana2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Co potrebujes odmerat?: ");
            void area()
            {
                
            }
        }
    } 
        
        