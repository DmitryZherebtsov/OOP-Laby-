using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopbase
{
    internal class Human
    {
        public String name;
        public int age;

        public Human(String nameHuman, int ageHuman)
        {
            this.name = nameHuman;
            this.age = ageHuman;
        }

        public void Eat()
        {
            Console.WriteLine(name + " is eating");
        }
        public void Age()
        {
            Console.WriteLine(name + " is " + age + "y.o.");
        }
    }
}
