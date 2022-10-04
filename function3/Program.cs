// Задача № 31
// Задайте массив из 12 элементов  заполненный случайными числами из
// промежутка { -9 , 9}. Найдите сумму отрицательных и положительных 
// элементов массива.

// [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6] --> 
// --> сумма положительных чисел равна -20.

int[] CreateArrayRand(int size, int min, int max)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

// int[] GetSumPositivNegativeElem(int[] array)
// {
//     int sumPositiv = default;
//     int sumNegativ = default;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if(array[i] < 0) sumNegativ += array[i];
//         else sumPositiv += array[i];
//     }
//     return new int[]{sumPositiv, sumNegativ};
// }

int GetSumPositivElem(int[] array)
{
   int sumPositiv = default;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0)  sumPositiv += array[i];
    }
    return sumPositiv;
}

int GetSumNegativElem(int[] array)
{
   int sumNegativ = default;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0)  sumNegativ += array[i];
    }
    return sumNegativ;
}



void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i< array.Length -1)Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
int[] arr = CreateArrayRand(12, -9, 9);
PrintArray(arr);
int sumPos = GetSumPositivElem(arr);
int sumNeg = GetSumNegativElem(arr);
Console.WriteLine($"сумма положительных элементов = {sumPos}");
Console.WriteLine($"сумма отрицательных элементов = {sumNeg}");

// int[] sumPositivNegativ = GetSumPositivNegativeElem(arr);
// Console.WriteLine($"сумма положительных элементов = {sumPositivNegativ[0]}");
// Console.WriteLine($"сумма отрицательных элементов = {sumPositivNegativ[1]}");


 






