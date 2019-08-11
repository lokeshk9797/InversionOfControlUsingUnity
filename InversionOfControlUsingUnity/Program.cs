using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using InversionOfControlUsingUnity.Interface;
using InversionOfControlUsingUnity.Class;

namespace InversionOfControlUsingUnity
{
   class Program
    { 
        public static void Main(string[] args)
        {
            // Resolving the Dependencies
            IUnityContainer container = new UnityContainer();
            ContainerAction.RegisterElements(container);

            //Checking for the Charge of the Battery
            IBattery battery = container.Resolve<IBattery>();
            Console.WriteLine(battery.ChargeRemaining());


            //Checking for the Tuner Manufacturer
            ITuner tuner = container.Resolve<ITuner>();
            Console.WriteLine(tuner.Manufacturer());

            Console.ReadKey();
        }
    }
}
