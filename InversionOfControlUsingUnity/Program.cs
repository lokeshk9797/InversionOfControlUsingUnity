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
            IUnityContainer container = new UnityContainer();
            ContainerAction.RegisterElements(container);

            IBattery battery = container.Resolve<IBattery>();
            Console.WriteLine(battery.ChargeRemaining());

            ITuner tuner = container.Resolve<ITuner>();
            Console.WriteLine(tuner.Manufacturer());

            Console.ReadKey();
        }
    }
}
