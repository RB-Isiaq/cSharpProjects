for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
}
Console.WriteLine("\n------------LINE_BREAKER------------\n");
for (int i = 10; i >= 0; i--)
{
    Console.WriteLine(i);
}

Console.WriteLine("\n------------LINE_BREAKER------------\n");
for (int i = 0; i < 10; i += 3)
{
    Console.WriteLine(i);
}

Console.WriteLine("\n------------LINE_BREAKER------------\n");
for (int i = 0; i < 10; i++)
{
    Console.WriteLine(i);
    if (i == 7) break;
}
Console.WriteLine("\n------------LINE_BREAKER------------\n");

string[] namesReverse = { "Alex", "Eddie", "David", "Michael" };
for (int i = namesReverse.Length - 1; i >= 0; i--)
{
    Console.WriteLine(namesReverse[i]);
}
Console.WriteLine("\n------------LINE_BREAKER------------\n");

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}

//Cannot work, for each iteration does not allow the assignment of values to the iterated variables, it will throw an error
// Console.WriteLine("\n------------LINE_BREAKER------------\n");

// // string[] names = { "Alex", "Eddie", "David", "Michael" };
// foreach (var name in names)
// {
//     // Can't do this:
//     if (name == "David") name = "Sammy";
// }

Console.WriteLine("\n------------LINE_BREAKER------------\n");
// But this can be done using the for loop below

// string[] names = {"Alex", "Eddie", "David", "Michael"};

for (int i = 0; i < names.Length; i++) 
    if(names[i] == "David") 
        names[i] = "Sammy";
    
foreach(string name in names)
    Console.WriteLine(name);