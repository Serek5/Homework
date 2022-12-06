// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
double x=0,y=0,x1=0,y1=0,z=0,z1=0,ab=0;
x = Convert.ToDouble(Console.ReadLine());
y = Convert.ToDouble(Console.ReadLine());
z = Convert.ToDouble(Console.ReadLine());
x1 = Convert.ToDouble(Console.ReadLine());
y1 = Convert.ToDouble(Console.ReadLine());
z1 = Convert.ToDouble(Console.ReadLine());
ab=Math.Sqrt(Math.Pow((x1-x),2)+Math.Pow((y1-y),2)+Math.Pow((z1-z),2));
ab=Math.Round(ab,2);
Console.WriteLine(ab);
