// int heroPoints = 10;
// int monsterPoints = 10;
// Random random = new Random();

// do
// {
//     // Generate random value;
//    int heroPoint = random.Next(1, 5);
//     monsterPoints -= heroPoint;
//     Console.WriteLine($" Monster was damaged and lost  {heroPoint} health and now has {monsterPoints} health.");
//             if(monsterPoints <= 0 && heroPoints > 0)
//             {
//                 Console.WriteLine("Hero wins!");
//                 break;
//             }

//     if(monsterPoints > 0) 
//     {
//        int monsterPoint = random.Next(1, 5);
//         heroPoints -= monsterPoint;
//         Console.WriteLine($" Hero was damaged and lost  {monsterPoint} health and now has {heroPoints} health.");
//            if(monsterPoints > 0 && heroPoints <= 0)
//             {
//                 Console.WriteLine("Monster wins!");
//                 break;
//             }

//     }

    
    
// } while (heroPoints > 0 && monsterPoints > 0);

// Output will look like this
// Monster was damaged and lost 1 health and now has 9 health.
// Hero was damaged and lost 1 health and now has 9 health.
// Monster was damaged and lost 7 health and now has 2 health.
// Hero was damaged and lost 6 health and now has 3 health.
// Monster was damaged and lost 9 health and now has -7 health.
// Hero wins!

// The solution from microsoft

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");