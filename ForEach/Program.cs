// See https://aka.ms/new-console-template for more information
int[] inventory = { 200, 450, 700, 175, 250 };

int sum = 0;
int bin = 0;
foreach (int i in inventory) {
    sum += i;
    bin++;
    Console.WriteLine($"Bin {bin} = {i} items (Running total: {sum})");
}
Console.WriteLine($"We have a {sum} items in inventory.");

// CHALLENGE

string [] fraudulentOrderIDs = {"B123",
"C234",
"A345",
"C15",
"B177",
"G3003",
"C235",
"B179"};

foreach (string orderID in fraudulentOrderIDs) {
    if(orderID.StartsWith('B')) {
        Console.WriteLine($"Fraudulent order: {orderID}");
    }
}

Random random = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string message = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = message.ToCharArray();

Array.Reverse(charMessage);

int letterCount = 0;

foreach (char letter in charMessage)
{ 
    if (i == 'o') 
    { 
        letterCount++; 
    } 
}

string newMessage = new String(charMessage);

// print it out
Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {x} times.");