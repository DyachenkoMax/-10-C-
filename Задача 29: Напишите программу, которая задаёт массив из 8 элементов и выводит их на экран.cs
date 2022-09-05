using System;
class HelloWorld {
  static void Main() {
     {
            int[] array = new int[8];
            Random myRandom = new Random();
 
            Console.WriteLine("Вывод случайного массива из 8ми элементов");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = myRandom.Next(0, 8);
                Console.Write("{0} ", array[i]);
            }
        }
  }
}
