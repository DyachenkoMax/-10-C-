using System;
class HelloWorld {
   static void Main(string[] args) {
     {
            int[] array = new int[8];
            int sum = 0;
            Random myRandom = new Random();
 
            Console.WriteLine("Вывод случайного оlномерного массива, заполненного случайными числами (от -10 до 10)");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = myRandom.Next(-10, 10);
                Console.Write("{0} ", array[i]);
            }
            
            Console.WriteLine();
            
            Console.WriteLine($"Сумма элементов стоящих на нечетных позициях ");
            
            for (int i = 1; i < array.Length; i = i + 2)
            
            {
            sum = sum + array[i];
            }
            Console.WriteLine(sum);
        }
  }
}
