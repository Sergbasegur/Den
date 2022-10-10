// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента
//  в двумерном массиве, и возвращает значение этого элемента
//   или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
Console.WriteLine("Введите строку - p1 - двумерного массива");
int p1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите столбец - p2 - двумерного массива");
int p2 = Convert.ToInt32(Console.ReadLine());


int[,] array = new int [3, 4];
// {
//     {-4, 4, 7, 1},
//     {-1,2,4,6},
//     {12, 3, 67, 0}
// };

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {   
            arr[i,j] = new Random().Next(-10,10);
            Console.Write($"{arr[i,j]}, ");
        }
        Console.WriteLine();
    }
     if(p1 < 0 | p1 > arr.GetLength(0)-1 | p2 < 0 | p2 > arr.GetLength(1) -1)
        {           
                 Console.WriteLine("элемент c позицией (p1 и p2) не существует");
        }
    
}
PrintArray(array);






