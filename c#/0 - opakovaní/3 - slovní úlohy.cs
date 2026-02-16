//---------------------------- 1. program -----------------------------

Console.WriteLine("Koberec má tvar čtverce, jeho strana je dlouhá 3,5 m.");
Console.WriteLine("1 m lemovky stojí 35 Kč. Kolik zaplatíme za lemovku?");

double strana = 3.5;
double cenaLemovky = 35;
double obvod = 4 * strana;
double cenaCelkem = obvod * cenaLemovky;

Console.WriteLine("$ " + Math.Round(cenaCelkem, 2) + " Kč");
Console.WriteLine();

//---------------------------- 2. program -----------------------------

Console.WriteLine("Plot obdélníkového pozemku je třikrát ovinut ostnatým drátem.");
Console.WriteLine("Pozemek je 94 m dlouhý a 45,5 m široký. Cena 1 m drátu je 12,50 Kč.");

double delka = 94;
double sirka = 45.5;
double cenaDratu = 12.5;

double obvodPozemku = 2 * (delka + sirka);
double celkovaDelkaDratu = obvodPozemku * 3;
double cenaDratuCelkem = celkovaDelkaDratu * cenaDratu;

Console.WriteLine("$ " + Math.Round(cenaDratuCelkem, 2) + " Kč");
Console.WriteLine();


//---------------------------- 3. program -----------------------------

Console.WriteLine("Kolik metrů kraječky potřebujeme na olemování 4 kusů");
Console.WriteLine("kruhového prostírání s průměrem 20 cm?");

Console.Write("Zadejte průměr v cm: ");
bool ok = double.TryParse(Console.ReadLine(), out double prumerCm);

double polomerM = prumerCm / 2 / 100;
double obvodKruhu = 2 * Math.PI * polomerM;
double vysledek = obvodKruhu * 4;

Console.WriteLine(ok
            ? "$ " + Math.Round(vysledek, 2) + " m"
            : "$ Neplatný vstup"
        );

Console.ReadLine();