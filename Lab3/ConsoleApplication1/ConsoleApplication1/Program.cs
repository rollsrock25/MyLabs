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
            double ChildMatinee;                                          // Variables
            ChildMatinee = 3.99;
            double AdultMatinee;
            AdultMatinee = 5.99;
            double SeniorMatinee;
            SeniorMatinee = 4.50; 

            double ChildEvening;
            ChildEvening = 6.99;
            double AdultEvening;
            AdultEvening = 10.99;
            double SeniorEvening;
            SeniorEvening = 8.50;

            Console.Write("Number of Child Matinee tickets?: ");         // Display 
            ChildMatinee = double.Parse(Console.ReadLine());             // Input 
            Console.Write("Number of Child Evening tickets?: ");
            ChildEvening = double.Parse(Console.ReadLine());             
            Console.Write("Number of Adult Matinee tickets?: ");
            AdultMatinee = double.Parse(Console.ReadLine());
            Console.Write("Number of Adult Evening tickets?: ");
            AdultEvening = double.Parse(Console.ReadLine());
            Console.Write("Number of Senior Matinee tickets?: ");
            SeniorMatinee = double.Parse(Console.ReadLine());
            Console.Write("Number of Senior Evening tickets?: ");
            SeniorEvening = double.Parse(Console.ReadLine());

            double tickettotal;                                                    // Variable
            tickettotal = (3.99 * ChildMatinee) + (6.99 * ChildEvening)
                + (5.99 * AdultMatinee) + (10.99 * AdultEvening) + 
                (4.50 * SeniorMatinee) + (8.50 * SeniorEvening);
            
            
            if (tickettotal > 0)
            {
                if (ChildMatinee > 0)                                         // Nested if statements
                {
                    Console.WriteLine(3.99 * ChildMatinee);
                }
                if (ChildEvening > 0)
                {
                    Console.WriteLine(6.99* ChildEvening); 
                }
                if (AdultMatinee > 0)
                {
                    Console.WriteLine(5.99*AdultMatinee);
                }
                if (AdultEvening > 0)
                {
                    Console.WriteLine(10.99*AdultEvening);
                }
                if (SeniorMatinee > 0)
                {
                    Console.WriteLine(4.50 * SeniorMatinee);
                }
                if (SeniorEvening > 0)
                {
                    Console.WriteLine(8.50*SeniorEvening);
                }
                Console.WriteLine("Your total for the tickets will be: " + (tickettotal));          //result1
            }

            double smallSoda;                                           //concessions variables
            smallSoda = 6.99;
            double largeSoda;
            largeSoda = 5.99;
            double hotdog;
            hotdog = 3.99;
            double popcorn;
            popcorn = 4.50;
            double candy;
            candy = 1.99;
            
            Console.Write("How many small sodas?: ");
            smallSoda = double.Parse(Console.ReadLine());
            Console.Write("How many large sodas?: ");
            largeSoda = double.Parse(Console.ReadLine());
            Console.Write("How many hotdogs?: ");
            hotdog = double.Parse(Console.ReadLine());
            Console.Write("How many delicious popcorns?: ");
            popcorn = double.Parse(Console.ReadLine());
            Console.Write("How many boxes of candy?: ");
            candy = double.Parse(Console.ReadLine());

            double concessiontotal;                                         //concessions
            concessiontotal = ((3.50 * smallSoda) + (5.99 * largeSoda) 
                + (3.99 * hotdog) + (4.50 * popcorn) + (1.99 * candy));

            if (concessiontotal > 0)
            {
                if (smallSoda > 0)                                         //if statements (nested)
                {
                    Console.WriteLine(3.50*smallSoda);
                }
                if (largeSoda > 0)
                {
                    Console.WriteLine(5.99*largeSoda);
                }
                if (hotdog > 0)
                {
                    Console.WriteLine(3.99*hotdog);
                }
                if (popcorn > 0)
                {
                    Console.WriteLine(4.50*popcorn);
                }
                if (candy > 0)
                {
                    Console.WriteLine(1.99*candy);
                }

                Console.WriteLine("Your total for concessions will be: " + (concessiontotal));      //result2
            }
            Console.WriteLine("Final cost: " + (tickettotal+concessiontotal));

         


            Console.ReadLine();
        }

        bool y = true;

        if (

           


       
        }
    }
