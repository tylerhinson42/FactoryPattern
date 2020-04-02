using System;
using System.Threading;
using System.Text;

namespace FactoryPatternApp

{
    public class ConsoleLoggingVehicle
    {
        public static void CarBuildDialogue()
        {
            Console.WriteLine("Gathering Vehicle tools!");
            Thread.Sleep(1000);
            Console.WriteLine("Constructing build kit!");
            Thread.Sleep(1000);
        }        
    }
}
