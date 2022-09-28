//Задача № 24
//Напишите программу которая на вход принимает число(А)
// и выдает сумму чисел от 1 до (А).
Console.WriteLine("Введите число :");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;

while(number > 0)

{
    sum = sum + number % 10;
    number = number / 10;
}
Console.WriteLine(sum);
