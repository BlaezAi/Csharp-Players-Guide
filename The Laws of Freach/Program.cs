// See https://aka.ms/new-console-template for more information

// // int[] arrayMinimum = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
// // int currentSmallest = int.MaxValue; // Start higher than anything in the array.
// // for (int index = 0; index < arrayMinimum.Length; index++)
// // {
// //     if (arrayMinimum[index] < currentSmallest)
// //         currentSmallest = arrayMinimum[index];
// // }
// Console.WriteLine(currentSmallest);

// int[] arrayMinimum = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
// int currentSmallest = int.MaxValue; // Start higher than anything in the array.
// foreach (var current in arrayMinimum)
// {
//     if (current < currentSmallest)
//         currentSmallest = current;
// }
// Console.WriteLine(currentSmallest);

int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
int total = 0;
foreach (var current in array)
{
    total += current;
}
float average = (float)total / array.Length;
Console.WriteLine(average);

