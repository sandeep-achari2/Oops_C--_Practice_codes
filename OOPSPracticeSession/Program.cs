using OOPSPracticeSession;
using System;
using System.Buffers;


//**Encapsulation Challenge * *

//public class Program
//{
//    public static void Main()
//    {
//        try
//        {
//            // Ask the user for the initial balance
//            Console.Write("Enter initial balance: ");
//            decimal initialBalance = decimal.Parse(Console.ReadLine());

//            // Create a new BankAccount with the user-provided initial balance
//            BankAccount1 account = new BankAccount1(initialBalance);
//            Console.WriteLine($"Account created with initial balance: {account.GetBalance()}");

//            // Ask the user for a deposit amount
//            Console.Write("Enter deposit amount: ");
//            decimal depositAmount = decimal.Parse(Console.ReadLine());
//            account.Deposit(depositAmount);
//            Console.WriteLine($"Balance after deposit: {account.GetBalance()}");

//            // Ask the user for a withdrawal amount
//            Console.Write("Enter withdrawal amount: ");
//            decimal withdrawalAmount = decimal.Parse(Console.ReadLine());
//            account.Withdraw(withdrawalAmount);
//            Console.WriteLine($"Balance after withdrawal: {account.GetBalance()}");
//        }
//        catch (Exception e)
//        {
//            Console.WriteLine("Invalid input. Please enter a valid number.");
//        }

//    }
//}

//**Data Hiding with Properties**

//class Program
//{
//    static void Main()
//    {
//        Student2 student = new Student2("", -5);
//        Console.WriteLine($"Student Name: {student.Name}, Roll No: {student.RollNo}");
//        Student2 student1 = new Student2("Sandeeep", 12);
//        Console.WriteLine($"Student Name: {student1.Name}, Roll No: {student1.RollNo}");
//    }
//}


//**Constructor Overloading in a Library System**

//public class Program
//{
//    static void Main(string[] args)
//    {
//        Book3 book1 = new Book3();
//        book1.DisplayInfo();
//        Book3 book2 = new Book3("C# Programming", "John Doe");
//        book2.DisplayInfo();
//        Book3 book3 = new Book3("C# Programming", "John Doe", "1234567890");
//        book3.DisplayInfo();
//    }
//}


//**Abstraction with Abstract Classes**


//public class Program
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            // Create a Circle object
//            Console.Write("Enter the radius of the circle: ");
//            double radius = double.Parse(Console.ReadLine());
//            Circle circle = new Circle(radius);
//            Console.WriteLine($"Area of the circle: {circle.CalculateArea():F2}");

//            // Create a Rectangle object
//            Console.Write("\nEnter the length of the rectangle: ");
//            double length = double.Parse(Console.ReadLine());
//            Console.Write("Enter the width of the rectangle: ");
//            double width = double.Parse(Console.ReadLine());
//            Rectangle rectangle = new Rectangle(length, width);
//            Console.WriteLine($"Area of the rectangle: {rectangle.CalculateArea():F2}");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"An error occurred: {ex.Message}");
//        }
//    }
//}


//**Method Overriding for a Vehicle System**


//public class Program
//{
//    static void Main(string[] args)
//    {
//        Vechile5 mycar = new Car();
//        Vechile5 mybike = new Bike();
//        mycar.Start();
//        mybike.Start();

//        //Polymorphism demonstrating
//        Vechile5[] vechiles = new Vechile5[2];
//        vechiles[0] = new Car();
//        vechiles[1] = new Bike();

//        foreach (Vechile5 Vechile in vechiles)
//        {
//            Vechile.Start();
//        }
//    }
//}


//**Using Virtual Methods in Inheritance**

//class Program
//{
//    static void Main()
//    {
//        // Using base class reference for a Student object
//        Person6 person1 = new Student { Name = "Sandeep", Age = 22, StudentID = "7332" };
//        person1.GetDetails();  // Calls Student's overridden method

//        // Using base class reference for a Teacher object
//        Person6 person2 = new Teacher { Name = "HArish", Age = 45, Subject = "Mathematics" };
//        person2.GetDetails();  // Calls Teacher's overridden method
//    }
//}

//**Method Overloading in a Calculator Class**

//class Program
//{
//    static void Main()
//    {
//        Calculator7 calc = new Calculator7();
//        Console.WriteLine("Sum of 5 and 10 : " + calc.Add(5, 10));

//        Console.WriteLine("Sum of 3, 7, and 2 : " + calc.Add(3, 7, 2));

//        Console.WriteLine("Sum of 5.5 and 2.3 : " + calc.Add(5.5, 2.3));
//    }
//}


//**Interface Implementation Challenge**

//class Program
//{
//    static void Main()
//    {
//        IPlayable8 music = new MusicPlayer();
//        IPlayable8 video = new VideoPlayer();

//        // Calling Play() through interface reference
//        music.Play();  // Calls MusicPlayer's Play method
//        video.Play();  // Calls VideoPlayer's Play method
//    }
//}

//**Multiple Inheritance Using Interfaces**

//class Program
//{
//    static void Main()
//    {
//        Report report = new Report("Monthly Sales", "Sales increased by 20% this month.");

//        // Using IPrintable interface
//        IPrintable9 printable = report;
//        printable.Print();

//        // Using ISerializable interface
//        ISerializable serializable = report;
//        serializable.Save("report.txt");
//    }
//}

//**Design a Role-Based Access System**

//class Program
//{
//    static void Main()
//    {
//        User10 admin = new Admin("Sandeep");
//        User10 customer = new Customer("Harish");
//        admin.AccessControl();    // Calls Admin's method
//        customer.AccessControl(); // Calls Customer's method
//    }
//}

//**Operator Overloading for Complex Numbers**

