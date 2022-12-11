// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 69.4 -22 0.4 78] ->56
Console.WriteLine("Длинна входного массива");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
Random random = new Random();
for (int i = 0; i < length; i++)
{
    array[i] = random.Next(0,10);
}
int DiffMaxMin(int[] array)
{
    int i=1,diff=0,max=array[0],min=array[0];
    for (i=1;i<array.Length;i++)
    {
        if (array[i]>max)
            max=array[i];
        if (array[i]<min)
            min=array[i];
    }
    diff=max-min;
    return diff;
}
Console.WriteLine(string.Join(",",array));
Console.WriteLine(DiffMaxMin(array));