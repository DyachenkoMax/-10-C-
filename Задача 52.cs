using System;
class HelloWorld {
  static void Main() {
      
    Console.WriteLine("Задайте количество строк двумерного массива m:");
    int m = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Задайте количество столбцов двумерного массива n:");
    int n = Convert.ToInt32(Console.ReadLine());
    
    int[,] Array = new int[m, n];
    Random myRandom = new Random();
    

        { for (int i = 0; i < m; i++)
         { for (int j = 0; j < n; j++)
         { Array[i,j] = myRandom.Next( 0, 10);
           Console.Write($"{Array[i, j]} ");}
         Console.WriteLine();}}
    
   for (int i = 0; i < n; i++) 
            {
                int srAr = 0;
                
                for (int t = 0; t < n; t++)
                {
                    srAr += Array[t,i];
                }
                Console.WriteLine($"Cреднее арифметическое элементов столбца {i + 1} = {(float)srAr/n}"); 
            }

  }
