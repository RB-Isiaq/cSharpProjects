using System;
using Microsoft.VisualBasic;
/* string? readResult;
Console.WriteLine("Enter a string:");
do
{
    readResult = Console.ReadLine();
} while (readResult.Length < 3);

int numericValue = 0;
bool validNumber = false;

validNumber = int.TryParse(readResult, out numericValue);

if (validNumber)
{
    Console.WriteLine($"The number is {readResult}", numericValue);
} */

/* // Code project 1 - write code that validates integer input
string? readResult;
int numericValue = 0;
bool validNumber = false;
Console.WriteLine("Enter a number between 5 and 10.");

do
{
    readResult = Console.ReadLine();
    Console.WriteLine(readResult);
    validNumber = int.TryParse(readResult, out numericValue);
    if(!validNumber)
        Console.WriteLine("Sorry, you entered an invalid number, please try again", numericValue);
    
    else if (numericValue < 6 || numericValue > 9)
        Console.WriteLine($"You entered {numericValue}. The number should be between 5 and 10.");
    
     else 
         Console.WriteLine($"Your input value {(numericValue)} has been accepted.");
    

} while (numericValue < 6 || numericValue > 9); */

/* // Code project 2 - write code that validates string input
string? readResult;
string[] roles = {"administrator", "manager", "user"};
string role = "";

while (!roles.Contains(role))
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    role = readResult.Trim().ToLower();
    Console.WriteLine(role);
    if (!roles.Contains(role))
        Console.Write($"The role name that you entered, '{role}' is not valid. ");
    else 
    {
        Console.Write($"Your input value {(role)} has been accepted.");
        break;
    }
}
 */

 // Code project 3 - Write code in the code editor to implement code that achieves the project conditions

 string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
 string substring = "";
 string removed = "";
 int periodLocation = 0;


 foreach (var myString in myStrings)
 {
    int counter = 0;
    Console.WriteLine(myString);
    periodLocation = myString.IndexOf(".");
    Console.WriteLine(periodLocation);
   

        substring = myString;

    do
    {
        periodLocation = substring.IndexOf(".");
        removed = substring.Remove(periodLocation);
        substring = substring.Substring(periodLocation);
        Console.WriteLine(removed);
        Console.WriteLine(substring);
        counter++;
    } while (counter <= myStrings.Length - 1);
 }

