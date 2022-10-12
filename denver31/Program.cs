// Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int n = 3,  m = 4;
int[,] array = new int[m, n];

ColumnArray(array);

for (int i = 0; i < n; i++)
{
  double averageMean = 0;
  for (int j = 0; j < m; j++)
  {
     averageMean+= array[j, i];
  }
  averageMean = Math.Round(averageMean / m, 1);
  Console.WriteLine($"средне арифметическое столбца  {i+1} --> {averageMean}\n ");
}

void ColumnArray (int[,] arr){
for (int i = 0; i < m; i++)
  {
      for (int j = 0; j < n; j++)
      {
        arr[i, j] = new Random().Next(1,10);
        arr[i, j] = Convert.ToInt32(array[i, j]);
        Console.Write(arr[i, j] + " ");
      }
      Console.WriteLine();
  }
}


