using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace ConsoleApplication1
{
   public class Example
    {
        public static void CheckEvenNumber(int check_number)
        {
            
         //   Console.WriteLine("введите число: ");
           // check_number = Convert.ToInt32(Console.ReadLine());

            if (check_number % 2 == 0)
            {
                Console.WriteLine("четное число");

            }
            else
            {
                Console.WriteLine("нечетное число");
            }



            Console.ReadKey();
        }

    }
}
