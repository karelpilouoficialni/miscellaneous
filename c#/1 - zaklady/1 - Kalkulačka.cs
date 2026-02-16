Console.WriteLine("----- Vítejte v Kalkulačce -----");

double cislo1, cislo2, cislo3;

Console.WriteLine("Zadejte první číslo: ");
bool ok1 = double.TryParse(Console.ReadLine(), out cislo1);
Console.WriteLine(cislo1);
Console.WriteLine(ok1);

Console.WriteLine("Zadejte druhé číslo: ");
double.TryParse(Console.ReadLine(), out cislo2);
Console.WriteLine(cislo2);


Console.WriteLine("Zadejte třetí číslo: ");
double.TryParse(Console.ReadLine(), out cislo3);
Console.WriteLine(cislo3);


double soucet =  cislo1 + cislo2 + cislo3;
double rozdil = cislo1 -  cislo2 -  cislo3;
double soucin = cislo1 * cislo2 * cislo3;
double podil = cislo1 / cislo2 / cislo3;

Console.WriteLine();
Console.WriteLine($"Součet: {soucet:0.00}");
Console.WriteLine($"Rozdíl: {rozdil:0.00}");
Console.WriteLine($"Součin: {soucin:0.00}");
Console.WriteLine($"Podíl: {podil:0.00}");

Console.WriteLine("\n Stiskněte libovolnou klávesu pro ukončení...");
Console.ReadKey();