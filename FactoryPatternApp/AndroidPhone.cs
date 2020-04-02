using System;

namespace FactoryPatternApp
{
    class Auto : ICallable
    {
        public void Build()
        {
            ConsoleLogging.PhoneBuildDialogue();
            Console.WriteLine("Building an Android phone!");
        }      
    }
}
