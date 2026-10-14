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

        if (prikaz == "rect")
        {
            rect();
        }

        if (prikaz == "help")
        {
            Console.WriteLine("Podporovane prikazy:");
            Console.WriteLine("sum  - scitanie dvoch celych cisel");
            Console.WriteLine("odm  - druha odmocnina zo zadaneho cisla");
            Console.WriteLine("find - hladanie podretazca vo vete a výpis jeho pozicie");
            Console.WriteLine("rect  - zapne mod merania obdlznika (dalsie funckie ak napises 'rect'");
            Console.WriteLine("help - zobrazenie tohto zoznamu prikazov");
            Console.WriteLine("exit - ukoncenie programu");
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
            Console.Write("Pre pomoc s vyhladanim prikazov zadaj 'help': ");
            string prikazRect = Console.ReadLine();

            if (prikazRect == "area")
            {
                area(strana1, strana2);
            }

            if (prikazRect == "obvod")
            {
                obvod(strana1, strana2);
            }

            if (prikazRect == "uhlopriecka")
            {
                uhlopriecka(strana1, strana2);
            }

            void area(int dlzka, int sirka)
            {
                int vypocetArei = dlzka * sirka;
                Console.WriteLine("Obsah obldznika je: " + vypocetArei + " .");
            }

            void obvod(int dlzka, int sirka)
            {
                int vypocetObvodu = (dlzka + sirka)*2;
                Console.WriteLine("Obvod obldznika je: " + vypocetObvodu + " .");
            }

            void uhlopriecka(int dlzka, int sirka)
            {
                double pytagorovaVeta = Math.Sqrt((sirka * sirka) * (dlzka * dlzka));
                Console.WriteLine("Uhlopriecka tohoto obdlznika je: "+pytagorovaVeta+" .");
            }
            
         }
        
        
        
           
        
        
    }
        
        