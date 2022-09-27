//Задача № 21
//Напишите программу, которая на принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.
// A(3,6,8);  B(2,1,-7) --> 15,84 ;
// A(7,-5,0); B(1,-1,9) --> 11,53 ;
int x1 = 3;
int x2 = 2;
int y1 = 6;
int y2 = 1;
int z1 = 8;
int z2 = -7;


int res_x = (x2 - x1) * (x2 - x1);
int res_y = (y2 - y1) * (y2 - y1);
int res_z = (z2 - z1) * (z2 - z1);

int res = res_x + res_y + res_z;

double res1 = Math.Sqrt(res);
double res2 = Math.Round(res1, 2, MidpointRounding.ToZero);

Console.WriteLine(res2);

int x1_1 = 7;
int x2_1 = 1;
int y1_1 = -5;
int y2_1 = -1;
int z1_1 = 0;
int z2_1 = 9;


int res1_x = (x2_1 - x1_1) * (x2_1 - x1_1);
int res1_y = (y2_1 - y1_1) * (y2_1 - y1_1);
int res1_z = (z2_1 - z1_1) * (z2_1 - z1_1);

int res1_1 = res1_x + res1_y + res1_z;

double res2_1 = Math.Sqrt(res1_1);
double res3 = Math.Round(res2_1, 2, MidpointRounding.ToZero);
Console.WriteLine(res3);







