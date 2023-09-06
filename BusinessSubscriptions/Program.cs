using System.Security.Cryptography.X509Certificates;

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// Your code goes here
Console.WriteLine(daysUntilExpiration);
if(daysUntilExpiration <= 5 && daysUntilExpiration >=2)
{
    discountPercentage=10;
}
else if(daysUntilExpiration < 2)
{
    discountPercentage=20;

}
Console.WriteLine(discountPercentage);

if(daysUntilExpiration <= 10 && daysUntilExpiration > 5) 
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else if(daysUntilExpiration <= 5 && daysUntilExpiration >= 2) 
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
else if(daysUntilExpiration < 2 && daysUntilExpiration > 0) 
{
    Console.WriteLine("Your subscription expires within a day.");
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}
else if(daysUntilExpiration == 0) 
{
    Console.WriteLine("Your subscription has expired.");
}


// if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiration == 1)
// {
//     Console.WriteLine("Your subscription expires within a day!");
//     discountPercentage = 20;
// }
// else if (daysUntilExpiration <= 5)
// {
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//     discountPercentage = 10;
// }
// else if (daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }

// if (discountPercentage > 0)
// {
//     Console.WriteLine($"Renew now and save {discountPercentage}%.");
// }
