//Задача № 23
//Напишите программу, которая принимает на вход число(N) и выдает
//таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число - N :");
int N = Convert.ToInt32(Console.ReadLine());
for(int i = 0; i <= N; i++)
{
    Console.WriteLine($"куб числа {i} = " + i*i*i);
}

