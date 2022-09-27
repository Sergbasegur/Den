//Задача № 24
//Напишите программу которая на вход принимает число(А)
// и выдает сумму чисел от 1 до (А).
Console.WriteLine("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());
int sumNum = SumNumb(number);
Console.WriteLine(sumNum);

int SumNumb(int num)
{
    int sum = default;
    for(int i = 1; i <= num; i++)
    {
            sum = sum + i;
    }
    return sum;
} 
