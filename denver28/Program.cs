// Задача № 46
// Задайте двумерный массив размером m x n) {
//     заполненный случайными целыми числами.

//     m = 3,  n = 4;

int [,] array = new int [3, 4];

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1, 10);
            Console.Write($"{arr[i,j]}");
        }
        Console.WriteLine();
    }
}
// void RandomArray(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0); i++)
//     {
//         for (int j = 0; j < arr.GetLength(1); j++)
//         {
//             arr[i,j] = new Random().Next(1, 10);
            
//         }
//         Console.WriteLine();
//     }
// }

PrintArray(array);
// RandomArray(array);
// Console.WriteLine();
// PrintArray(array);
