using System;

namespace FactoryPatternApp
{
    class SUV : IVehicle
    {
        public void Build()
        {
            ConsoleLogging.CarBuildDialogue();
            Console.WriteLine("You are creating a SUV..");
        }
    }
}
