Console.WriteLine("=== HÁDEJ ČÍSLO ===");
Console.WriteLine("\nMyslím si číslo od 1 do 100.");
Console.WriteLine("Napiš 'konec', pokud chceš hru ukončit.");

Random random = new Random();
int hledaneCislo = random.Next(1, 101); // 1–100
int pocetPokusu = 0;

Console.WriteLine();

while (true)
{
    Console.Write("\nZadej svůj tip: ");
    string vstup = Console.ReadLine();

    if (vstup.ToLower() == "konec")
    {
        Console.WriteLine("Hra ukončena.");
        break;
    }

    if (!int.TryParse(vstup, out int tip))
    {
        Console.WriteLine("To není platné číslo! Zkus to znovu.");
        continue;
    }

    if (tip < 1 || tip > 100)
    {
        Console.WriteLine("Zadejte číslo v rozmezí 1 - 100");
        continue;
    }

    pocetPokusu++;

    if (tip < hledaneCislo)
    {
        Console.WriteLine("Moc malé.");
    }
    else if (tip > hledaneCislo)
    {
        Console.WriteLine("Moc velké.");
    }
    else
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Správně!");
        Console.ResetColor();

        Console.Write(" Uhodli jste číslo na ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write(pocetPokusu);
        Console.ResetColor();
        Console.WriteLine(" pokusů");

        Console.WriteLine("Děkuji za hru. <3");
        break;
    }
}
