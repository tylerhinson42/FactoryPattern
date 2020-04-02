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
                case "auto":
                    return new MyAuto();
                case "sedan":
                    return new Sedan();            
                case "SUV":
                    return new SUV();                
                default:
                    return new MyAuto();
            }
        }
    }
}
