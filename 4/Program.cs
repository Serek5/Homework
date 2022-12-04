// Задача 16 - Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.


Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

    if (a%b == 0 || b%a ==0)
        {
        Console.Write("Кратно ");
         }
else
    
        Console.Write("не кратно");