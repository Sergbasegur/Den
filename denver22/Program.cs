//Задача № 32
// Напишите программу замена элементов массива: 
//положительные элементы замените на отрицательные и наоборот.
// [-4, -8, 8, 2] --> [4, 8, -8, 2]

int[] CreateArrayRand(int size, int pos, int neg)
{
    int[] array = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(pos, neg + 1);
    }
    return array;
}

void Invers(int[] array)
{
   
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
    
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
int[] arr = CreateArrayRand(5, -9, 9);
PrintArray(arr);
Invers(arr);
