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

            string firstName;
            char middleinitial;
            string lastName; 
            string fullname;
            int age;
            bool iscitizen;
            bool canvote;
            int heightfeet;
            double heightinches;
            double totalheightcm;

            firstName = "Jesse";
            middleinitial = 'A';
            lastName = "Carter";
            fullname = firstName + middleinitial + "." + lastName;

            age = 29;
            heightfeet = 6;
            heightinches = 10.5;
            double totalinches = heightfeet * 12 + heightinches;
            totalheightcm = 2.54 * totalinches;

            iscitizen = true;
            canvote = iscitizen && age >= 18; 
            














            
        }
    }
}
