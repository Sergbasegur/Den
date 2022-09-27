// Задача 1
// Напишите программу, которая принимает на вход пятизначное число и 
//проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число :");
string text = Console.ReadLine();
int lenght = text.Length;
bool f = true;
for(int i = 0; i < lenght/2; i++)
{
    if(text[i] != text[lenght -(i + 1)])
    {
        f = false;
        break;
    }
}
if(f)
{
    Console.WriteLine($"Это число --> {text} является полиндромным" );
}
else
{
    Console.WriteLine($"Это число --> {text}  Не является полиндромным");
}















