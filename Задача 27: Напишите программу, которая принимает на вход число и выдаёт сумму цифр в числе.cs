using System;
class HelloWorld {
  static void Main() {
    Console.Write("Введите целое число x ");
    int x = int.Parse(Console.ReadLine());
            int s = 0;
            while (x > 0)
            {
                s = s + x % 10;
                x = x /10 ;
            }
 Console.WriteLine(s);
  }
}
