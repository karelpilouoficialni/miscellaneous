Console.WriteLine("--- Výpočet BMI ---");

Console.WriteLine("Zadejte hmotnost (kg): ");
bool jeHmotnost = double.TryParse(Console.ReadLine(), out double hmotnost);

Console.WriteLine("Zadejte výšku (m): ");
bool jeVyska = double.TryParse(Console.ReadLine(), out double vyska);

double vypocetBMI = hmotnost / Math.Pow(vyska, 2);

string vysledek = jeHmotnost && jeVyska
    ? $"Vaše BMI: {vypocetBMI:N2}\nKlasifikace: {(vypocetBMI < 18.5 ? "Podváha" : (vypocetBMI < 25 ? "Ideální váha" : "Nadváha"))}"
    : "Neplatný vstup! Zadejte prosím čísla.";

Console.WriteLine(vysledek);