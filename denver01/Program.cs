//Задача № 9

//Напишите программу, которая выводит случайное число из отрезка [10. 99]
 //и показывает наибольшую цифру числа.

// 78 --> 8     12 --> 2       85 --> 8.

int number = new Random().Next(10, 100);
Console.WriteLine($"случайное число из отрека 10 -- 99 => {number}");
//int first = number / 10;
//int second = number % 10;


//if (first == second) Console.WriteLine("цифры одинаковые");
//else if(first > second) Console.WriteLine($"наибольшая цифра числа {number} =>{first}");
//else Console.WriteLine($"наибольшая цифра числа {number} =>{second}");

//int max = 0;
//if (first > second) max = first;
//else max = second;
//int max = first > second ? first : second; Тернальный оператор

int Max (int num) {
    int first = num / 10;
    int second = num % 10;
    //if(first > second) return first; return second;
    if(isEqul(first, second)) return -1;
    return first > second ? first : second; 
}
bool isEqul(int num1, int num2){
    return num1 == num2;
}
int max = Max(number);
string result = max != -1 ? max.ToString() : "цифры одинаковые";
Console.WriteLine($"наибольшая цифра числа {number} => {max}");




