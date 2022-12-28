// See https://aka.ms/new-console-template for more information

Console.WriteLine("How many chocolate eggs do the sisters have?");
string eggtext = Console.ReadLine();
int egg = Convert.ToInt32(eggtext);
int sisters = 4;
int remainder = (egg % sisters);
Console.WriteLine("The sisters each have " + egg / sisters + " eggs");
Console.WriteLine("The Duckbear has the remainder " + remainder + " eggs");