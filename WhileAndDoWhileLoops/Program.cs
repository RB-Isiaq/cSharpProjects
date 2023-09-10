Random random = new Random();
int current = 0;
string letter = "";

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);

// do
// {
//     letter = Console.ReadLine();
//     Console.WriteLine(letter);
// } while (letter != "q");

// WHile statement
// current = random.Next(1, 11);
// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");

// Use the continue statement to step directly to the Boolean expression
// As you saw in this last step, the continue statement transfers execution to the end of the current iteration. This behavior is different than the behavior we saw with the break statement. The break statement terminates the iteration (or switch) and transfers control to the statement that follows the terminated statement. If there is no statement after the terminated statement, then control transfers to the end of the file or method.

current = random.Next(1, 11);
do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);