// Задача № 10
//Напишите программу, которая принимает на вход трехзначное число и на 
//выходе показывает
//вторую цифру этого числа.
//456 -> 5    782 -> 8   918 -> 1
int a = new Random().Next(100, 1000);
Console.WriteLine(a);
int b = int.Parse(a.ToString().Remove(0, 1));
int c = int.Parse(b.ToString().Remove(1, 1));
Console.WriteLine("Вторая цифра этого числа " + c);
