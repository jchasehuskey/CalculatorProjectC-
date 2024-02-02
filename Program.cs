
Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
var firstNumber = Console.ReadLine();
int actualFirstNumber = int.Parse(firstNumber);

Console.WriteLine("Input the second number:");
var secondNumber = Console.ReadLine();
int actualSecondNumber = int.Parse(secondNumber);

Console.WriteLine("What do you want to do with those numbers?");

Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

string userChoice = Console.ReadLine();

// int result = CheckChoice(userChoice);
// CheckResult(result);

// void displayResult = CheckResult(result);

// void CheckResult(int result)
// {
//     if (result == 0)
//     {
//         System.Console.WriteLine("Invalid option");
//         Console.WriteLine("Press any key to close");
//         Console.ReadKey();
//     }
//     else
//         System.Console.WriteLine(result);
//     Console.WriteLine("Press any key to close");
//     Console.ReadKey();
// }

int result;
string operationString = "";

if (userChoice == "A" || userChoice == "a")
{
    result = actualFirstNumber
    + actualSecondNumber;
    operationString = $"{actualFirstNumber} + {actualSecondNumber} = {result}";
}
else if (userChoice == "S" || userChoice == "s")
{
    result = actualFirstNumber
    - actualSecondNumber;
    operationString = $"{actualFirstNumber} - {actualSecondNumber} = {result}";
}
else if (userChoice == "M" || userChoice == "m")
{
    result = actualFirstNumber
    * actualSecondNumber;
    operationString = $"{actualFirstNumber} * {actualSecondNumber} = {result}";
}
else
{
    System.Console.WriteLine("Invalid option");
    Console.WriteLine("Press any key to close");
    Console.ReadKey();
}

System.Console.WriteLine(operationString);
Console.WriteLine("Press any key to close");
Console.ReadKey();

// int CheckChoice(string userChoice)
// {
//     if (userChoice == "A" || userChoice == "a")
//     {
//         return (actualFirstNumber + actualSecondNumber);
//     }
//     else if (userChoice == "S" || userChoice == "s")
//     {
//         return (actualFirstNumber - actualSecondNumber);
//     }
//     else if (userChoice == "M" || userChoice == "m")
//     {
//         return (actualFirstNumber * actualSecondNumber);
//     }
//     else
//     {
//         return 0;
//     }
// }

// Console.WriteLine("Press any key to close");
// Console.ReadKey();
