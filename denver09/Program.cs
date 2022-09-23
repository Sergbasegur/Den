// Задача № 20
// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.
// A(3, 6);  B(2, 1) -> 5, 09
// A(7, -5); B(1, -1) -> 7,21
Console.WriteLine("введите точку X1 :");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку Y1 :");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите точку X2 :");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите точку Y2 :");
int y2 = Convert.ToInt32(Console.ReadLine());



int res_x = (x2 -x1) * (x2 - x1);
int res_y = (y2 - y1) * (y2 - y1);
int res = res_x + res_y;
double res1 = Math.Sqrt(res);
double res2 = Math.Round(res1, 2, MidpointRounding.ToZero);

Console.WriteLine(res2);