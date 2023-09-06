// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Random dice = new Random();
// Console.WriteLine(roll);
// int roll = dice.Next(1, 7);

Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

// Random.Next()
int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);