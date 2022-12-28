// See https://aka.ms/new-console-template for more information

Console.WriteLine("How many estates do you have?");
int estateCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many duchiies do you have?");
int duchyCount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many provinces do you have?");
int provinceCount = Convert.ToInt32(Console.ReadLine());

int estate = 1;
int duchy = 3;
int province = 6;
int total = estate * estateCount + duchy * duchyCount + province * provinceCount;

Console.WriteLine("You have " + total + " points");

