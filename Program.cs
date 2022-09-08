
Console.WriteLine("Введите b1 :");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите k1 :");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите b2 :");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите k2 :");
 double k2 = double.Parse(Console.ReadLine());
double x = (b2-b1)/(k1-k2);
double y = k1*x+b1;
Console.Write("Точка пересечения прямых имеет координаты X: ");
Console.Write(x);
Console.Write("  ; Y: ");
Console.Write(y);