using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class AverageAge
    {
        private int sumofages;
        private int totalpeople;

        public void Addperson(Person person)
        {
            totalpeople++;
            sumofages += person.Age;

            if (person.Spouse != null)
            {
                totalpeople++;
                sumofages += person.Spouse.Age;
            }
        }

        public double Get()
        {
            return (double)sumofages / (double)totalpeople;
        }
    }
}