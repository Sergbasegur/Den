// Задача № 25
// Напишите цикл, который принимает на вход два числа(А и В) и
// возводит число А в натуральную степень В.
// 3 , 5 --> 243
// 2 , 4 --> 16.

Console.WriteLine("Введите число А :");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В :");
int b = Convert.ToInt32(Console.ReadLine());

int res = Convert.ToInt32(Math.Pow(a, b));
Console.WriteLine($"натуральное число {a} в степени {b} равно ==>" + res);
