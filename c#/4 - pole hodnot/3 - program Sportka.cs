Console.WriteLine("----- Loterie -----");

int[] uzivatelskePole = new int[6];

Console.WriteLine("Zadejte čísla od 1 do 49 do loterie: ");

for(int i = 0; i < uzivatelskePole.Length; i++)
{
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out int cisloTip) && cisloTip >= 1 && cisloTip <= 49 && !uzivatelskePole.Contains(cisloTip))
        {
            uzivatelskePole[i] = cisloTip;
            break;
        }
        else
        {
            Console.Write("Neplatné číslo (Rozsah 1-49, nesmí se opakovat): ");
        }
    }
}
/*
 foreach (int vypisPole in uzivatelskePole)
Console.Write(vypis + " ");
*/

int[] losovanaCisla = new int[6];
Random generator = new Random();
Console.WriteLine("Losování Počítače: ");
for(int i = 0; i < losovanaCisla.Length; i++)
{
    while (true)
    {
        int cisloGenerovane = generator.Next(1, 50);

        if(!losovanaCisla.Contains(cisloGenerovane))
        {
            losovanaCisla[i] = cisloGenerovane;
            break;
        }
    }
    Console.Write(losovanaCisla[i] + " ");
}

int shodnaCisla = 0;

foreach(int porovnavaciCislo in uzivatelskePole)
{
    if (losovanaCisla.Contains(porovnavaciCislo))
    {
        shodnaCisla++;
    }
}

if (shodnaCisla >= 3)
    Console.WriteLine($"Uživatel uhodnul {shodnaCisla} čísel, vyhrává.");
else
    Console.WriteLine($"Uživatel uhodnul {shodnaCisla} čísel, prohrává");