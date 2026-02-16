Console.WriteLine("----- Prodej vstupenek do kina -----");

Console.WriteLine("Zadejte svůj věk:");
string vstupVek = Console.ReadLine();
int vek;

if (!int.TryParse(vstupVek, out vek) || vek < 0 || vek > 120)
{
    Console.WriteLine("Zadaný věk je neplatný.");
    return;
}

int cena = 0;

if (vek >= 0 && vek <= 5)
{
    cena = 0;
    Console.WriteLine("Cena jedné vstupenky je 0 Kč (0–5 let).");
}
else if (vek >= 6 && vek <= 14)
{
    cena = 60;
    Console.WriteLine("Cena jedné vstupenky je 60 Kč (6–14 let).");
}
else if (vek >= 15 && vek <= 18)
{
    cena = 90;
    Console.WriteLine("Cena jedné vstupenky je 90 Kč (15–18 let).");
}
else if (vek >= 19 && vek <= 64)
{
    cena = 120;
    Console.WriteLine("Cena jedné vstupenky je 120 Kč (19–64 let).");
}
else //65+
{
    cena = 80;
    Console.WriteLine("Cena jedné vstupenky je 80 Kč (65+ let).");
}

Console.WriteLine("Zadejte počet lístků: ");
string pocetListku = Console.ReadLine();
if (!int.TryParse(pocetListku, out int pocetKoupenychListku) || pocetKoupenychListku <= 0)
{
    Console.WriteLine("Neplatný počet lístků.");
    return;
}

double celkovaCena = cena * pocetKoupenychListku;

//zadani studentskeho prukazu
if(vek >= 15 && vek <= 26)
{
    Console.WriteLine("Máte studentský průkaz? (ano / ne)?");
    string studentskyPrukaz = Console.ReadLine().ToLower();

    if(studentskyPrukaz == "ano")
    {
        Console.WriteLine("Věk spadá do intervalu 15-26 let, bude uplatněna sleva 20 %");
        //celkovaCena = celkovaCena * 0,8;
        celkovaCena *= 0.8; // sleva 20%
    }
}

Console.WriteLine($"Konečná cena k úhradě je {celkovaCena} Kč");

/* Console.WriteLine("\nZadejte počet lístků:");
string vstupPocet = Console.ReadLine();
int pocet;

if (!int.TryParse(vstupPocet, out pocet) || pocet <= 0)
{
    Console.WriteLine("Neplatný počet lístků.");
    return;
}

int celkem = cena * pocet;
Console.WriteLine("Celková cena bez slevy: " + celkem + " Kč");

Console.WriteLine("\nMáte studentský průkaz (ano/ne)?");
string prukaz = Console.ReadLine();

if (vek >= 15 && vek <= 26 && prukaz == "ano")
{
    Console.WriteLine("Uplatňuje se sleva 20 %.");
    double sleva = celkem * 0.20;
    double konecnaCena = celkem - sleva;

    Console.WriteLine("Konečná cena po slevě: " + konecnaCena + "Kč");
}
*/