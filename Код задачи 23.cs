using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("Введите число ");
    double N = Convert.ToDouble(Console.ReadLine());
    for (int i = 1; i< (N+1); i++)
    { Console.Write($"{i*i*i} ,");
    }
  }
}
