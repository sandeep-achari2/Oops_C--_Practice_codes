using System;

namespace Inheritance_Practice_28_02_25
{
    //1.  
    //class Program
    //{
    //    static void Main()
    //    {
    //        Car myCar = new Car("Toyota", 180, "Nexon");
    //        myCar.ShowCarInfo();

    //        Console.WriteLine();

    //        Bike myBike = new Bike("Yamaha", 120, true);
    //        myBike.ShowBikeInfo();
    //    }
    //}

    //2 code snippets above are from Vechile2.cs
    //class Program
    //{
    //    static void Main()
    //    {
    //        Car myCar = new Car("Toyota", 100, "Nexon");
    //        Console.WriteLine("Car Info:");
    //        myCar.DisplayInfo();

    //        Console.WriteLine();

    //        Bike myBike = new Bike("Yamaha", 120, true);
    //        Console.WriteLine("Bike Info:");
    //        myBike.DisplayInfo();
    //    }
    //}

    //3.3. Constructor Chaining in Inheritance
    //class Program
    //{
    //    static void Main()
    //    {
    //        Manager mgr = new Manager("Sandeep", 30000, 1000);
    //        Console.WriteLine("Manager Info:");
    //        mgr.DisplayManagerInfo();
    //    }
    //}

    //// 4. Polymorphism with Abstract Class
    //class Program
    //{
    //    static void Main()
    //    {
    //        Animal4 myDog = new Dog();
    //        Animal4 myCat = new Cat();

    //        Console.WriteLine("Animal Sounds:");
    //        myDog.MakeSound(); // Calls Dog's MakeSound
    //        myCat.MakeSound(); // Calls Cat's MakeSound
    //    }
    //}

    ///5. Interface and Inheritance
    //class Program
    //{
    //    static void Main()
    //    {
    //        Robot myRobot = new Robot();

    //        Console.WriteLine("Robot Operations:");
    //        myRobot.Start(); // Inherited from Machine
    //        myRobot.Move();  // Implemented from IMovable
    //    }
    //}

    //6.Test Sealed Method
    //class Program
    //{
    //    static void Main()
    //    {
    //        Account6 acc = new Account6();
    //        acc.CalculateInterest();  // Calls base method

    //        SavingsAccount savingsAcc = new SavingsAccount();
    //        savingsAcc.CalculateInterest(); // Calls sealed overridden method
    //    }
    //}

    //7.  Multiple Inheritance via Interfaces
    //class Program
    //{
    //    static void Main()
    //    {
    //        Duck myDuck = new Duck();

    //        Console.WriteLine("Duck Behavior:");
    //        myDuck.Fly();   // Calls Fly() from IFlyable
    //        myDuck.Swim();  // Calls Swim() from ISwimmable
    //    }
    //}

    //8. Upcasting and Downcasting
    //class Program
    //{
    //    static void Main()
    //    {
    //        // Create an object of Student
    //        Student student = new Student { Name = "Sandeep", StudentID = 7332 };

    //        Person8 person = student;  // Implicit upcasting
    //        Console.WriteLine("After Upcasting:");
    //        person.ShowDetails(); // Calls overridden method in Student

    //        Student studentAgain = person as Student; // Safe casting using 'as'
    //        if (studentAgain != null)
    //        {
    //            Console.WriteLine("\nAfter Downcasting:");
    //            studentAgain.ShowDetails();  // Calls method in Student
    //        }
    //        else
    //        {
    //            Console.WriteLine("Downcasting failed.");
    //        }
    //    }
    //}

    //9.   Polymorphism in Main
    //class Program
    //{
    //    static void Main()
    //    {
    //        Product laptop = new ElectronicProduct("Laptop", 1000);
    //        Product tShirt = new ClothingProduct("T-Shirt", 50);

    //        Console.WriteLine("E-Commerce System:");
    //        laptop.DisplayDetails();
    //        tShirt.DisplayDetails();
    //    }
    //}

    //10.  

    class Program
    {
        static void Main()
        {
            SecuritySystem10 system = new SecuritySystem10();
            system.AuthenticateUser("admin", "password123");
        }
    }
}
