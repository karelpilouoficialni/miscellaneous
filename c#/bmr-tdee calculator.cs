Console.WriteLine("Hello and Welcome to my brand new calc");

// bmr
Console.WriteLine("\nChoose your gender: Male or Female");
string gender = Console.ReadLine();

Console.WriteLine("\nEnter your specfications to calculate your BMR...");

Console.Write("Enter your weight in kg: ");
int weight;
int.TryParse(Console.ReadLine(), out weight);

Console.Write("Enter your height in cm: ");
int height;
int.TryParse(Console.ReadLine(), out height);

Console.Write("Enter your age in years: ");
int age;
int.TryParse(Console.ReadLine(), out age);

double bmr = 0;
if (gender.Equals("Male", StringComparison.OrdinalIgnoreCase))
{
    bmr = 10 * weight + 6.25 * height - 5 * age + 5;
    int rounded = (int)Math.Round(bmr / 10.0) * 10;

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Your BMR is: {rounded} calories");
    Console.ResetColor();

}

if (gender.Equals("Female", StringComparison.OrdinalIgnoreCase))
{
    bmr = 10 * weight + 6.25 * height - 5 * age - 161;
    int rounded = (int)Math.Round(bmr / 10.0) * 10;

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Your BMR is: {rounded} calories");
    Console.ResetColor();

}

// tdee
Console.Write("\nEnter your todays caloric expenditure: ");
int expenditure;
int.TryParse(Console.ReadLine(), out expenditure);

Console.Write("Enter your today caloric intake: ");
int intake;
int.TryParse(Console.ReadLine(), out intake);

double tdee;
tdee = bmr + expenditure + (intake * 0.1);
int roundedTdee = (int)Math.Round(tdee);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"\nYour TDEE is: {roundedTdee} calories");
Console.ResetColor();

// deficit
double deficit;
deficit = tdee - intake;
int roundedDeficit = (int)Math.Round(deficit);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Your todays deficit is {roundedDeficit} calories");
Console.ResetColor();


