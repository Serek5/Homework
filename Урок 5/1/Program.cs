//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// Диапазон трехзначных чисел, ввод случайный.

Console.WriteLine("Длинна входного массива");
int length = Convert.ToInt32(Console.ReadLine());//Ввели длину массива
int[] array = new int[length];//Создали массив, длина которого = Length
Random random = new Random();
for (int i = 0; i < length; i++)
{
    array[i] = random.Next(100,1000);//Заполняем массив происпольными числами
}
int PrintArray(int[] array)
{
    int count=0;
    for (int i =0;i<array.Length;i++)
        {
            if(array[i]% 2 == 0)
            count++;
            
        }
    return count;
}
Console.WriteLine(string.Join(",",array));
Console.WriteLine(PrintArray(array));