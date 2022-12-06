// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Console.Write("Введи трёхзначное число: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(Number);

// if (stringNumber.Length > 2)
//     Console.WriteLine("третья цифра " + stringNumber[2] );

// else 
//     Console.WriteLine("Третьей цифры нет ");

int result = 0;
int number = Convert.ToInt32(Console.ReadLine());
if (number > 999)
    while (number >999)
        number = number / 10;
else if (number < 1000 && number >99)
        result = number % 10;
Console.WriteLine(result);
