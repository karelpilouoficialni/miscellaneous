Console.WriteLine("--- Vítejte v převodníku teplot ---\r\n");
Console.WriteLine("Zadejte teplotu ve stupních Celsia: ");

// pokus o prevod vstupu na cislo
bool prevod = double.TryParse(Console.ReadLine(), out double teplotaC);

// ternarni operator: pokud je vstup platny, vypocita a zobrazi prevod
// jinak vypise chybovou hlasku

string vysledek = prevod ?
    $"Teplota ve Fahrenheitech: {teplotaC * 1.8 + 32:N2} \nTeplota v Kelvinech: {teplotaC + 273.15:N2}"
    : "Neplatný vstup: Zadejte prosím číslo.";

Console.WriteLine();
Console.WriteLine(vysledek);

Console.WriteLine("\nStiskněte libovolnou klávesu pro ukončení...");
Console.ReadKey();