using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace oopbase
{
     class Car
    {
            String model;
            String make;
            String color;
            int year;

            public Car(String model, String make, String color, int year)
            {
                this.model = model;
                this.make = make;
                this.color = color;
                this.year = year;
            }

            public void infoCar()
            {
                Console.WriteLine("Info: " + model + make + color + year);
            }
    }
}
