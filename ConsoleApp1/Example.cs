using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("введите число: ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("четное число");

            }
            else
            {
                Console.WriteLine("нечетное");
            }



            Console.ReadKey();
        }
    }
}
