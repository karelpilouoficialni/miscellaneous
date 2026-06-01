// =================================================================
// 1. ČÁST: Obdélník z plusek podle zadaných rozměrů
// =================================================================
Console.WriteLine("--- 1. ČÁST ---");
Console.Write("Zadejte počet řádků: ");
Console.ForegroundColor = ConsoleColor.Green;
int radky1 = int.Parse(Console.ReadLine());
Console.ResetColor();
Console.Write("Zadejte počet sloupců: ");
Console.ForegroundColor = ConsoleColor.Green;
int sloupce1 = int.Parse(Console.ReadLine());
Console.ResetColor();
Console.WriteLine();
// Vykreslení obrazce (oranžová barva)
Console.ForegroundColor = ConsoleColor.DarkYellow;
for (int r = 0; r < radky1; r++)
{
    for (int s = 0; s < sloupce1; s++)
    {
        Console.Write("+");
    }
    Console.WriteLine();
}
Console.ResetColor();
Console.WriteLine("\n-----------------------------------\n");
// =================================================================
// 2. ČÁST: Matice 10x10 s křížem z teček na zvolené pozici
// =================================================================
Console.WriteLine("--- 2. ČÁST ---");
// Poznámka: Uživatel zadává pozice (číslováno pravděpodobně od 1 do 10)
Console.Write("Zadejte číslo řádku: ");
Console.ForegroundColor = ConsoleColor.Green;
int zvolenyRadek = int.Parse(Console.ReadLine());
Console.ResetColor();
Console.Write("Zadejte číslo sloupce: ");
Console.ForegroundColor = ConsoleColor.Green;
int zvolenySloupec = int.Parse(Console.ReadLine());
Console.ResetColor();
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkYellow;
for (int r = 1; r <= 10; r++)
{
    for (int s = 1; s <= 10; s++)
    {
        // Pokud jsme na zvoleném řádku NEBO zvoleném sloupci, napíšeme tečku
        if (r == zvolenyRadek || s == zvolenySloupec)
        {
            Console.Write(". ");
        }
        else
        {
            Console.Write("x ");
        }
    }
    Console.WriteLine();
}
Console.ResetColor();
Console.WriteLine("\n-----------------------------------\n");
// =================================================================
// 3. ČÁST: Algoritmické obrazce o velikosti 11x11
// =================================================================
Console.WriteLine("--- 3. ČÁST (Obrazce 11x11) ---");
int n = 11;
// --- Obrazec A: Hlavní diagonála ---
Console.WriteLine("\nObrazec 1: Hlavní diagonála");
Console.ForegroundColor = ConsoleColor.DarkYellow;
for (int r = 0; r < n; r++)
{
    for (int s = 0; s < n; s++)
    {
        Console.Write(r == s ? "x " : ". ");
    }
    Console.WriteLine();
}
Console.ResetColor();
// --- Obrazec B: Střídavé řádky ---
Console.WriteLine("\nObrazec 2: Střídavé řádky (x / .)");
Console.ForegroundColor = ConsoleColor.DarkYellow;
for (int r = 0; r < n; r++)
{
    for (int s = 0; s < n; s++)
    {
        Console.Write(r % 2 == 0 ? "x " : ". ");
    }
    Console.WriteLine();
}
Console.ResetColor();
// --- Obrazec C: Šachovnice ---
Console.WriteLine("\nObrazec 3: Šachovnice");
Console.ForegroundColor = ConsoleColor.DarkYellow;
for (int r = 0; r < n; r++)
{
    for (int s = 0; s < n; s++)
    {
        Console.Write((r + s) % 2 == 0 ? "x " : ". ");
    }
    Console.WriteLine();
}
Console.ResetColor();
// --- Obrazec D: Okraj a vnitřní šachovnice ---
Console.WriteLine("\nObrazec 4: Ohraničení s šachovnicí uvnitř");
Console.ForegroundColor = ConsoleColor.DarkYellow;
for (int r = 0; r < n; r++)
{
    for (int s = 0; s < n; s++)
    {
        // Pokud jsme na jakémkoliv okraji, vykreslíme 'x'
        if (r == 0 || r == n - 1 || s == 0 || s == n - 1)
        {
            Console.Write("x ");
        }
        else
        {
            Console.Write((r + s) % 2 == 0 ? "x " : ". ");
        }
    }
    Console.WriteLine();
}
Console.ResetColor();
// --- Obrazec E: Trojúhelník pod vedlejší diagonálou ---
Console.WriteLine("\nObrazec 5: Trojúhelník vlevo dole");
Console.ForegroundColor = ConsoleColor.DarkYellow;
for (int r = 0; r < n; r++)
{
    for (int s = 0; s < n; s++)
    {
        Console.Write(s <= r ? "x " : ". ");
    }
    Console.WriteLine();
}
Console.ResetColor();
// --- Obrazec F: Svislé pruhy oddělené mezerou ---
Console.WriteLine("\nObrazec 6: Svislé pruhy s mezerami uprostřed");
Console.ForegroundColor = ConsoleColor.DarkYellow;
for (int r = 0; r < n; r++)
{
    for (int s = 0; s < n; s++)
    {
        // Vykreslí křížky na krajích (první 4 a poslední 4 sloupce)
        // Sloupce indexované jako 4 a 5 (prostředek matice 11x11) zůstanou jako tečky
        if (s < 4 || s > 6)
        {
            Console.Write("x ");
        }
        else
        {
            Console.Write(". ");
        }
    }
    Console.WriteLine();
}
Console.ResetColor();
Console.WriteLine("\nProgram úspěšně dokončen. Stiskněte Enter pro ukončení...");
Console.ReadLine();