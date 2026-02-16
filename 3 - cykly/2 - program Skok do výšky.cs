Console.WriteLine("Program na výpočet skoku do výšky.");

double nejlepsiSkok = 0;
double aktualniSkok = 0;
int pocetSkoku = 0;

Console.Write("Zadej počet soutěžících: ");
int.TryParse(Console.ReadLine(), out int soutezici);

/*
 for(int i = 0; i < soutezici; i++)
{
    Console.Write($"Zadej skok {i + 1}. soutěžícího");
    double.TryParse(Console.ReadLine(), out aktualniSkok);

    if (aktualniSkok > nejlepsiSkok)
        nejlepsiSkok = aktualniSkok;
}

*/

while(soutezici > pocetSkoku)
{
    pocetSkoku += 1; //pocetSkoku++
    Console.Write($"Zadej skok {pocetSkoku}. soutěžícího");
    double.TryParse(Console.ReadLine(), out aktualniSkok);

    if (aktualniSkok > nejlepsiSkok)
        nejlepsiSkok = aktualniSkok;

}

Console.WriteLine($"Nejlepší skok je {nejlepsiSkok}");
