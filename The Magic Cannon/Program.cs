// See https://aka.ms/new-console-template for more information

int currentNumber;

for (currentNumber = 1; currentNumber <= 100; currentNumber++)
{
    if (currentNumber % 3 == 0 && currentNumber % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(currentNumber);
    }

    else if (currentNumber % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(currentNumber);
    }

    else if (currentNumber % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(currentNumber);
    }

    else
    {
        Console.ForegroundColor = ConsoleColor.Black;
        Console.WriteLine(currentNumber);
    }
}