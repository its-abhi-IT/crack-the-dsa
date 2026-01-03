

using DSA.Array;

Console.WriteLine("Hello, DSA!");
Console.WriteLine("Please select any of one");
string programList = @"
1.Array
2.Soon
0.Exit";
Console.WriteLine(programList);

string userInput = Console.ReadLine();

if (string.IsNullOrEmpty(userInput))
{
    Console.WriteLine("You canceled the program");
    Console.WriteLine("Have a nice day!");
    Environment.Exit(0);
}
int input = Convert.ToInt32(Console.ReadLine());

if (input ==0)
{
    Console.WriteLine("Oops! not selected");
    
    Environment.Exit(0);
}

switch (input)
{
    case 1:
        SecondLargestFinder secondLargest = new SecondLargestFinder();
        break;
}
