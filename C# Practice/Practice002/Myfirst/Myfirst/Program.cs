using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myfirst
{
    class Program
    {
        static void Main(string[] args)
        {
            string ProductName;
            int Price;
            Console.Write("Product Name:");
            ProductName = Console.ReadLine();
            Console.Write("Price:");
            Price = int.Parse(Console.ReadLine());
            Console.WriteLine("ProdutName:{0} Price:{1} This Program is saved success",ProductName,Price);
            Console.Read();        }
    }
}
