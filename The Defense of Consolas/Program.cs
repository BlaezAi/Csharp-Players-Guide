// See https://aka.ms/new-console-template for more information

Console.Title = "The Defense of Consolas";
Console.Write("Target Row? ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Target Column? ");
int column = Convert.ToInt32(Console.ReadLine());

int row1 = row; 
int column1 = column - 1;
int row2 = row - 1; 
int column2 = column;
int row3 = row; 
int column3 = column + 1;
int row4 = row + 2; 
int column4 = column;

//Console.BackgroundColor = ConsoleColor.DarkBlue;
Console.ForegroundColor = ConsoleColor.Cyan;

Console.WriteLine($"({row1}, {column1})");
Console.WriteLine($"({row2}, {column2})");
Console.WriteLine($"({row3}, {column3})");
Console.WriteLine($"({row4}, {column4})");
Console.Beep(440,1000);