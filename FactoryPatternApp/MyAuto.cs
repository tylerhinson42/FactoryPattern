using System;
namespace FactoryPatternApp
{
    public class MyAuto : IVehicle
    {
        public MyAuto()
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
            Console.WriteLine("You have created an automobile");
        }
        internal void Drive()
        {
            throw new NotImplementedException();
        }
    
    }

}
