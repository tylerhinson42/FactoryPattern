using System;

namespace FactoryPatternApp
{
    class Auto : ICallable
    {
        public void Build()
        {
            ConsoleLogging.CarBuildDialogue();
            Console.WriteLine("Building an Android phone!");
        }

        internal void Drive()
        {
            throw new NotImplementedException();
        }
    }
}
