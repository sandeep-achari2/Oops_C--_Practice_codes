using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Practice_28_02_25
{
    public class Vechile2
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public Vechile2(string brand, int speed)
        {
            Brand = brand;
            Speed = speed;
        }

        // Virtual method for overriding
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Speed: {Speed} km/h");
        }
    }

    // Renamed Car class to avoid conflict
    public class Car2 : Vechile2
    {
        public string car_model { get; set; }

        public Car2(string brand, int speed, string model) : base(brand, speed)
        {
            car_model = model;
        }

        // Overriding DisplayInfo method
        public override void DisplayInfo()
        {
            base.DisplayInfo();  // Call base class method
            Console.WriteLine($"Number of Doors: {car_model}");
        }
    }

    // Step 3: Create Derived Class (Motorbike) with Override
    public class Motorbike : Vechile2
    {
        public bool HasGear { get; set; }

        public Motorbike(string brand, int speed, bool hasGear) : base(brand, speed)
        {
            HasGear = hasGear;
        }

        // Overriding DisplayInfo method
        public override void DisplayInfo()
        {
            base.DisplayInfo();  // Call base class method
            Console.WriteLine($"Has Gear: {HasGear}");
        }
    }
}