//class Program
//{
//    static void Main()
//{
//    ComplexNumber11 num1 = new ComplexNumber11(5, 6);
//    ComplexNumber11 num2 = new ComplexNumber11(8, 6);

//    ComplexNumber11 result = num1 + num2; // Using overloaded + operator

//    Console.Write("Result: ");
//    result.Display(); // Display the sum
//}
//}

//**Shallow Copy vs. Deep Copy**

//class Program
//{
//    static void Main()
//    {
//        // Original Department
//        Department dept1 = new Department("AIML", "Sandeep");
//        Console.WriteLine("Original Department:");
//        dept1.Display();

//        // Shallow Copy
//        Department shallowCopy = dept1.ShallowCopy();
//        Console.WriteLine("\nAfter Shallow Copy:");
//        shallowCopy.Display();

//        // Deep Copy
//        Department deepCopy = dept1.DeepCopy();
//        Console.WriteLine("\nAfter Deep Copy:");
//        deepCopy.Display();

//        // Modifying Name
//        dept1.Manager.Name = "Harish";
//        Console.WriteLine("\nAfter Modifying Original Manager Name to 'Harish':");

//        Console.WriteLine("Original Department:");
//        dept1.Display();

//        Console.WriteLine("Shallow Copy:");
//        shallowCopy.Display();

//        Console.WriteLine("Deep Copy:");
//        deepCopy.Display();
//    }
//}

//**Static Members in a Banking System**

//class Program
//{
//    public static void Main(string[] args)
//    {
//        Bank13 bank1 = new Bank13("Sandeep", 5000);
//        Console.WriteLine("Old Interest Rate: ");
//        bank1.DisplayAccounyInformation();
//        Console.WriteLine("New Interest Rate: ");
//        Bank13.SetInterestRate(6.0);
//        bank1.DisplayAccounyInformation();
//    }
//}

//**Sealed Class in a Security System**

//class Program
//{
//    static void Main()
//    {
//        SecuritySystem14 security = new SecuritySystem14();
//        security.Activate();
//    }
//}

//**Use of Delegates for Event Handling**
using OOPSPracticeSession;

//**Use of Delegates for Event Handling**
//class Program
//{
//    public class EventHandlerClass
//    {
//        public void ButtonClicked()
//        {
//            Console.WriteLine("Button was clicked.");
//        }
//    }
//    static void Main()
//    {
//        // Create button instance
//        Button button = new Button();

//        // Create event handler instance
//        EventHandlerClass handler = new EventHandlerClass();

//        // Subscribe event handler to button click event
//        button.OnClick += handler.ButtonClicked;

//        // Simulate button click
//        button.Click();
//    }
//}

//**Factory Pattern for Object Creation**

//class Program
//{
//    static void Main()
//    {
//        IVehicle vehicle1 = VehicleFactory.GetVehicle("car");
//        vehicle1.Drive(); // Output: Driving a Car!

//        IVehicle vehicle2 = VehicleFactory.GetVehicle("bike");
//        vehicle2.Drive(); // Output: Riding a Bike!
//    }
//}

//**Decorator Pattern in a Logger System**

//class Program
//{
//    static void Main()
//    {
//        // Create a basic FileLogger
//        ILogger17 fileLogger = new FileLogger();

//        // Add timestamp functionality
//        ILogger17 timestampLogger = new TimestampLogger(fileLogger);

//        // Add error categorization on top of timestamp logging
//        ILogger17 errorCategoryLogger = new ErrorCategoryLogger(timestampLogger, "ERROR");

//        // Log a message with all decorators applied
//        errorCategoryLogger.Log("System failure detected.");
//    }
//}

//**Thread-Safe Singleton Pattern for Configuration Management**

//class Program
//{
//    static void Main()
//    {
//        // Fetch the Singleton instance
//        ConfigurationManager config1 = ConfigurationManager.GetInstance();
//        config1.ShowConfiguration();

//        // Fetch the Singleton instance again
//        ConfigurationManager config2 = ConfigurationManager.GetInstance();

//        // Verify that both instances are the same
//        Console.WriteLine(ReferenceEquals(config1, config2) ? "Same Instance" : "Different Instances");
//    }
//}

//**Real - World Observer Pattern for Notifications**

//class Program
//{
//    static void Main()
//    {
//        // Create a Notification Service (Subject)
//        NotificationService notificationService = new NotificationService();

//        // Create Observers
//        INotificationObserver emailNotifier = new EmailNotifier();
//        INotificationObserver smsNotifier = new SMSNotifier();

//        // Attach Observers
//        notificationService.Attach(emailNotifier);
//        notificationService.Attach(smsNotifier);

//        // Notify Observers of a New Message
//        notificationService.Notify("You have a new alert!");

//        // Detach SMS Notifier and Send Another Notification
//        notificationService.Detach(smsNotifier);
//        notificationService.Notify("System maintenance scheduled.");
//    }
//}

//**Strategy Pattern for Dynamic Discount Calculation**

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Enter total cart amount:");
//        decimal totalAmount = Convert.ToDecimal(Console.ReadLine());

//        Console.WriteLine("Select Discount Strategy: \n1. No Discount \n2. 10% Discount \n3. $20 Fixed Discount");
//        int choice = Convert.ToInt32(Console.ReadLine());

//        IDiscountStrategy discountStrategy = choice switch
//        {
//            1 => new NoDiscount(),
//            2 => new PercentageDiscount(10),
//            3 => new FixedAmountDiscount(20),
//            _ => new NoDiscount()
//        };

//        ShoppingCart cart = new ShoppingCart(discountStrategy);
//        decimal finalAmount = cart.CalculateTotal(totalAmount);

//        Console.WriteLine($"Final Price after discount: ${finalAmount}");
//    }
//}