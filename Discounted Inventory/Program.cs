// See https://aka.ms/new-console-template for more information

Console.WriteLine($"What is your name?");
string userName = Console.ReadLine();
string myName = "Blaez";
string discountConfirmation = myName == userName ? $"You have the same name as {myName}! You get a discount." : "";
Console.WriteLine(discountConfirmation);
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

if (userName == myName)
{
    int itemprice = Convert.ToInt32(response);
    int discountprice =  itemprice/ 2;
    Console.WriteLine($"{itemname} costs {discountprice} gold.");
}
else
{
    Console.WriteLine($"{itemname} costs {response} gold.");    
}
aaaaaaa
