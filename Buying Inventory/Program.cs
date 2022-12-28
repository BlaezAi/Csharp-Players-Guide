// See https://aka.ms/new-console-template for more information

Console.WriteLine("What item do you want to see the price of?");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torch");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");

int choice = Convert.ToInt32(Console.ReadLine());
string response;



response = choice switch
{
    1 => "Rope cost 10 Gold",
    2 => "Torches cost 15 Gold",
    3 => "Climbing Equipment cost 25 Gold",
    4 => "Clean Water cost 1 Gold",
    5 => "A Machete cost 20 Gold",
    6 => "A Canoe cost 200 Gold",
    7 => "Food Supplies cost 1 Gold",
};
Console.WriteLine(response);