// //  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.WriteLine("Введите день недели");
int day = Convert.ToInt32(Console.ReadLine());
switch (day)
{ 
    case 1:
        Console.WriteLine("этот день не выходной");
        break;
    case 2:
        Console.WriteLine("этот день не выходной");
        break;
    case 3:
        Console.WriteLine("этот день не выходной");
        break;
    case 4:
        Console.WriteLine("этот день не выходной");
        break;     
    case 5:
        Console.WriteLine("этот день не выходной");
        break;    
    case 6:
        Console.WriteLine("этот день выходной");
        break; 
    case 7:
        Console.WriteLine("этот день выходной");
        break; 
    default: Console.WriteLine("это вообще не день недели");
         break;
}