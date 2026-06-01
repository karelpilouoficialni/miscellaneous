
        Console.WriteLine("Vítejte v programu ruleta");

        int kredit;

        // Zadání počátečního kreditu
        while (true)
        {
            Console.Write("Vložte kredit: ");

            if (int.TryParse(Console.ReadLine(), out kredit) && kredit >= 0)
            {
                break;
            }

            Console.WriteLine("Neplatný vstup. Zadejte kladné číslo.");
        }

        Random rnd = new Random();
        bool hrat = true;

        while (hrat)
        {
            Console.WriteLine($"Stav vašeho kreditu je: {kredit}");

            // Pokud není kredit
            if (kredit <= 0)
            {
                Console.Write("Nedostatečný kredit, chcete vložit další? (ano/ne) ");
                string odpoved = Console.ReadLine().ToLower();

                if (odpoved == "ne")
                {
                    break;
                }

                while (true)
                {
                    Console.Write("Vložte kredit: ");

                    if (int.TryParse(Console.ReadLine(), out int novyKredit) &&
                        novyKredit > 0)
                    {
                        kredit = novyKredit;
                        break;
                    }

                    Console.WriteLine("Neplatný vstup.");
                }

                Console.WriteLine($"Stav vašeho kreditu je: {kredit}");
            }

            // Zadání sázky
            int sazka;

            while (true)
            {
                Console.Write("Kolik chcete vsadit: ");

                if (!int.TryParse(Console.ReadLine(), out sazka) || sazka <= 0)
                {
                    Console.WriteLine("Neplatná sázka.");
                    continue;
                }

                if (sazka > kredit)
                {
                    Console.WriteLine("Nedostatečný zůstatek kreditu. Chcete vložit další? (ano/ne)");
                    string odpoved = Console.ReadLine().ToLower();

                    if (odpoved == "ano")
                    {
                        while (true)
                        {
                            Console.Write("Vložte kredit: ");

                            if (int.TryParse(Console.ReadLine(), out int dalsiKredit) &&
                                dalsiKredit > 0)
                            {
                                kredit += dalsiKredit;
                                break;
                            }

                            Console.WriteLine("Neplatný vstup.");
                        }
                    }

                    Console.WriteLine("Vsaďte nižší částku nebo rovno vašemu kreditu:");
                    continue;
                }

                break;
            }

            // Zadání čísla
            int cislo;

            while (true)
            {
                Console.Write("Uveďte číslo, které chcete vsadit (0-36): ");

                if (int.TryParse(Console.ReadLine(), out cislo) &&
                    cislo >= 0 &&
                    cislo <= 36)
                {
                    break;
                }

                Console.WriteLine("Číslo musí být v rozsahu 0-36.");
            }

            // Animace
            Console.WriteLine();
            Console.Write("Hod kuličkou");

            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                Console.Write(".");
            }

            Console.WriteLine("\n");

            // Losování čísla
            int losovaneCislo = rnd.Next(0, 37);

            Console.WriteLine($"Losované číslo je {losovaneCislo}");

            // Vyhodnocení
            if (cislo == losovaneCislo)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Gratuluji, vyhrál jsi!");
                Console.ResetColor();

                kredit -= sazka;
                kredit += sazka * 36;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Bohužel prohrál jsi!");
                Console.ResetColor();

                kredit -= sazka;
            }

            Console.WriteLine($"Stav vašeho kreditu je: {kredit}");

            // Další hra
            Console.Write("Chcete hrát znovu? (ano/ne) ");
            string znovu = Console.ReadLine().ToLower();

            if (znovu == "ne")
            {
                hrat = false;
            }

            Console.WriteLine();
        }

        Console.WriteLine($"Stav vašeho koncového kreditu je {kredit}");
        Console.WriteLine("====== Konec programu =======");