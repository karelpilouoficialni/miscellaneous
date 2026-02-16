Console.WriteLine("----- Přestupný Rok -----");
bool ok = true;

while (ok)
{
    Console.Write("Zadejte rok nebo napište 'konec' pro ukončení: ");
    Console.ForegroundColor = ConsoleColor.Green;
    string vstup = Console.ReadLine();
    Console.ResetColor();

    if (vstup == "konec")
    {
        Console.WriteLine("Konec programu");
        // ok = false
        break;
    }

    if (!int.TryParse(vstup, out int rok))
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Zadali jste špatný vstup, opakujte akci.");
        Console.ResetColor();
        continue;
    }

    if (JePrestupny(rok))
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"Rok {rok} je přestupný.");
        Console.ResetColor();
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Rok {rok} není přestupný.");
        Console.ResetColor();
    }
}
 bool JePrestupny(int rok)
{
    return (rok % 4 == 0 && rok % 100 != 0) || (rok % 400 == 0);
}