using System.Runtime.InteropServices;

Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");


var userChoice = Console.ReadLine();

bool isUserInputAbc = userChoice == "ABC";
bool isUserInputNotAbc = userChoice != "ABC";
bool isUserInputAbc2 = !(userChoice == "ABC");


var number = 10;

var isLargerThan5 = number > 5;
var isLesserThan5 = number < 5;
var isLargerOrEqualTo5 = number >= 5;
var isLasserOrEqualTo5 = number <= 5;


var is10Modulo3EqualTo1 = 10 % 3 == 1;
var isEven = 20 % 2 == 0;


var isLargerThan4AndSmallerThan9 = number > 4 && number < 9;
var isEqualTo2OrLargerThan6OrEqualTo200 = number == 2 || number > 6 || number <200;


var userChoiceIf = Console.ReadLine();
if (userChoiceIf == "ABC")
{
    Console.WriteLine("User wrote ABC");
}
else
{
    Console.WriteLine("User didn't type ABC");
}

Console.ReadKey();

var userChoiceIfLength = Console.ReadLine();
if (userChoiceIfLength.Length > 10)
{
    Console.WriteLine("Long word");
}
else if(userChoiceIfLength.Length < 10)
{
    Console.WriteLine("Short word");
}
else {
    Console.WriteLine();
        }

Console.ReadKey();




namespace Coding.Exercise
{
    public class Exercise
    {
        public static string IsElseConditionalStatement()
        {
            int number = 0;

            string result;

            if (number < 0)
            {
                result = "negative";
            }
            else if (number == 0) 
            {
                result = "zero";
            }
            else
            {
                result = "positive";
            }

            return result;
        }
    }
}