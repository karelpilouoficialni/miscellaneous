Console.WriteLine("=== LABORATOŘ: MÍCHÁNÍ ROZTOKU ===");
Console.WriteLine("\nTvým úkolem je připravit přesně 250 ml roztoku.");
Console.WriteLine("Najednou můžeš přidat 1 až 100 ml.");
Console.WriteLine("Napiš 'stop', pokud chceš experiment ukončit.");
Console.WriteLine();

int cil = 250;
int aktualniObjem = 0;
int pocetKroku = 0;

while (true)
{
    Console.Write("Kolik ml chceš přidat? ");
    string vstup = Console.ReadLine();

    if (vstup.ToLower() == "stop")
    {
        Console.WriteLine("Experiment ukončen uživatelem.");
        break;
    }

    if (!int.TryParse(vstup, out int mnozstvi))
    {
        Console.WriteLine("Chyba: musíš zadat celé číslo!");
        continue;
    }

    if (mnozstvi <= 0)
    {
        Console.WriteLine("Chyba: musíš přidat alespoň 1 ml!");
        continue;
    }

    if (mnozstvi > 100)
    {
        Console.WriteLine("Chyba: najednou můžeš přidat maximálně 100 ml!");
        continue;
    }

    aktualniObjem += mnozstvi;
    pocetKroku++;

    if (aktualniObjem > cil)
    {
        Console.WriteLine("Překročil jsi 250 ml! Roztok je zkažen.");
        break;
    }

    if (aktualniObjem == cil)
    {
        Console.WriteLine("HOTOVO! Připravil jsi přesně 250 ml.");
        Console.WriteLine($"Počet kroků: {pocetKroku}");
        Console.WriteLine("");
        break;
    }

    Console.WriteLine($"Aktuální objem: {aktualniObjem} / 250 ml");
    Console.WriteLine();
}

Console.WriteLine("Děkuji za práci v laboratoři.");