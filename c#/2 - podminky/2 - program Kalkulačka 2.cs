Console.WriteLine("Program kalkulačka 2.0");

Console.Write("Vložte do programu první číslo: ");
double.TryParse(Console.ReadLine(), out double a);

Console.Write("Vložte do programu druhé číslo: ");
double.TryParse(Console.ReadLine(), out double b);

Console.Write("Vložte do programu třetí číslo: ");
double.TryParse(Console.ReadLine(), out double c);

Console.WriteLine();
Console.WriteLine("Zvolte si operaci, která má proběhnout:");
Console.WriteLine("1 - sčítání");
Console.WriteLine("2 - odčítání");
Console.WriteLine("3 - násobení");
Console.WriteLine("4 - dělení");

Console.Write("\nVaše volba: ");
string volba = Console.ReadLine();

double vysledek = 0;

if (volba == "1")
{
    vysledek = a + b + c;
}

else if (volba == "2")
{
    vysledek = a - b - c;
}

else if (volba == "3")
{
    vysledek = a * b * c;
}

else if (volba == "4")

{
    if (b == 0 || c == 0)
    {
        Console.WriteLine("Nulou nelze dělit!!!!!!!!!!!!!!!!!!!!!!!!!!!");
    }
    else
    {
        vysledek = a / b / c;
    }
}

else
{
    Console.WriteLine("Zadali jste nesprávnou volbu.");
}

Console.WriteLine($"Výsledek: {vysledek} ");