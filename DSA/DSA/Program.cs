

using DSA.Array;
int input = 0;
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

if(int.TryParse(userInput, out int result))
{
    input = result;
}
else
{
    Console.WriteLine("Oops input is not number");
    Environment.Exit(0);
}

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
