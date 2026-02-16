Console.Write("Zadejte číslo dne v týdnu: ");
string volba = Console.ReadLine();

if (volba == "1")
{
    Console.WriteLine("Pondělí");
    Console.WriteLine("Meditujte");
}

else if (volba == "2")
{
    Console.WriteLine("Úterý");
    Console.WriteLine("Běžte na procházku");
}

else if (volba == "3")
{
    Console.WriteLine("Středa");
    Console.WriteLine("Protáhněte se");
}

else if (volba == "4")
{
    Console.WriteLine("Čtvrtek");
    Console.WriteLine("Sledujte vzdělávací videa");
}

else if (volba == "5")
{
    Console.WriteLine("Pátek");
    Console.WriteLine("Navštivte kino");
}

else if (volba == "6")
{
    Console.WriteLine("Sobota");
    Console.WriteLine("Ukliďte si obývací prostory");
}

else if (volba == "7")
{
    Console.WriteLine("Neděle");
    Console.WriteLine("Odpočiňte si");
}


if (!int.TryParse(volba, out int den))
{
    Console.WriteLine("Zadali jste textový řetězec, nejedná se o číslo.");
    return;
}

if (den < 1 || den > 7)
{
    Console.WriteLine($"Není znám {den}. den v týdnu.");
    return;
}
