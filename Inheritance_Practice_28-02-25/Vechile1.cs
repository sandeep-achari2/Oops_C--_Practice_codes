using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice_28_02_25
{
    public class Vechile1
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public Vechile1(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }
    // Step 2: Create Derived Class (Car)
    public class Car : Vechile1
    {
        public string carmodel { get; set; }

        public Car(string brand, int speed, string model) : base(brand, speed)
        {
            carmodel = model; ;
        }

        public void ShowCarInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Model is : {carmodel}");
        }
    }
    public class Bike : Vechile1
    {
        public bool Gear { get; set; }

        public Bike(string brand, int speed, bool gear) : base(brand, speed)
        {
            Gear = gear;
        }

        public void ShowBikeInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Has Gear: {Gear}");
        }
    }

}
