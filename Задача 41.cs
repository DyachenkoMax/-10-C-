using System;
class HelloWorld {
   static void Main(string[] args) {
     {      int countH = 0;
            string a;
            int[] b = new int[100];
            int i=0;
            
            Console.WriteLine("Введите элементы массива, по окнчанию нажмите enter");
            while ((a = Console.ReadLine()) != "") //вводим строку (массив) пока пользователь не нажмет энтер
            b[i++] = Convert.ToInt32(a); 
            
            Console.WriteLine($"Количество элементов боьше нуля в массиве: ");
            
            for (int k = 0; k < i; k++)
            
            {
            if (b[k] > 0)
            {
                countH = countH + 1;
            }
            }
            Console.WriteLine(countH);
        }
  }
}
