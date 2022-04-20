// See https://aka.ms/new-console-template for more information
using QAP.RandomInstanceGenerator;

string? option;

while (true) {
    Console.WriteLine("Select an option.");
    Console.WriteLine("1. Generate an instance.");
    Console.WriteLine("2. Use Heuristic.");
    Console.WriteLine("3. Exit.");
    option = Console.ReadLine();
    if (Convert.ToInt16(option) == 1 || Convert.ToInt16(option) == 2 || Convert.ToInt16(option) == 3) {
        break;
    }
    Console.WriteLine("Enter a valid option.");
    Thread.Sleep(3000);
    Console.Clear();
}

switch (Convert.ToInt16(option)) {
    case 1:
        Console.WriteLine("First option");
        break;
    case 2:
        Console.WriteLine("Second option");
        break;
    case 3:
        Console.WriteLine("Third option");
        break;
}