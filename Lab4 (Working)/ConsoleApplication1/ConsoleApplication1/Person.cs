using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Person
    {
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;

        public static Person Create(string prefix)
        {
            Question.SetPromptPrefix(prefix);

            Person person = new Person();
            person.FirstName = Question.AskForString("what is your first name?");
            person.LastName = Question.AskForString("what is your last name?");
            person.Age = Question.AskForInteger("how old are you?");

            if (Question.AskForBoolean("are you married?"))
            {
                person.Spouse = new Person();
                person.Spouse.FirstName = Question.AskForString("what is the first name of your spouse?");
                person.Spouse.Age = Question.AskForInteger("what is the age of your spouse?");
                person.Spouse.LastName = person.LastName;
                person.Spouse.Spouse = person;
            }

            return person;
        }
    }
}

