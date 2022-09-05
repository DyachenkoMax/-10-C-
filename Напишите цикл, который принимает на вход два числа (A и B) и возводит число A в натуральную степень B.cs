using System;
class HelloWorld {
  static void Main() {
    {
      
    Console.Write("Введите целое число x ");
    double x = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите целое число a ");
    int a = int.Parse(Console.ReadLine());
        { Console.WriteLine("x в степени a = " + Math.Pow(x, a));
        }
  }
}
}
