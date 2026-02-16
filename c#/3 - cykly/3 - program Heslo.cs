Console.WriteLine("--- Přihlašování heslem ---");

string spravneHeslo = "1234";
bool heslo = false;
int pocetPokusu = 1;
while (!heslo)
{
    Console.Write("Zadejte heslo: ");
    string vstupHeslo = Console.ReadLine();

    if (vstupHeslo == spravneHeslo)
    {
        heslo = true;
        Console.WriteLine("Zadali jste správné heslo");
        Console.WriteLine($"K přihlášení jste potřebovali {pocetPokusu} pokusů");

        while (heslo)
        {
            Console.Write("Napište příkaz: ");
            string prikaz = Console.ReadLine();

            if (prikaz == "odhlasit")
            {
                Console.WriteLine("Nashledanou!");
                break;
            }
            else
            {
                Console.WriteLine(prikaz);
                continue;
            }

        }

    }


    else
    {
        if (pocetPokusu > 2)
        {
            Console.WriteLine("Spotřebovali jste 3 pokusy, nelze zadat další heslo.");
            break;
        }
        pocetPokusu++;
        Console.WriteLine("Zadali jste špatné heslo!");
    }
}
