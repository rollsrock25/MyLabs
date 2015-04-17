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
            int[] listOfNumbers;
            string[] listOfString;
            Person[] listOfPeople;

            listOfNumbers = new int[3];
            listOfString = new string[3];
            listOfPeople = new Person[2];

            listOfNumbers[0] = 25;
            listOfNumbers[1] = 36;
            listOfNumbers[2] = 47;

            /////////////////////////////////////////////////////////////////
            /////////////////////////////////////////////////////////////////

            Person[] listOfPeople;

            listOfPeople = new Person[2];

            listOfPeople[0] = new Person();

            for (int i = 0; i < 100; i++)
            {
                Console.Write(listOfNumbers[i]);
            }

            foreach (int number in listOfNumbers)
            {
                Console.Write(number);
            }

            string input = "x";

            while (input.Length > 0)
            {
                conso 
        }
    }
}
