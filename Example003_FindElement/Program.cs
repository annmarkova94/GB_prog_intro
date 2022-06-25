int[] array1 = { 1, 2, 4, 5, 3, 5, 6, 1, 7, 8, 4, 6, 3 };
int n = array1.Length;
int find = 4;
int i = 0;

while (i < n)
{
    if (array1[i] == find)
    {
        Console.WriteLine(i);
        //break;
    }
    i++;
}


