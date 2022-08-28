using System;
class HelloWorld {
  static void Main() {
    Console.Write("Введите целое трёх значное число x ");
    int x=int.Parse(Console.ReadLine());
    int x1 = (x%100)/10;
    Console.WriteLine("Второе число "+x1);
  }
}
