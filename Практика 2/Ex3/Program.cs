// Напишите программу,которая будет принимать на вход два числа и выводить,является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления
Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine()); 
if(a % b == 0)
{
Console.WriteLine("Да!Кратно");
}
else 
{
 Console.WriteLine(a%b);   
}