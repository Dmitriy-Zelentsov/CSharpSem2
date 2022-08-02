int a = 1;
int b = 3;
int c = 7;
int e = 10;
int max  = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (e > max) max = e;

Console.Write("max = ");
Console.WriteLine(max);