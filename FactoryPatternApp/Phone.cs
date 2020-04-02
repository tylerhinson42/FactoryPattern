using System;
namespace FactoryPatternApp
{
    internal class Phone : ICallable
    {
       
        public Phone()
        {

        }

            public string PhoneType { get; set; }

        public void Build()
        {

        }
            
    }

}
