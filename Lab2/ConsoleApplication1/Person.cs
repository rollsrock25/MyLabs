using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public string Occupation;
        public Car Transporter;

        public string GetFullName()
        {
            return FirstName + " " + LastName + " drives a " + Transporter.Model;
        }

    }
}

   
