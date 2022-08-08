// Найти максимум из 9 чисел с помощью функции
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a = 1;
int b = 2;
int c = 3;
int d = 4;
int e = 45;
int f =67;
int g = 44;
int h = 23;
int k = 24;

int max1 = Max(a, b ,c);
int max2 = Max(d, e ,f);
int max3 = Max(g, h ,k);
int max = Max(max1, max2, max3);

Console.WriteLine(max);