using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] main = new int[10];
            for (int numbers = 1; numbers <= main.Length; numbers++)
            {
                Console.WriteLine("九九乘法表{0}:", numbers);
                for (int num0 = 1; num0 <= main.Length; num0++)
                {
                    Console.WriteLine(numbers + " X " + num0 + "=" + (numbers * num0), numbers);
                }
            }
        }
    }
}