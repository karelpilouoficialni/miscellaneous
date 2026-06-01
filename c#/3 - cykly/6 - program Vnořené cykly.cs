// 1. Zobrazení hlavičky textu
Console.WriteLine("------------ Vnořené cykly ------------");
int pocetRadku = 0;
bool platnyVstup = false;
// 2. a 6. Výzva a validace vstupu (kladné celé číslo)
while (!platnyVstup)
{
    Console.Write("Zadejte počet plusek pro obrazec: ");
    // Nastavení zelené barvy pro uživatelský vstup
    Console.ForegroundColor = ConsoleColor.Green;
    string vstup = Console.ReadLine();
    Console.ResetColor(); // Návrat k původní barvě
    if (int.TryParse(vstup, out pocetRadku) && pocetRadku > 0)
    {
        platnyVstup = true;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Chyba: Vstup musí být kladné celé číslo! Zkuste to znovu.");
        Console.ResetColor();
    }
}
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Magenta;
// --- 4a. Trojúhelník směrem dolů ---
Console.ResetColor();
Console.WriteLine("Trojúhelník směrem dolů:");
Console.ForegroundColor = ConsoleColor.Magenta;
for (int i = 1; i <= pocetRadku; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("+");
    }
    Console.WriteLine();
}
Console.WriteLine();
// --- 4b. Trojúhelník směrem nahoru ---
Console.ResetColor();
Console.WriteLine("Trojúhelník směrem nahoru:");
Console.ForegroundColor = ConsoleColor.Magenta;
for (int i = pocetRadku; i >= 1; i--)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("+");
    }
    Console.WriteLine();
}
Console.WriteLine();
// --- 4c. Diamantový vzor (kombinace obou) ---
Console.ResetColor();
Console.WriteLine("Diamantový vzor:");
Console.ForegroundColor = ConsoleColor.Magenta;
// Rostoucí část
for (int i = 1; i <= pocetRadku; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("+");
    }
    Console.WriteLine();
}
// Klesající část
for (int i = pocetRadku - 1; i >= 1; i--)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("+");
    }
    Console.WriteLine();
}
Console.ResetColor();
Console.WriteLine();
// --- BONUS: Celý diamantový vzor ---
Console.WriteLine("BONUS: Celý diamantový vzor:");
int bonusPocet = 0;
while (true)
{
    Console.Write("Zadejte nový počet plusek pro obrazec lichým číslem: ");
    Console.ForegroundColor = ConsoleColor.Green;
    string bonusVstup = Console.ReadLine();
    Console.ResetColor();
    if (int.TryParse(bonusVstup, out bonusPocet) && bonusPocet > 0)
    {
        if (bonusPocet % 2 != 0)
        {
            break; // Číslo je správné a liché
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Zadejte prosím liché číslo.");
            Console.ResetColor();
        }
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Chyba: Neplatný vstup.");
        Console.ResetColor();
    }
}
Console.ForegroundColor = ConsoleColor.Magenta;
int stred = bonusPocet / 2;
// Horní polovina diamantu včetně středu
for (int i = 0; i <= stred; i++)
{
    int pluska = 2 * i + 1;
    int mezery = stred - i;
    // Vykreslení mezer (původní barvou)
    Console.ResetColor();
    for (int j = 0; j < mezery; j++) Console.Write(" ");
    // Vykreslení plusek (fialovou)
    Console.ForegroundColor = ConsoleColor.Magenta;
    for (int j = 0; j < pluska; j++) Console.Write("+");
    Console.WriteLine();
}
// Spodní polovina diamantu
for (int i = stred - 1; i >= 0; i--)
{
    int pluska = 2 * i + 1;
    int mezery = stred - i;
    // Vykreslení mezer
    Console.ResetColor();
    for (int j = 0; j < mezery; j++) Console.Write(" ");
    // Vykreslení plusek
    Console.ForegroundColor = ConsoleColor.Magenta;
    for (int j = 0; j < pluska; j++) Console.Write("+");
    Console.WriteLine();
}
Console.ResetColor();
Console.WriteLine("\nUkončení programu...");
Console.ReadLine();