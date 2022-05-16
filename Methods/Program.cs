using Methods;

//ConsoleMessages.SayHi();

List<string> names = new();

names.Add("Bob");
names.Add("Mike");
names.Add("Doug");
names.Add("Mom");
names.Add("Dad");
names.Add("Ron");
names.Add("Tanya");

foreach (string listNames in names)
{
    ConsoleMessages.SayHi(listNames);
}

string name = ConsoleMessages.GetUsersName();
ConsoleMessages.SayHi(name);


(double firstNumber, double secondNumber) = ConsoleMessages.GetTwoNumbers();
Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");

(string firstName, string lastName) = ConsoleMessages.GetFullName();

Console.WriteLine("\n");

Console.WriteLine($"You entered {firstName} for your first name and {lastName} for your surname.");

Console.ReadLine();