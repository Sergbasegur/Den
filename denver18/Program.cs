 //Задача 34:
//Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

//  int[] array = new int [5];
// Random ran = new Random();

// int count = 0;
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = ran.Next(100, 1000);

//     int a = array[i];

//     if(a  % 2 == 0)
//     {
//         count++;
//         Console.WriteLine($"[{a}] --> {count}");
        
//     } 
// }

int M = 5;
int sum = 0;
int[] S = new int[M];
Random rand =new Random();

for (int i = 0; i < M; i++)
{
    S[i] = rand.Next(100, 1000);
    Console.WriteLine(S[i] + " ");
    if(S[i] % 2 == 0) sum++;
    
}
Console.WriteLine("количество четных чисел = " + sum);

