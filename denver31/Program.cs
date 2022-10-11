// Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int n = 3;
int m = 4;

int [,] array = new int [n, m];


void PrintArray(int[,] arr)
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            arr[i,j] = new Random().Next(0, 9);
            Console.Write($"{arr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void ArithmeticMean(int[,] arr)
{ 
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            
        }
    }
       
}
 

PrintArray(array);
Console.WriteLine();
ArithmeticMean(array);
