/* Console.WriteLine("----- Průměr známek -----");
Console.WriteLine("Kolik známek budete zadávat?");
int.TryParse(Console.ReadLine(), out int pocetZnamek);

if (pocetZnamek <= 0)
{
    Console.WriteLine("Neplatný počet.");
    return;
}

int soucet = 0;
int pocetPlatnych = 0;

for (int i = 0; i < pocetZnamek; i++)
{
    Console.Write("Zadej známku: ");
    string vstup = Console.ReadLine();

    if (int.TryParse(vstup, out int znamka) && znamka >= 1 && znamka <= 5)
    {
        soucet += znamka;
        pocetPlatnych++;
    }
    else
    {
        Console.WriteLine("Známka musí být celé číslo od 1 do 5");
        i--;
    }
}

double prumer = (double)soucet / pocetPlatnych;
Console.WriteLine($"Průměr známek je: {prumer:0.00}");

*/

Console.WriteLine("----- Průměr známek -----");
int pocetZnamek;
for (; ; )
{
    Console.WriteLine("Kolik známek budete zadávat?");
    if (int.TryParse(Console.ReadLine(), out pocetZnamek) && pocetZnamek > 0)
        break;

    Console.WriteLine("Zadej platné kladné celé číslo");
}

int soucet = 0;

for (int i = 0; i < pocetZnamek; i++)
{
    int znamka;
    for (; ; ) 
    
    {
        Console.WriteLine($"Zadej Známku {i+1} : ");
    if (int.TryParse(Console.ReadLine(), out znamka) && znamka >= 1 && znamka <= 5)
        break;

    Console.WriteLine("Známka musí být celé číslo od 1 do 5");
}
soucet += znamka;

}
  
double prumer = (double)soucet / pocetZnamek;
Console.WriteLine($"Průměr známek je: {prumer:0.00}");