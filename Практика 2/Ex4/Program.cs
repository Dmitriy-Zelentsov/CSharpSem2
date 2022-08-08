// Напишите программу,которая принимает на вход число и проверяет кратно ли оно одновременно 7 и 23
int num1 = 7;
int num2 = 23;
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine()); 
if(a % num1 == 0 && a % num2 == 0)
{
Console.WriteLine("Да!Кратно");
}
else 
{
 Console.WriteLine("Нет!");   
}