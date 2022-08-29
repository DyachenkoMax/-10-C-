using System;
class HelloWorld {
  static void Main() {
        
        Console.Write("Введите координату x первой точки ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координату y первой точки ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координату z первой точки ");
        double z1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координату x второй точки ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координату y второй точки ");
        double y2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координату z второ точки ");
        double z2 = Convert.ToDouble(Console.ReadLine());
        double res = Math.Sqrt((x2-x1) * (x2-x1) + (y2-y1) * (y2-y1) + (z2-z1) * (z2-z1));
    
    Console.WriteLine(res);
  }
}
