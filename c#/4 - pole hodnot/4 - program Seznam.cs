Console.WriteLine("----- Oblíbené věci -----");
Console.Write("Zadej počet položek v seznamu: ");

int pocetPolozek = 0;
int.TryParse(Console.ReadLine(), out pocetPolozek);

string[] seznamOblibenychVeci = new string[pocetPolozek];

for (int i = 0; i < seznamOblibenychVeci.Length; i++)
{
    Console.Write($"Zadejte položku č. {i + 1}: ");
    seznamOblibenychVeci[i] = Console.ReadLine();

}

Console.Write("Váš seznam: ");
foreach (string polozka in seznamOblibenychVeci)
    Console.Write($"{polozka}, ");

Console.WriteLine("\b\b  ");

Console.WriteLine();

Console.WriteLine("Chces upravit seznam? (ano/ne)");
string rozhodnuti = Console.ReadLine();

if (rozhodnuti == "ano")
{
    Console.WriteLine("Zvol úpravu (prohození / změna): ");
    rozhodnuti = Console.ReadLine();

    if (rozhodnuti == "prohozeni")
    {
        Console.Write("Zadej první index: ");
        int.TryParse(Console.ReadLine(), out int index1);

        Console.Write("Zadej druhý index: ");
        int.TryParse(Console.ReadLine(), out int index2);

        (seznamOblibenychVeci[index1], seznamOblibenychVeci[index2]) = (seznamOblibenychVeci[index2], seznamOblibenychVeci[index1]);
    }

    if (rozhodnuti == "zmena")
    {
        Console.WriteLine("Zadej textovou hodnotu, kterou chcete změnit: ");
        string hledanaHodnota = Console.ReadLine();

        Console.WriteLine("Zadej novou textovou hodnotu: ");
        string novaHodnota = Console.ReadLine();

        for(int i = 0; i < seznamOblibenychVeci.Length; i++)
        {
            if (seznamOblibenychVeci[i] == hledanaHodnota)
            {
                seznamOblibenychVeci[i] = novaHodnota;
                break;
            }
        }
    }

    else
    {
        Console.WriteLine("takovou moznost neznam...");
    }

}

else
{
    return;
}


Console.Write("Váš seznam: ");
foreach (string polozka in seznamOblibenychVeci)
    Console.Write($"{polozka}, ");

Console.WriteLine("\b\b  ");