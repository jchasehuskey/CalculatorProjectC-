System.Console.WriteLine("hello");
System.Console.WriteLine("Input the first number");
var firstNumber = Console.ReadLine();
var actualNumber = int.Parse(firstNumber);

System.Console.WriteLine("Input the second number");
var secondNumber = Console.ReadLine();
var actualSecondnumber = int.Parse(secondNumber);

System.Console.WriteLine("Which operation should be executed?");
System.Console.WriteLine("[A]dd numbers");
System.Console.WriteLine("[S]ubtract numbers");
System.Console.WriteLine("[M]uliply numbers");
var choice = Console.ReadLine();

// if (choice == "A" || choice == "a")
if (EqualsCaseInsensitive(choice, "A"))
{
    var sum = actualNumber + actualSecondnumber;
    PrintFinalEquation(actualNumber, actualSecondnumber, sum, "+");
}
else if (EqualsCaseInsensitive(choice, "S"))
{
    var difference = actualNumber - actualSecondnumber;
    PrintFinalEquation(actualNumber, actualSecondnumber, difference, "-");
}
else if (EqualsCaseInsensitive(choice, "M"))
{
    var multiplied = actualNumber * actualSecondnumber;
    PrintFinalEquation(actualNumber, actualSecondnumber, multiplied, "*");
}
else
{
    System.Console.WriteLine("invalid choice");
}

void PrintFinalEquation(int actualNumber, int actualSecondNumber, int result, string @operator)
{
    System.Console.WriteLine(actualNumber + " " + @operator + " " + actualSecondNumber + " " + "=" + " " + result);
}

bool EqualsCaseInsensitive(string left, string right)
{
    return left.ToUpper() == right.ToUpper();
}


System.Console.WriteLine("Press any key to close.");
Console.ReadKey();






// Console.WriteLine("Hello!");
// Console.WriteLine("Input the first number:");
// var firstNumber = Console.ReadLine();
// int actualFirstNumber = int.Parse(firstNumber);

// Console.WriteLine("Input the second number:");
// var secondNumber = Console.ReadLine();
// int actualSecondNumber = int.Parse(secondNumber);

// Console.WriteLine("What do you want to do with those numbers?");

// Console.WriteLine("[A]dd");
// Console.WriteLine("[S]ubtract");
// Console.WriteLine("[M]ultiply");

// string userChoice = Console.ReadLine();



// int result;
// string operationString = "";

// if (userChoice == "A" || userChoice == "a")
// {
//     result = actualFirstNumber
//     + actualSecondNumber;
//     operationString = $"{actualFirstNumber} + {actualSecondNumber} = {result}";
// }
// else if (userChoice == "S" || userChoice == "s")
// {
//     result = actualFirstNumber
//     - actualSecondNumber;
//     operationString = $"{actualFirstNumber} - {actualSecondNumber} = {result}";
// }
// else if (userChoice == "M" || userChoice == "m")
// {
//     result = actualFirstNumber
//     * actualSecondNumber;
//     operationString = $"{actualFirstNumber} * {actualSecondNumber} = {result}";
// }
// else
// {
//     System.Console.WriteLine("Invalid option");
//     Console.WriteLine("Press any key to close");
//     Console.ReadKey();
// }

// System.Console.WriteLine(operationString);
// Console.WriteLine("Press any key to close");
// Console.ReadKey();



