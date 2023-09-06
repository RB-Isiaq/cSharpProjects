using System;
// Console.WriteLine("a" == "a");
// Console.WriteLine("a" == "A");
// Console.WriteLine(1 == 2);

// string myValue = "a";
// Console.WriteLine(myValue == "a");
// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));

int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

Random coin = new Random();

Console.WriteLine((coin.Next(1, 3) == 1) ? "heads" : "tails");

string permission = "Admin|Manager";
int level = 55;

if(permission.Contains("Admin") && level > 55) 
{
Console.WriteLine("Welcome, Super Admin user.");
}
else if(permission.Contains("Admin") && level <= 55) 
{
    Console.WriteLine("Welcome, Admin user.");
}
else if(permission.Contains("Manaeger") && level >= 20) 
{
    Console.WriteLine("Contact an Admin for access.");
}
else if(permission.Contains("Manaeger") && level < 20) 
{
    Console.WriteLine("You do not have sufficient privileges.");
}
else 
{
    Console.WriteLine("You do not have sufficient privileges.");
}