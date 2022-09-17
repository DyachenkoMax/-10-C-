using System;
class HelloWorld {
   static void Main(string[] args) {
     {
            int[] array = new int[8];
            int countH = 0;
            Random myRandom = new Random();
 
            Console.WriteLine("Вывод случайного массива из 8ми положительных трехзначных элементов");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = myRandom.Next(100, 1000);
                Console.Write("{0} ", array[i]);
            }
            
            Console.WriteLine();
            
            Console.WriteLine($"Количество четных элементов в массиве: ");
            
            for (int i = 0; i < array.Length; i++)
            
            {
            if (array[i] % 2 == 0)
            {
                countH = countH + 1;
            }
            }
            Console.WriteLine(countH);
        }
  }
}
