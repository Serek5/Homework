// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
 Console.Write("Число 1: ");
  int number1 = Convert.ToInt32(Console.ReadLine());
  Console.Write("Число 2: ");
  int number2 = Convert.ToInt32(Console.ReadLine());

int Degree(int number1, int number2)
{
  int result = 1;
  for(int i=1; i <= number2; i++)
      result = result * number1;
         return result;
}
  int Degree1 = Degree(number1, number2);
  Console.WriteLine("Ответ: " + Degree1);