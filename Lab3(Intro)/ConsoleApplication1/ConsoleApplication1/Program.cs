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
            Console.Write("ENter a number ---> ");
            int input = int.Parse(Console.ReadLine());

            if (input >=1)
            {
                Console.WriteLine("Greater than or equal to 1.");

                if (input <=99)
                {
                    Console.WriteLine("Between 1 and 99");
        }
    }
}
