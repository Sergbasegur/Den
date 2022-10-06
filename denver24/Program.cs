// Задача № 40
// Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник со сторонами такой длины.

// Теорема о неравенстве треугольника - каждая сторона треугольника
// меньше сумму двух других сторон

Console.WriteLine("Введите длину отрезка АB");
int ab = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину BC");
int bc = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину отрезка CA");
int ca = Convert.ToInt32(Console.ReadLine());

if((ab < bc + ca) && (bc < ca + ab) && (ca < ab + bc) == true)
{
   Console.WriteLine($"треугольник со сторонами ab = {ab}, bs = {bc}, ca = {ca} существует");
}  
else 
{
    Console.WriteLine($"треугольник со сторонами ab = {ab}, bs = {bc}, ca = {ca}  не существует");
}




