Console.WriteLine("--------- Objednávka pizzy ---------");
int cenaMargarita = 150;
int cenaCapricciosa = 180;
int cenaQuattroFormaggi = 200;
int celkovaCena = 0;

Random generator = new Random();

Console.Write("Kolik pizz si přejete objednat? ");
int.TryParse(Console.ReadLine(), out int pocetPizz);

for (int i = 1; i <= pocetPizz; i++)
{
    Console.WriteLine($"Vyberte pizzu č. {i}.");
    Console.WriteLine("Jaký druh pizzy si přejete? (margarita, capricciosa, quattro_formaggi)");
    string druhPizzy = Console.ReadLine().ToLower();

    switch (druhPizzy)
    {
        case "margarita":
            int objednavka = generator.Next(1, 101);
            celkovaCena += cenaMargarita;
            Console.WriteLine(
                $"Připravuji pizzu {druhPizzy} č. {i} s objednávkovým číslem {objednavka}."
            );
            break;

        case "capricciosa":
            int objednavka1 = generator.Next(1, 101);
            celkovaCena += cenaCapricciosa;
            Console.WriteLine(
                $"Připravuji pizzu {druhPizzy} č. {i} s objednávkovým číslem {objednavka1}."
            );
            break;

        case "quattro_formaggi":
            int objednavka2 = generator.Next(1, 101);
            celkovaCena += cenaQuattroFormaggi;
            Console.WriteLine(
                $"Připravuji pizzu {druhPizzy} č. {i} s objednávkovým číslem {objednavka2}."
            );
            break;

        default:
            Console.WriteLine("Neplatná volba pizzy.");
            break;
    }
}

Console.WriteLine($"Celková cena: {celkovaCena} Kč");
Console.WriteLine("Děkujeme za objednávku! Dobrou chuť.");
