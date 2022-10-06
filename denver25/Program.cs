// Задача № 42
// Напишите программу, которая будет преобразовывать 
// десятичное число в двоичное.
// 45 --> 101101
// 3 --> 11
// 2 --> 10

int number = 10;
ConvertToBin2(number);

void ConvertToBin2(int num)
{
    if(num == 0) return;
    ConvertToBin2(num / 2);
    Console.Write(num % 2);
}



