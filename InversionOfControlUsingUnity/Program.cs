using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace InversionOfControlUsingUnity
{
    public interface ICar
        {
        int Topspeed();
        }

    public class Maruti: ICar
    {
        private int _topSpeed = 100;
        public int Topspeed()
        {
            return _topSpeed;
        }
    }

    public class Mercedes:ICar
    {
        private int _topSpeed = 200;
        public int Topspeed()
        {
            return _topSpeed;
        }
    }

    public class Mclaren : ICar
    {
        private int _topSpeed = 300;
        public int Topspeed()
        {
            return _topSpeed;
        }
    }

    public class Driver
    {
        private ICar _car = null;
        public Driver(ICar car)
        {
            _car = car;
        }
        public void CheckSpeed()
        {
            Console.WriteLine($"Running {_car.GetType().Name} at speed {_car.Topspeed()}");
        }
    }

    

    class Program
    {
        
        static void Main(string[] args)
        {

            IUnityContainer container = new UnityContainer();
            container.RegisterType<ICar, Mclaren>();


            //Code without Unity Container
            //Driver driver = new Driver(new Maruti());
            //driver.CheckSpeed();

            //Code after Using Unity Container
            Driver driver = container.Resolve<Driver>();
            driver.CheckSpeed();


            Console.ReadKey();
        }
    }
}
