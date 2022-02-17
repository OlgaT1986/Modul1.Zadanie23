using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Modul1.Zadanie23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            FactorialAsync(n);
            Console.ReadKey();
        }
        //  void метод сразу выводит
        static void Factorial(int n) 
        {
            int k = 1;
            for (int i = 1; i <= n; i++)
            {
                k *= i;
                Thread.Sleep(20);  
            }
            Console.WriteLine("Факториал числа {0}! = {1}", n, k);
        }
        // метод асинхронный
        static async void FactorialAsync(int n)
        {
            // метод вызывает Fact(n), Run- на выходе получаем задачу 
            await Task.Run(() => Factorial(n));  
        }
    }
}
