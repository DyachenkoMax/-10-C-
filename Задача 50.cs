using System;
class HelloWorld {
  static void Main() {
      
    Console.WriteLine("Задайте количество строк двумерного массива m:");
    int m = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Задайте количество столбцов двумерного массива n:");
    int n = Convert.ToInt32(Console.ReadLine());
    
    double[,] Array = new double[m, n];
    Random myRandom = new Random();
    

        { for (int i = 0; i < m; i++)
         { for (int j = 0; j < n; j++)
         { Array[i,j] = myRandom.Next( -100, 100);
           Console.Write($"{Array[i, j]} ");}
         Console.WriteLine();}}
         
    Console.WriteLine("Введите координаты");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());

         if (a>m || b>n)
            Console.WriteLine("такого числа в массиве нет");
         else
             {
             double c = Array[a,b];
             Console.WriteLine("Число на этих координатах" + c);
             }

  }
}
