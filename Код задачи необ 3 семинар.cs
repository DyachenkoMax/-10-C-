using System;
class HelloWorld {
  static void Main() {
      {
          int sum = 0;
          int res = 0;
            do
            {
                Console.Write("Введите число ");
                int x = int.Parse(Console.ReadLine());
                sum = sum + x;
                res = res + x*x;
            }
            while (sum != 0 );
        {
    Console.WriteLine(""+res);
    }
    }
}
}
