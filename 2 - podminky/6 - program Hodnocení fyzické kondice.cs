Console.WriteLine("----- Hodnocení fyzické kondice -----");
Console.WriteLine("Zadejte svůj věk:");
string vstupVek = Console.ReadLine();
int vek;

if (!int.TryParse(vstupVek, out vek) || vek < 5 || vek > 100)
{
    Console.WriteLine("Zadaný věk je neplatný.");
    return;
}

string kategorie;

if (vek <= 12)
    kategorie = "Dětská kategorie";
else if (vek <= 18)
    kategorie = "Mládež";
else if (vek <= 50)
    kategorie = "Dospělí";
else
    kategorie = "Senioři";

Console.WriteLine($"Patříte do kategorie: {kategorie}");

Console.WriteLine("Zadejte svůj čas běhu na 100 m (v sekundách):");
string casInput = Console.ReadLine();
double cas;

if (!double.TryParse(casInput, out cas) || cas <= 0)
{
    Console.WriteLine("Chyba: čas musí být kladné číslo.");
    return;
}

string kondice;

if (cas <= 14)
    kondice = "Výborná kondice";
else if (cas <= 18)
    kondice = "Dobrá kondice";
else if (cas <= 25)
    kondice = "Průměrná kondice";
else
    kondice = "Slabá kondice";

Console.WriteLine($"Výsledek: {kondice}");