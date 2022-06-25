int[] array1 = { 0, 0, 0, 0, 0 };
int[] array2 = new int[] { 1, 1, 2, 2, 3 };
int[] array3 = new int[5] { 1, 0, 2, 0, 3 };

// foreach (int i in array1);
// {
//     Console.WriteLine(i);
// }
Array.ForEach(array3, Console.WriteLine);
