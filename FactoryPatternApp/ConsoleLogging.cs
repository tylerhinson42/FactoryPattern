using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace FactoryPatternApp
{
    public class ConsoleLogging
    {
        public static void PhoneBuildDialogue()
        {
            Console.WriteLine("Gathering phone tools!");
            Thread.Sleep(1000);
            Console.WriteLine("Constructing build kit!");
            Thread.Sleep(1000);
        }
        internal static void CarBuildDialogue()
        {
            throw new NotImplementedException();
        }
    }
}
