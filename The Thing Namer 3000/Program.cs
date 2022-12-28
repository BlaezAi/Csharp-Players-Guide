// See https://aka.ms/new-console-template for more information

Console.WriteLine("What kind of thing are we talking about?");
//Console entry from User on item name
string a = Console.ReadLine();
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
/*Console entry from user describing item */
string b = Console.ReadLine();
//Writes of Doom to item
string c = "of Doom";
/*Writes 3000 to item */
string d = "3000";
Console.WriteLine("The " + b + " " + a + " of " + c + " " + d + "!");

