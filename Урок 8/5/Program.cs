// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[] ArrayNums(string nums)
{
    string[] elemArr = nums.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] array = new int[elemArr.Length];
    for (int i = 0; i < elemArr.Length; i++)
    {
        array[i] = int.Parse(elemArr[i]);
    }
    return array;
}

int CountPositive(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

Console.Write("Введите числа чтерез пробел: ");

string elements = Console.ReadLine();

int[] arrayTwo = ArrayNums(elements);

Console.WriteLine($"В массиве [{String.Join(", ", arrayTwo)}] колличество чисел больше 0 равно {CountPositive(arrayTwo)}");


