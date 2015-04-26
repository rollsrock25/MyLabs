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
            bool done = false;

            while (!done)
            {

                Course course = new Course();
                

                Console.WriteLine("What is course name? ");
                course.Name = Console.ReadLine();
                Console.WriteLine("What is course number? ");
                course.ID = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("How many students in the course? ");
                int NumPupils = Convert.ToInt32(Console.ReadLine());

                Course.Pupils = new Student [NumPupils];


                for (int i = 0; i < NumPupils; i++)
                {
                    Course.Pupils [i] = new Student();
                }
    
                Console.ReadLine();

                Console.Write("Done? ");
                done = Console.ReadLine().StartsWith("y");
            }
        }
    }
}
