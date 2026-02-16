Console.WriteLine("----- smajlíci -----");
Console.WriteLine("Program pro vyhodnocení smajlíkú:");
Console.WriteLine("Seznam:");
Console.WriteLine(":)");
Console.WriteLine(":(");
Console.WriteLine(":*");
Console.WriteLine(":P");
Console.WriteLine(";)");
Console.WriteLine(":D");
Console.WriteLine("Zadejte smajlíka");
string input = Console.ReadLine();
switch (input)
{
    case ":)":
        Console.WriteLine("Váš smajlík se usmívá.");
        break;
    case ":(":
        Console.WriteLine("Váš smajlík je smutný.");
        break;
    case ":*":
        Console.WriteLine("Váš smajlík posílá pusinku.");
        break;
    case ":P":
        Console.WriteLine("Váš smajlík vyplazuje jazyk.");
        break;
    case ";)":
        Console.WriteLine("Váš smajlík mrká.");
        break;
    case ":D":
        Console.WriteLine("Váš smajlík se směje.");
        break;
    default:
        Console.WriteLine("Neplatný výběr.");
        break;
}
