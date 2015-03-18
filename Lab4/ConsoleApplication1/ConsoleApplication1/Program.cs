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
            person jesse = new person();
            Jesse.FirstName = "Jesse";
            Jesse.LastName = "Carter";

            jesse.ClearFirstAndLastName();

            int sum = jesse.AddTwoIntegers(5, 10);
            int sum2 = jesse.AddTwoIntegers(6, 11);

            Console.WriteLine(jesse.GetFullName());
            Console.ReadKey();



        }
    }
}
