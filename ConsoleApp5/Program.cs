using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        /// <summary>
        ///  Найти минимальную величину их трех целых переменных a, b, c 
        ///  с использованием вспомогательных методов (ввода аргументов, нахождения минимальной величины, вывода результата).
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Min(int a, int b)
        {
            return a < b ? a : b;
        }
        public static int Input(string message)
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine());
        }
        public static void Output(int result)
        {
            Console.WriteLine(result); 
        }
        static void Main(string[] args)
        {
            int a = Input("a=");
            int b = Input("b=");
            int c = Input("c=");
            int result = Min(Min(a, b), c);
            Output(result);
            Console.ReadLine();
        }
    }
}
  