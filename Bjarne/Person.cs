using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bjarne
{
    internal class Person
    {
        string name;
        int age;
        string hobbies;


        public Person(string personName, int personAge, string personHobbies)
        {
            name = personName;
            age = personAge;
            hobbies = personHobbies;
        }

        public void printText()
        {
            Console.WriteLine($"Jeg heter {name}, og jeg er {age} ung. På fritiden liker jeg å {hobbies}.");
        }
    }
}
