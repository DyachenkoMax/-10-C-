using System;
class HelloWorld {
  static void Main() {
    Console.Write("Введите k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = double.Parse(Console.ReadLine());

double x = (b1-b2)/(k2-k1);
double y = (k2 * x + b2);

Console.WriteLine($"Точка пересечения: ({x};{y})");

//y = k1 * x + b1
//y = k2 * x + b2
//k2 * x + b2=k1 * x + b1
//k2 * x-k1 * x=b1 - b2
//x(k2-k1)=b1-b2
//x=(b1-b2)/(k2-k1)
  }
}
