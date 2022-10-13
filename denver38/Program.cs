// Задача 66: 
// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.WriteLine("Введите значение : M");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите зжначение : N");
int N = Convert.ToInt32(Console.ReadLine());
int t = M;

PrintSum(M, N, t = 0);

void PrintSum(int m, int n, int sum)
{
    if( m > n)
    {
        m = n; n = t;
    }

    sum = sum + n;
    if(n <= m) 
    {
    Console.Write($"\n{M}; {N} --> {sum}");
    return;
    }
    PrintSum(m, n-1, sum);
}
