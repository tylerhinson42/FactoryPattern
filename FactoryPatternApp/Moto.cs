using System;
namespace FactoryPatternApp
{
    public class Moto : IVehicle
    {
        public Moto()
        {
            
        }
        public int NumWheels { get; set; }
        public string VehicleType { get; set; }

        public void Build()
        {
            throw new NotImplementedException();
        }
            

        public void GetWheels(int wheelCount)
        {
            Console.WriteLine("You have created a motorcycle");
        }

        internal void Drive()
        {
            throw new NotImplementedException();
        }
    }
}
