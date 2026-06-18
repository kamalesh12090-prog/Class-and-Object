using System;

namespace ClassAndObjectTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine("   PART 1: WHY DO WE NEED CLASSES?");
            Console.WriteLine("=========================================");
            WhyClassesAreNeeded();

            Console.WriteLine("\n=========================================");
            Console.WriteLine("   PART 2: CLASS & OBJECT SYNTAX");
            Console.WriteLine("=========================================");
            ClassSyntaxDemo();

            Console.WriteLine("\n=========================================");
            Console.WriteLine("   PART 3: MULTIPLE OBJECTS, SAME CLASS");
            Console.WriteLine("=========================================");
            MultipleObjectsDemo();
        }

        static void WhyClassesAreNeeded()
        {
            string carName1 = "Honda City";
            int carSpeed1 = 0;

            string carName2 = "Hyundai i20";
            int carSpeed2 = 0;

            carSpeed1 += 20;
            carSpeed2 += 30;

            Console.WriteLine("Without a class:");
            Console.WriteLine($"  {carName1} speed = {carSpeed1}");
            Console.WriteLine($"  {carName2} speed = {carSpeed2}");

            Car car1 = new Car("Honda City");
            Car car2 = new Car("Hyundai i20");

            car1.Accelerate(20);
            car2.Accelerate(30);

            Console.WriteLine("\nWith a class:");
            car1.DisplayStatus();
            car2.DisplayStatus();
        }

        static void ClassSyntaxDemo()
        {
            Car myCar = new Car("Tata Nexon");

            myCar.Accelerate(45);
            myCar.DisplayStatus();

            Console.WriteLine($"Reading property directly: myCar.Name = {myCar.Name}");
        }

        static void MultipleObjectsDemo()
        {
            Car[] cars = new Car[]
            {
                new Car("Maruti Swift"),
                new Car("Kia Seltos"),
                new Car("Mahindra XUV700")
            };

            cars[0].Accelerate(10);
            cars[1].Accelerate(60);
            cars[2].Accelerate(35);

            foreach (Car car in cars)
            {
                car.DisplayStatus();
            }
        }
    }

    public class Car
    {
        public string Name { get; private set; }
        public int Speed { get; private set; }

        public Car(string name)
        {
            Name = name;
            Speed = 0;
        }

        public void Accelerate(int amount)
        {
            Speed += amount;
        }

        public void Brake(int amount)
        {
            Speed = Math.Max(0, Speed - amount);
        }

        public void DisplayStatus()
        {
            Console.WriteLine($"  {Name} -> Speed: {Speed} km/h");
        }
    }
}