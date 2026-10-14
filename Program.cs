void asistent()
{
    while (true)
    {
        Console.WriteLine("Ahoj, vitaj v mojom pocitacom Asistentovi. Zadaj funkciu, ktoru si prajes mat splnenu.");
        Console.Write("(Pre pomoc s vyhladanim prikazov zadaj 'help'): ");
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
                Console.WriteLine($"Hladany podretazec sa vo vete nachadza na pozicii {pozicia + 1}.");
            }
            else
            {
                Console.WriteLine($"Podretazec '{slovo}' sa vo vete nenachadza.");
            }
        }
            void rect()
            {
                while (true)
                {
                Console.WriteLine("Vypisanim 2 stran vytvoris obdlznik.");
                Console.WriteLine("Napis dlzku prvej strany: ");
                int strana1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Napis dlzku druhej strany: ");
                int strana2 = Convert.ToInt32(Console.ReadLine());

                string pouzitiePrikazu = prikazRect();
                string prikazRect()
                {
                    Console.WriteLine("Co potrebujes odmerat?");
                    Console.Write("(Pre pomoc s vyhladanim prikazov zadaj 'help'): ");
                    string prikaz = Console.ReadLine();
                    return prikaz;
                }

                if (pouzitiePrikazu == "obsah")
                {
                    obsah(strana1, strana2);
                    prikazRect();
                }

                if (pouzitiePrikazu == "obvod")
                {
                    obvod(strana1, strana2);
                    prikazRect();
                }

                if (pouzitiePrikazu == "uhlopriecka")
                {
                    uhlopriecka(strana1, strana2);
                    prikazRect();
                }
                if (pouzitiePrikazu == "help")
                {
                    Console.WriteLine("Podporovane prikazy:");
                    Console.WriteLine("obsah - vypocita ti obsah zo zadanych stran obdlznika");
                    Console.WriteLine("obvod - vypocita ti obvod zo zadanych stran obdlznika");
                    Console.WriteLine("uhlopriecka - vypocita ti uhlopriecku zo zadanych stran obdlznika");
                    Console.WriteLine("help - zobrazenie tohto zoznamu prikazov");
                    Console.WriteLine("exit - ukoncenie funkcie rect");
                    prikazRect();
                }

                if (pouzitiePrikazu == "exit")
                {
                    Console.WriteLine("Funkcia obdlznika ukoncena.");
                    asistent();
                    break;
                }

                void obsah(int dlzka, int sirka)
                    {
                        int vypocetObsahu = dlzka * sirka;
                        Console.WriteLine("Obsah obldznika je: " + vypocetObsahu + " .");
                    }

                void obvod(int dlzka, int sirka)
                    {
                        int vypocetObvodu = (dlzka + sirka) * 2;
                        Console.WriteLine("Obvod obldznika je: " + vypocetObvodu + " .");
                    }

                void uhlopriecka(int dlzka, int sirka)
                    {
                        double pytagorovaVeta = Math.Sqrt((sirka * sirka) * (dlzka * dlzka));
                        Console.WriteLine("Uhlopriecka tohoto obdlznika je: " + pytagorovaVeta + " .");
                    }

                }
            }





        }
    }

asistent();
        
        