// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.WriteLine("Длинна входного массива");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = new int[length];
Random random = new Random();
for (int i = 0; i < length; i++)
{
    array[i] = random.Next(-100,1000);
}
int PrintArray(int[] array)
{
    int summ=0;
       for (int i =0;i<array.Length;i++)
        {
           if(i%2==1)
                summ = summ +array[i]  ;
                   
        }
    return summ;
}
Console.WriteLine(string.Join(",",array));
Console.WriteLine(PrintArray(array));