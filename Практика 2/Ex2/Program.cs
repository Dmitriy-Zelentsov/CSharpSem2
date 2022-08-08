// Напишите программу,которая выводит случайное трехзначное число и удаляет вторую цифру этого числа
int number = new Random().Next(100,1000);// [100, 1000)
Console.WriteLine(number);
int digit1 = number / 100;
Console.WriteLine(digit1);
int digit2 = number % 10;
Console.WriteLine(digit2);
int k = int.Parse(digit1.ToString() + digit2.ToString());
Console.WriteLine(k);


// Решение через строки
int number = new Random().Next(100,1000);// [100, 1000)
string str_number = number.ToString();
char dig1 = str_number[0];
char dig2 = str_number[2];
string new_str_number = dig1.Parse(digit1.ToString() + dig2.ToString());
int new_number = Converter.ToInt32(new_str_number);
Console.WriteLine(new_str_number);
