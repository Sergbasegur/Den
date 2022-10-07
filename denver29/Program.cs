﻿// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// m = 3, n = 4.  0,5 7 -2 -0,2  1 -3,3 8 -9,9   8 7,8 -7,1 9

double [,] array = new double [3, 4];



void PrintRandomArray(double[,] arr)
{
 
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
             arr[i,j] =  new Random().Next(-100, 100) + new Random().NextDouble();
             Console.Write(  $"{arr[i,j]:0.0}; ");
            
        }
        Console.WriteLine();
        
    }
}
 
PrintRandomArray(array);




