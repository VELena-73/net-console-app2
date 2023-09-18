using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("введите число: ");
           int check_number = Convert.ToInt32(Console.ReadLine());
            Example.CheckEvenNumber(check_number);
        }
    }
}