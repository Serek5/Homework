// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.Write("Введи трёхзначное число: ");
// int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(threeDigitNumber);
// Console.WriteLine("2-я цифра ->" +stringNumber[1]);

int number = Convert.ToInt32(Console.ReadLine());
if ((number < 1000 && number > 99) || (number > -1000 && number < -99))
{
    number = number / 10 % 10;
    Console.WriteLine(number);
}
else 
    Console.WriteLine("error");