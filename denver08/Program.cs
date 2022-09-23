// Задача № 18
// Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой четверти(X и Y).

Console.WriteLine("Введите номер четверти");
string hetvert = Console.ReadLine();

String range = FindRange(hetvert);
Console.WriteLine(range);

String FindRange(string num)
   {
    string phrase = "Диапазон координат находится в пределах";
 if(num == "1")  return $"{phrase} x > 0 и y > 0";  
 if(num == "2")  return $"{phrase} x < 0 и y > 0";
 if(num == "3")  return $"{phrase} x < 0 и y < 0";  
 if(num == "4")  return $"{phrase} x > 0 и y < 0"; 
  return "0";
  }






