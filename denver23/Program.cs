//Задача № 39
//Напишите программу, которая перевернет одномерный массив
//(последний элемент будет на первом месте, а первый на последнем)

// [1 2 3 4 5] --> [5 4 3 2 1]
// [6 7 3 6] --> [6 3 7 6]

int[] Creatarray(int size, int min, int max)
{
    int[] array = new int [size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{   Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1)Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

void ArrayRevers(int[] array)
{
    int size = array.Length;
    int index1 = 0;
    int index2 = size - 1;

    while(index1 < index2)
    {
        int obj = array[index1];
        array[index1] = array[index2];
        array[index2] = obj;

        index1++;
        index2--;
    }
}
int[] arr = Creatarray(10, 1, 10);
PrintArray(arr);
ArrayRevers(arr);
PrintArray(arr);
Console.WriteLine();
PrintArray(arr);
ArrayRevers(arr);
PrintArray(arr);