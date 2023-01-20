// See https://aka.ms/new-console-template for more information

// Console.WriteLine("Pilot, enter a number between 0 and 100.");
// int pilotnumber = Convert.ToInt32(Console.Read());

// while (true)
// {
//     if (pilotnumber >=0 && pilotnumber <=100)
//     {
//         Console.WriteLine("Invalid Number try again.");   
//     break;
//     }
//     Console.WriteLine("Hunter, guess the pilot's number.");
//     int hunternumber = Convert.ToInt32(Console.Read());
// }

int pilotnumber;
bool pilotnumbervalid = false;

do
{
    Console.WriteLine("Pilot, enter a number between 0 and 100.");
    pilotnumber = Convert.ToInt32(Console.ReadLine());
    pilotnumbervalid = (pilotnumber >= 0 && pilotnumber <= 100);

    if (!pilotnumbervalid)
    {
        Console.WriteLine("Invalid, Choose a different number.");
    }
} while (!pilotnumbervalid);
Console.Clear();

while (true)
{

    Console.WriteLine("Hunter guess the pilot's number.");
    int hunternumber = Convert.ToInt32(Console.ReadLine());

    if (pilotnumber < hunternumber)
    {
        Console.WriteLine("Number is too high try again.");
        continue;
    }

    if (pilotnumber > hunternumber)
    {
        Console.WriteLine("Number is too low, try again.");
        continue;
    }

    if (hunternumber == pilotnumber)
    {
        Console.WriteLine("You guessed correctly!");
        break;
    }
}