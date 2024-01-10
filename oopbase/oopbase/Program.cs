namespace oopbase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Messages.greeting();
            //Messages.bye();

            Human testHuman = new Human("Jack", 38);
            //testHuman.name = "Jack";
            //testHuman.age = 37;

            testHuman.Eat();
            testHuman.Age();

            Human human1 = new Human("Marty", 22);
            //human1.name = "Marty";
            //human1.age = 22;

            human1.Eat();
            human1.Age();

            Car ford = new Car("Mustang", "Henry", "Black", 1987);
            ford.infoCar();

            Car car2 = new Car("Chevy", "Corvet", "Yellow", 2001);
            car2.infoCar();


            Employee employee1 = new Employee("Alice", 28, "Software Engineer");
            employee1.Eat();
            employee1.Age();
            employee1.Work();

            Console.ReadLine();
        }

        class Employee : Human
        {
            private string jobTitle;

            public Employee(string name, int age, string jobTitle)
                : base(name, age)
            {
                this.jobTitle = jobTitle;
            }

            public void Work()
            {
                Console.WriteLine(name + " is working as a " + jobTitle);
            }
        }
    }
}
