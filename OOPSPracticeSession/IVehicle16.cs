using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPracticeSession
{
    public interface IVehicle16
    {
        void Drive();
    }

    public class CarVehicle : IVehicle16
    {
        public void Drive()
        {
            Console.WriteLine("Driving a Car!");
        }
    }
    public class BikeVehicle : IVehicle16
    {
        public void Drive()
        {
            Console.WriteLine("Riding a Bike!");
        }
    }
    public class VehicleFactory
    {
        public static IVehicle16 GetVehicle(string vehicleType)
        {
            switch (vehicleType.ToLower())
            {
                case "car":
                    return new CarVehicle();
                case "bike":
                    return new BikeVehicle();
                default:
                    throw new ArgumentException("Invalid vehicle type: " + vehicleType);
            }
        }
    }

}
