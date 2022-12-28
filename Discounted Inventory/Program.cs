// See https://aka.ms/new-console-template for more information

Console.WriteLine($"What is your name?");
string name = Console.ReadLine();
Console.WriteLine("What item do you want to see the price of?");
Console.WriteLine("1 - Rope");
Console.WriteLine("2 - Torch");
Console.WriteLine("3 - Climbing Equipment");
Console.WriteLine("4 - Clean Water");
Console.WriteLine("5 - Machete");
Console.WriteLine("6 - Canoe");
Console.WriteLine("7 - Food Supplies");
int choice = Convert.ToInt32(Console.ReadLine());

string Blaez = null;
string discoumtname = Blaez == name ? $"You have the same name as {Blaez}! You get a discount." : "";
    Console.WriteLine(discoumtname);

string response;

string itemname = choice switch
{
    1 => "Rope",
    2 => "Torches",
    3 => "Climbing Equipment",
    4 => "Clean Water",
    5 => "A Machete",
    6 => "A Canoe",
    7 => "Food Supplies",
};

response = choice switch
{
    1 => "10",
    2 => "15",
    3 => "25",
    4 => "1",
    5 => "20",
    6 => "200",
    7 => "1",
};

if (discoumtname == Blaez)
{
    Convert.ToInt32(choice);
    int discount = choice / 2;
    Console.WriteLine($"{itemname} costs {choice} gold.");
}
else
{
    Console.WriteLine($"{itemname} costs {choice} gold.");    
}

