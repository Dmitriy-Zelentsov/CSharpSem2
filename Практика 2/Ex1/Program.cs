// Напишите программу,которая выводит случайное число из отрезка [10, 99] и показывает наибольшее из них
int number = new Random().Next(10,100);// [10, 100)
Console.WriteLine(number);
int digit1 = number / 10;
int digit2 = number % 10;
if (digit1 > digit2)
Console.WriteLine(digit1);
else
Console.WriteLine(digit2);
