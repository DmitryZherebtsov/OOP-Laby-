﻿using System.Drawing;
using System.Reflection;

namespace fourConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  1. Інкапсуляція: Encapsulation
                Інкапсуляція означає збір в одному об'єкті код та дані, які з ним пов'язані.
            Це дозволяє обмежити доступ до деяких частин коду та даних, забезпечуючи більш 
            високий рівень безпеки та контролю.         
             
                Створіть клас "Банківський рахунок", який містить інформацію про баланс та методи
            для додавання та зняття коштів. Забезпечте інкапсуляцію, щоб інші класи не могли напряму
            звертатися до балансу, а лише через відповідні методи.
             */
            
            Bank account = new Bank();
            account.Deposit(1000.0m);
            account.Withdraw(750.0m);
            Console.WriteLine("Your balance is: " + account.GetBalance());
            account.Withdraw(750.0m);
            Console.WriteLine("Your balance is: " + account.GetBalance());
            

            /*  2.Спадкування: Inheritance
                Спадкування дозволяє створювати новий клас, використовуючи властивості та методи
            іншого класу. Це дозволяє використовувати та розширювати функціональність існуючих класів.

                Створіть базовий клас "Транспортний засіб" з властивістю "Швидкість" та методом "Рухатися()".
            Створіть похідні класи "Автомобіль" та "Велосипед", які додають власні характеристики та методи.
            */

            Car car = new Car { Model = "Toyota", Speed = 120 };
            car.Move();

            Bicycle bicycle = new Bicycle { PedalCadence = 90, Speed = 25 };
            bicycle.Move();


            /*  3.Поліморфізм:
                Поліморфізм дозволяє використовувати один і той же інтерфейс для обробки об'єктів різних класів.
            Це може бути використано через перевантаження методів або використання інтерфейсів.

                Створіть інтерфейс "Фігура" з методом "РозрахуватиПлощу()".Реалізуйте цей інтерфейс у класах 
            "Квадрат" та "Коло". Створіть список фігур та обчисліть їхню загальну площу, використовуючи 
            поліморфізм.
            */
            List<IShape> shapes = new List<IShape>
            {
                new Square { SideLength = 5 }

            };

            double totalArea = 0;

            foreach (var shape in shapes)
            {
                totalArea += shape.CalculateArea();
            }

            Console.WriteLine("Загальна площа: " + totalArea);

            /*4.Абстракція:
            Абстракція дозволяє приховувати деталі реалізації та надавати лише необхідні для
            використання інтерфейси. Це спрощує роботу програмістів та робить код більш зрозумілим.

            Створіть абстрактний клас "Фігура" з методом "ВивестиІнформацію()".Створіть конкретні
            класи "Прямокутник" та "Трикутник", які реалізують цей абстрактний клас.Кожен клас повинен
            мати свою реалізацію методу "ВивестиІнформацію()".
            */
            Rectangle rectangle = new Rectangle();
            rectangle.DisplayInformation();

            Triangle triangle = new Triangle();
            triangle.DisplayInformation();
        }
    }
}