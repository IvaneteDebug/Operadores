using System;

namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Operadores matematicos

            //int num1 = 15;
            //int num2 = 2;

            //int resultado = num1 + num2;

            //Console.WriteLine(num1 + num2);
            //Console.WriteLine(num1 - num2);
            //Console.WriteLine(num1 * num2);
            //Console.WriteLine(num1 / num2);
            //Console.WriteLine(num1 % num2);
            //Console.ReadKey();
            #endregion

            int num1 = 100;
            int num2 = 10;
            int num3 = 5;

            int res = (num1 + num2) * num3 / 2;

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
