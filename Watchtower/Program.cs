// See https://aka.ms/new-console-template for more information

Console.WriteLine("What is the Y coordinate of where you are?");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is the X coordinate of where you are?");
int x = Convert.ToInt32(Console.ReadLine());


if (y > 0 && x == 0) Console.WriteLine("The enemy is NorthWest!");
if (y > 0 && x > 0) Console.WriteLine("The enemy is NorthEast");
if (y == 0 && x < 0) Console.WriteLine("The enemy is West");
if (y == 0 && x == 0) Console.WriteLine("The enemy is here!");
if (y == 0 && x > 0) Console.WriteLine("The enemy is East");
if (y < 0 && x < 0) Console.WriteLine("The enemy is SouthWest");
if (y < 0 && x == 0) Console.WriteLine("The enemy is South");
if (y < 0 && x > 0) Console.WriteLine("The enemy is SouthEast");