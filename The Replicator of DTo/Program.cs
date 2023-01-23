// See https://aka.ms/new-console-template for more information

int[] userInputArray = new int[5];
Console.WriteLine("Type in numbers to the replicator.");
for (int i = 0; i < userInputArray.Length; i++)
{
    Console.Write("Enter numbers ");
    userInputArray[i] = Convert.ToInt32(Console.ReadLine());
}

int[] copiedArray = new int[5];
for (int i = 0; i < userInputArray.Length; i++)
{
    copiedArray = userInputArray;
}

for (int i = 0; i < userInputArray.Length; i++)
{
    Console.WriteLine($"{userInputArray[i]} and {copiedArray[i]}");
}