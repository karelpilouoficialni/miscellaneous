Console.Write("Zadej první číslo: ");
string inputA = Console.ReadLine();

Console.Write("Zadej druhé číslo: ");
string inputB = Console.ReadLine();

bool uspechA = int.TryParse(inputA, out int a);
bool uspechB = int.TryParse(inputB, out int b);

Console.WriteLine();
string zprava = (uspechA && uspechB) ? "Vstupy úspěšně převedeny na čísla." : "Chyba při převodu vstupů na čísla.";
Console.WriteLine(zprava);

Console.WriteLine("\nVýpis porovnávacích operátorů");
Console.WriteLine($"{a} == {b} : {a == b}");
Console.WriteLine($"{a} != {b} : {a != b}");
Console.WriteLine($"{a} > {b} : {a > b}");
Console.WriteLine($"{a} < {b} : {a < b}");
Console.WriteLine($"{a} >= {b} : {a >= b}");
Console.WriteLine($"{a} <= {b} : {a <= b}");

Console.WriteLine("\nLogické operátory");

bool vetsiNez10 = a > 10;
bool sude = a % 2 == 0;

Console.WriteLine($"{a} > 10 : {vetsiNez10}");
Console.WriteLine($"{a} je sudé : {sude}");
Console.WriteLine($"({a} > 10) && ({a} % 2 == 0) : {vetsiNez10 && sude}");
Console.WriteLine($"({a} > 10) || ({a} % 2 == 0) : {vetsiNez10 || sude}");
Console.WriteLine($"!({a} > 10) : {!vetsiNez10}");

Console.WriteLine("\nTernární operátor místo if");
string vysledek = (a > b) ? "První číslo je větší."
                : (a < b) ? "Druhé číslo je větší."
                : "Čísla jsou stejná.";
Console.WriteLine(vysledek);