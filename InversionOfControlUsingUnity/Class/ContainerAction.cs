using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using InversionOfControlUsingUnity.Class;
using InversionOfControlUsingUnity.Interface;
using Unity.Injection;

namespace InversionOfControlUsingUnity.Class
{
   
    public class ContainerAction
    {
        //public static void RegisterElements(IUnityContainer container)
        //{
        //    container.RegisterType(
        //        AllClasses.FromLoadedAssemblies(),
        //        WithMappings.FromMatchingInterface,
        //        WithName.Default,
        //        WithLifetime.ContainerControlled);


        //}
        public static void RegisterElements(IUnityContainer container)
        {
            container.RegisterType<IBattery, Battery>();
            container.RegisterType<ITuner, Tuner>();

            var batteryType = typeof(IBattery);
            var tunerType = typeof(ITuner);
            container.RegisterType<IRadio, Radio>(new InjectionConstructor(batteryType, tunerType, typeof(string)));
        }
    }
}
