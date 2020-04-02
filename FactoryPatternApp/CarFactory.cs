using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternApp
{
    static class CarFactory
    {
        public static IVehicle GetAuto(string autoType)
        {
            switch (autoType.ToLower())
            {               
                case "sedan":
                    return new Sedan();                 
                case "SUV":
                    return new SUV();                  
                default:
                    return new Car();                   
            }
        }
    }
}
