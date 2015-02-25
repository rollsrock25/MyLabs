using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person A = new Person();
            A.FirstName = "Jesse";
            A.LastName = "Carter";
            A.Age = 29;
            A.Occupation = "IT";

            Person B = new Person();
            B.FirstName = "Megan";
            B.LastName = "Eliser";
            B.Age = 23;
            B.Occupation = "Manager";

            Car C = new Car();
            C.Year = 2005;
            C.Make = "Mini";
            C.Model = "Cooper";
            C.Color = "Blue";

            Car D = new Car();
            D.Year = 2014;
            D.Make = "Chevy";
            D.Model = "Cobalt";
            D.Color = "Black";

            A.Transporter = C;
            B.Transporter = D; 

            Console.WriteLine(A.GetFullName());
            Console.WriteLine(B.GetFullName());
            Console.ReadLine();

        }
    }
}
