void FillArray(int[] collection)
{
    int length = collection.Length;
    int i = 0;
    while (i < length)
    {
        collection[i] = new Random().Next(0, 10);
        i++;
    }
}

void PrintArray(int[] array_to_print)
{
    int count = array_to_print.Length;
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(array_to_print[i]);
        i++;
    }
}

int IndexOf(int[] array, int find)
{
    int length = array.Length;
    int i = 0;
    int result = -1;
    while (i < length)
    {
        if (array[i] == find)
        {
            result = i;
            break;
        }
        i++;
    }
    return result;
}

int[] array1 = new int[10]; //по умолчанию нулями заполнен
FillArray(array1);
PrintArray(array1);

Console.Write("Write down the number which index you want to find: ");
int find = int.Parse(Console.ReadLine());
Console.Write("Index: ");
Console.WriteLine(IndexOf(array1, find));