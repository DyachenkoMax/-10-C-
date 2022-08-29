using System;
class Hello {
  static void Main() {
      
   Console.Write("Введите пятизначное целое число x ");
    int x=int.Parse(Console.ReadLine());
    string str = x.ToString();
    if (str[0] == str [4] && str[1] == str [3])
    {
    Console.WriteLine("Введенное число является палиндромом ");
    }
    else
    {
    Console.WriteLine("Введенное число не является палиндромом ");
    }
    }
  }
