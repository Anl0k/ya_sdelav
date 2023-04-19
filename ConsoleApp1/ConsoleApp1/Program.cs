using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Funco;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа через пробел:");
            var a = Console.ReadLine();
            var param = a.Split(' ');
            var i = param.Length/2;
            string[] firstHalf = param.Take(i).ToArray();
            string[] secondHalf = param.Skip(i).ToArray();

            Class1.SumFunc(String.Join(", ", firstHalf), String.Join(", ", secondHalf));
        }
    }
}
