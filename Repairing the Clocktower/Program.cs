// See https://aka.ms/new-console-template for more information

Console.Write("What is the hour?"); 
int hour = Convert.ToInt32(Console.ReadLine());
int tik = hour % 2;

bool clock = tik <= 0;

if (clock)
    Console.WriteLine("Tik!");
else Console.WriteLine("Tok");