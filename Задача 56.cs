using System;
class HelloWorld {
  static void Main() {
      
    Console.WriteLine("Задайте количество строк двумерного массива m:");
    int m = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Задайте количество столбцов двумерного массива n, чтобы m не было равно n:");
    int n = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine();
    
    int[,] Array = new int[m, n];
    Random myRandom = new Random();
    

        { for (int i = 0; i < m; i++)
         { for (int j = 0; j < n; j++)
         { Array[i,j] = myRandom.Next( 0, 10);
           Console.Write($"{Array[i, j]} ");}
         Console.WriteLine();}}
         
         Console.WriteLine();
    
   {
    int MinIndRow = 0;
    int MinSumRow = 0;
    int SumRow = 0;
    for (int i = 0; i < Array.GetLength(1); i++)
    {
        MinIndRow += Array[0, i];
    }
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++) SumRow += Array[i, j];
        if (SumRow < MinIndRow)
        {
            MinIndRow = SumRow;
            MinSumRow = i;
        }
        SumRow = 0;
    }
    Console.Write($"{MinSumRow + 1} строка");
}
            }
}
