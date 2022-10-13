// Задача 58: 
// Задайте две матрицы. Напишите программу,
//  которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
int m = 2;
int n = 2;
int p = 2;

int[,] martrix1 = new int[m,n];
int[,] martrix2 = new int[n,p];
CreateArray(martrix1);
WriteArray(martrix1);
Console.WriteLine();
CreateArray(martrix2);
WriteArray(martrix2);

int[,] resultMatrix = new int[m,p];

MultiplyMatrix(martrix1, martrix2, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] martrix1, int[,] martrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < martrix1.GetLength(1); k++)
      {
        sum += martrix1[i,k] * martrix2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

void CreateArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = new Random().Next(1,9);
    }
  }
}

void WriteArray (int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(arr[i,j] + " ");
    }
    Console.WriteLine();
  }
}