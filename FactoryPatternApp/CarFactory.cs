using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternApp
{
    static class CarFactory
    {
        public static ICallable GetAuto(string autoType)
        {
            switch (autoType.ToLower())
            {
                case "auto":
                    return new Auto();
                case "sedan":
                    return new SedanMoto();            
                case "moto":
                    return new ApplePhone();
                case "SUV":
                    return new SUVAuto();
                default:
                    return new Auto();
            }
        }
    }
}
