// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.Clear();
// Console.WriteLine("Введите пятизначное число x:");
// int x = Convert.ToInt32(Console.ReadLine());
// string Xstr = x.ToString(); 

// if (x>9999 && x<100000)
// {
//      if (Xstr[0]==Xstr[4] && Xstr[1]==Xstr[3])
//      Console.WriteLine($"Введенное число x={x} палиндром");
//      else 
//      Console.WriteLine($"Введенное число x={x} не палиндром");
// }
// else 
//  Console.WriteLine($"Число x={x} не пятизначное, введите корректное");




// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Clear();
// Console.Write("Введите координаты точки A: x=");
// int ax = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты точки A: y=");
// int ay = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты точки A: z=");
// int az = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты точки B: x=");
// int bx = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты точки B: y=");
// int by = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты точки B: z=");
// int bz = Convert.ToInt32(Console.ReadLine());

// double otrezok = Math.Round (Math.Sqrt(((bx-ax)*(bx-ax))+((by-ay)*(by-ay))+((bz-az)*(bz-az))));

// Console.WriteLine($"Расстояние между точками равно: {otrezok}");




// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.Clear();
// Console.Write ("Введите число N=");
// int N = Convert.ToInt32(Console.ReadLine());

// for (int i=0; i<N; i++, Console.WriteLine ($"{i*i*i}"))
// {
// }





// Задача 17 
// Напишите программу, которая на вход принимает координаты 
// точки ( Х и У), причем Х и У не равны 0 и выдает номер четверти 
// плоскости, в которой находится эта точка

// Console.Clear();
// Console.WriteLine("Введите координату x:");
// int x=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y:");
// int y=Convert.ToInt32(Console.ReadLine());

// if (x!=0 && y!=0)
// {
//      if (x>0 && y>0)
//      Console.WriteLine("Точка находится в 1 четверти");
//      if (x<0 && y>0)
//      Console.WriteLine("Точка находится во 2 четверти");
//      if (x<0 && y<0)
//      Console.WriteLine("Точка находится в 3 четверти");
//      if (x>0 && y<0)
//      Console.WriteLine("Точка находится в 4 четверти");
// }
// else
// Console.WriteLine("Какое-то из чисел = 0, замените координаты");


// Задача 18
// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (х и у)

Console.Clear();
Console.Write("Введите номер четверти от 1 до 4: ");
int x = Convert.ToInt32(Console.ReadLine());

string [] diapaz = {"x>0, y>0","x<0, y>0", "x<0, y<0", "x>0, y<0"};
int [] index = {1,2,3,4};
if (x==index [0]) Console.WriteLine (diapaz[0]);
else if (x==index [1]) Console.WriteLine (diapaz[1]);
else if (x==index [2]) Console.WriteLine (diapaz[2]);
else if (x==index [3]) Console.WriteLine (diapaz[3]);
else
Console.WriteLine("Неверное число, только от 1 до 4");

// ИЛИ
// if (x==1) Console.WriteLine("Диапазон координат Х>0 и У>0");
// else if (x==2) Console.WriteLine("Диапазон координат Х<0 и У>0");
// else if (x==3) Console.WriteLine("Диапазон координат Х<0 и У<0");
// else if (x==4) Console.WriteLine("Диапазон координат Х>0 и У<0");
// else
// Console.WriteLine("Неверное число, только от 1 до 4");

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2Д пространстве
// А (3,6); В (2,1)->5,09
// А (7,-5); В (1,-1)-> 7,21

// Console.Clear();
// Console.Write("Введите координаты точки A: x=");
// int ax = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты точки A: y=");
// int ay = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координаты точки B: x=");
// int bx = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координаты точки B: y=");
// int by = Convert.ToInt32(Console.ReadLine());


// double otrezok = Math.Round (Math.Sqrt(((bx-ax)*(bx-ax))+((by-ay)*(by-ay))));

// Console.WriteLine($"Расстояние между точками равно: {otrezok}");




// Задача 22
// Напишите программу, которая принимает на вход
// число N и выдает таблицу квадратов чисел от 1 до N
// 5-> 1,4,9,16,25
// 2-> 1,4

// Console.Clear();
// Console.Write ("Введите число N=");
// int N = Convert.ToInt32(Console.ReadLine());

// for (int i=0; i<N; i++, Console.WriteLine ($"{i*i}"))
// {
// }


//ИЛИ
// int i=1;
// while (i<=N)
// {
//      Console.Write($" {i*i} ,");
//      i++;
// }