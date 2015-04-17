
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        ///////////////////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////

        static void Main(string[] args)
        {
            AverageAge averageAge = new AverageAge();
            averageAge.AddPerson(Person.Create("Person #1"));
            averageAge.AddPerson(Person.Create("Person #2"));
            averageAge.AddPerson(Person.Create("Person #3"));
            Console.WriteLine("Average Age: " + averageAge.Get());
            Console.ReadKey();
        }
    }
}
