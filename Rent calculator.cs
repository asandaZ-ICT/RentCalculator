// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter Details for Flat");

Console.Write("\nEnter Flat number: ");
int Flatnumber = int.Parse(Console.ReadLine());

Console.Write("Enter Flat Name: ");
String Flatname = Console.ReadLine();

Console.Write("How many students sharing: ");
int Stusharing = int.Parse(Console.ReadLine());

Console.Write($"Enter Basic rent for Flat {Flatnumber}:");
int rent = int.Parse(Console.ReadLine());

Console.WriteLine($"\nFlat {Flatnumber} {Flatname}");

Double utilities = (rent * 10 / 100.0 * Stusharing);
double Rental = (rent + utilities);
Double rentperperson = (rent / Stusharing + rent * 10 / 100.0);

Console.WriteLine($"\nMonthly rental: {Rental:C2} ");
Console.WriteLine($"Rental Per Person: {rentperperson:C2}");
Console.WriteLine($"Total utilities Bill: {utilities:C2}");

Console.ReadLine();
