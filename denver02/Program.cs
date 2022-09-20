//Задача № 11
//Напишите программу, которая выводит случайное трехзначное число и удаляет 
//вторую цифру этого числа.
// 456 -> 46     782 -> 72    918 -> 98

int a = new Random().Next(100, 1000);
Console.WriteLine(a);
int b = int.Parse(a.ToString().Remove(1, 1));
Console.WriteLine(b);




