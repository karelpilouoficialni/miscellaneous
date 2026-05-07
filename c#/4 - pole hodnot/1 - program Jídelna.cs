/*
 int[] objednavky = new int[5];

Console.Write("Přehled objednaných dnů: ");
for (int i = 0; i < objednavky.Length; i++)
{
    Console.Write(objednavky[i] + " ");
}
Console.WriteLine();

while (true)
{
    Console.WriteLine();
    Console.Write("Který den si přejete objednat (1-5): ");

    int den = int.Parse(Console.ReadLine());

    if (den < 1 || den > 5)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nNeplatný den, zkus to znovu.");
        Console.ResetColor();
        continue;
    }

    objednavky[den - 1] = 1;

    Console.Write("Máte objednano na: ");
    for (int i = 0; i < objednavky.Length; i++)
    {
        Console.Write(objednavky[i] + " ");
    }

    Console.WriteLine();
    Console.Write("\nChcete objednat dalsi den (0 = NE,1 = ANO)? ");
    int pokracovat = int.Parse(Console.ReadLine());

    if (pokracovat < 0 || pokracovat > 1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nNeplatný výběr, zkus to znovu.");
        Console.ResetColor();
        continue;
    }

    else if (pokracovat == 0)
        break;
}

*/

Console.Write("Přehled objednaných dnů: ");
int[] poleHodnot = new int[5];

for(int i = 0; i < poleHodnot.Length; i++)
{
    // Console.Write($"{poleHodnot[i]} ");
    if (poleHodnot[i] == 0)
        Console.Write("[ ]");
}

bool opakovani = true;
while(opakovani)
{
    Console.Write($"\nKterý den si přejete objednat?: ");
    int.TryParse(Console.ReadLine(), out int den);

    if (den >= 1 || den <= 5)
    {
        poleHodnot[den - 1] = 1;

    for (int i = 0; i < poleHodnot.Length; i++)
        {
            // Console.Write($"{poleHodnot[i]} ");
            if (poleHodnot[i] == 0)
                Console.Write("[ ]");
            else
                Console.Write("[X]");
        }

    }

    else
    {
        Console.WriteLine("Neplatný den.");
        continue;
    }

    while(true)
    {
        Console.Write("\nChcete objednat další den? (0 = NE; 1 = ANO): ");
        int.TryParse(Console.ReadLine(), out int pokracovani);

        if (pokracovani == 0) 
        {
            opakovani = false;
            break;
        } 
        else if (pokracovani == 1)
        {
            break;
        }

        else
            Console.WriteLine("Neplatná hodnota.");
    }
}