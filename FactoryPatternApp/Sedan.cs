using System;
using System.Collections.Generic;
using System.Text;


namespace FactoryPatternApp
{
    class Sedan : IVehicle 
    {
        public void Build()
        {
            ConsoleLogging.CarBuildDialogue();
            Console.WriteLine("You are creating a sedan..");
        }
    }
}
