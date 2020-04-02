using System;

namespace FactoryPatternApp
{
    class ApplePhone : ICallable
    {
        public void Build()
        {
            ConsoleLogging.PhoneBuildDialogue();
            Console.WriteLine("Building an Apple phone!");
        }
    }
}
