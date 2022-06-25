//Method
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

int a1 = 9, b1 = 12, c1 = 24,
    a2 = 12, b2 = 25, c2 = 12,
    a3 = 26, b3 = 27, c3 = 8;

int max = Max(
    Max(a1, b1, c1),
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.WriteLine(max);