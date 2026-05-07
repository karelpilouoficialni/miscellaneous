while (true)
{
    Console.Write("Zadejte počet známek: ");
    int pocet;

    while(!int.TryParse(Console.ReadLine(), out pocet) || pocet <= 0)
    {
        Console.WriteLine("Neplatný vstup, zadejte číslo znovu: ");
    }

    int[] znamky = new int[pocet];

    for (int i = 0; i < pocet; i++)
    {
        Console.Write($"Zadejte známku č. {i + 1} (1-5): ");
        while (!int.TryParse(Console.ReadLine(), out znamky[i]) || znamky[i] < 1 || znamky[i] > 5)
        {
            Console.WriteLine($"Neplatná známka, Zadejte známku č. {i + 1} (1-5)");

        }
    }
    Console.WriteLine("\n----- Výsledky -----");
    Console.Write($"\nPrůměr: {znamky.Average()}");
    Console.Write($"\nNejlepší známka: {znamky.Min()}");
    Console.Write($"\nNejhorší známka: {znamky.Max()}");

    Console.Write("\nChcete zadat další pole známek? (ano/ne): ");
    string odpoved = Console.ReadLine().ToLower();

    if (odpoved != "ano")
        break;

    Console.Clear();

} 