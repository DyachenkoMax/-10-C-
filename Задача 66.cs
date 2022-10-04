using System;
class HelloWorld {
  static void Main() {
    Console.Write("Введи N: ");
        int N = Convert.ToInt16(Console.ReadLine());
        Console.Write("Введи M: ");
        int M = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine($"N={N}, M={M}");
        Console.WriteLine();
            int S = 0;
            while (N <= M)
            {
                S = S + N ;
                N = N + 1 ;
            }
             Console.WriteLine( "сумма натуральных элементов в промежутке от M до N = " + S);
                        }
  }
