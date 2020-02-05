using System;

namespace ClassExercise_02_04_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car myObj1 = new Car();
            Car myObj2 = new Car();
            Console.WriteLine(myObj1.color);
            Console.WriteLine(myObj2.color);

            //
            Cars Ford = new Cars();
            Ford.model = "Mustang";
            Ford.color = "red";
            Ford.year = 1969;

            Cars Opel = new Cars();
            Opel.model = "Astra";
            Opel.color = "white";
            Opel.year = 2005;

            Console.WriteLine(Ford.model);
            Console.WriteLine(Opel.model);


            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);


            Car3 newCar = new Car3();
            newCar.honk();
            Console.WriteLine(newCar.brand + " " + newCar.modelName);

            Pig x = new Pig();
            x.animalSound();
        }
    }
    class Car
    {
        public string model;
        public Car()
        {
            model = "mustang";
        }
        public string color = "red";//color would not be able to work in main function without "public" access
    }

    class MyClass
    {
        // Class members
        string color = "red";        // field
        int maxSpeed = 200;          // field
        public void fullThrottle()   // method
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }
    class Cars
    {
        public string model;
        public string color;
        public int year;
        public void fullThrottle()
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }

    class Car2
    {
        public string model;
        public string color;
        public int year;

        // Create a class constructor with multiple parameters
        public Car2(string modelName, string modelColor, int modelYear)
        {
            model = modelName;
            color = modelColor;
            year = modelYear;
        }

        
    }

    class Person
    {
        private string name; // field

        public string Name   // property
        { get; set; }  // set method
        
    }

    class Vehicle  // base class (parent) 
    {
        public string brand = "Ford";  // Vehicle field
        public void honk()             // Vehicle method 
        {
            Console.WriteLine("Tuut, tuut!");
        }
    }

    class Car3 : Vehicle  // derived class (child)
    {
        public string modelName = "Mustang";  // Car field
    }


}

