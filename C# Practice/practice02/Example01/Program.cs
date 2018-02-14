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
            Console.Write("使用者名稱");
            string userName = Console.ReadLine();
            Console.Write("PassWord");
            string userPassword = Console.ReadLine();
            Console.WriteLine("{0} 您好,登入成功", userName);

            int sec = (397375 / 1000) % 60;
            int min = (397375 / 1000 / 60) % 60;
            int hr = (397375 / 1000 / 60 / 60) % 24;

            Console.WriteLine(sec + "," + min + "," + hr);
        }
    }
}