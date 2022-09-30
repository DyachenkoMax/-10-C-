using System;
class HelloWorld {
  static void Main() {
      
    Console.WriteLine("Задайте количество строк матрицы 1:");
    int rowsM1 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Задайте количество столбцов матрицы 1:");
    int columsM1 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine();
    
    int[,] Matrix1 = new int[rowsM1, columsM1];
    Random my1Random = new Random();
    

        { for (int i = 0; i < rowsM1; i++)
         { for (int j = 0; j < columsM1; j++)
         { Matrix1[i, j] = my1Random.Next( 1, 10);
           Console.Write($"{Matrix1[i, j]} ");}
         Console.WriteLine();}}
         
         Console.WriteLine();
    
    //Создаем Матрицу 2 
    
    Console.WriteLine("Задайте количество строк матрицы 2:");
    int rowsM2 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Задайте количество столбцов матрицы 2:");
    int columsM2 = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine();
    
    int[,] Matrix2 = new int[rowsM2, columsM2];
    Random my2Random = new Random();
    

        { for (int i = 0; i < rowsM2; i++)
         { for (int j = 0; j < columsM2; j++)
         { Matrix2[i, j] = my2Random.Next( 1, 10);
           Console.Write($"{Matrix2[i, j]} ");}
         Console.WriteLine();}}
         
         Console.WriteLine();
         
   //Проверяем одинаково ли количество строк и стобцов в матрицах, и если да, то создаем третюю матрицу которая будет результатом умножения
   //формула умножения матриц 
   
   if (Matrix1.GetLength(0) != Matrix2.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}

int[,] resultMatrix = new int[rowsM1, columsM1];

for (int i = 0; i < Matrix1.GetLength(0); i++)
{
    for (int j = 0; j < Matrix2.GetLength(1); j++)
    {
        resultMatrix[i, j] = 0;
        for (int k = 0; k < Matrix1.GetLength(1); k++)
        {
            resultMatrix[i, j] += Matrix1[i, k] * Matrix2[k, j];
        }
    }
}

  for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            Console.Write($"{resultMatrix[i, j]} ");
        }
        Console.WriteLine();
    }
    
    
            }
}
