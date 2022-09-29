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
         
         Console.WriteLine();
    
   for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int k = 0; k < Array.GetLength(1) - 1; k++)
            {
                if (Array[i, k] < Array[i, k + 1])
                {
                    int temp = Array[i, k + 1];
                    Array[i, k + 1] = Array[i, k];
                    Array[i, k] = temp;
                }
            }
        }
    }
    
     for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j]} ");
        }
        Console.WriteLine();
    }
            }
}
