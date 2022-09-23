// Напишите программу, которая на вход принимает координаты точки(x, y),
// причем x != 0 и y != 0 и выдает номер четверти плоскости, в которой
// находится эта точка.
Console.WriteLine("введите координаты точек");
Console.WriteLine("x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("y: ");
int y = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter (x, y);
string res = quarter > 0 ? $"указанные значения соответсвуют четверти -> {quarter.ToString()}" 
: "Введены некорректные координаты";
Console.WriteLine(res);

int Quarter (int xc, int yc)
{
if(x > 0 && y > 0)  return 1;
if(x < 0 && y > 0)  return 2;
if(x < 0 && y < 0)  return 3;
if(x > 0 && y < 0)  return 4;
return 0;
}