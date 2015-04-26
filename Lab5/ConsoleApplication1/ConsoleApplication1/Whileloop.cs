using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Whileloop
    {
        static void Main(string[] args)
        {
            bool done = false;

            while (!done)
            {
                Console.Write("Done? ");
                done = Console.ReadLine().StartsWith("y");
    }

}
