﻿//Задача № 12
//Напишите программу, которая будет принимать на вход два числа и
//вываодить, является ли второе число кратное первому. Если число 2 не кратно 1,
//то программа выводит остаток деления.
//34, 5 -> не кратно, остаток 4
//16, 4 -> кратно

Console.WriteLine("Введите первое число :");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число :");
int b = Convert.ToInt32(Console.ReadLine());
int number = a / b;

if( number  %  2 == 0) {
    Console.WriteLine("второе число кратно первому числу");}
    else
    {
    Console.WriteLine("Остаток при делении равняется - " + a % b);
    }

