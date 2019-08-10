using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionOfControlUsingUnity
{
    public interface Icar
        {
        int Icar();
        }

    public class Maruti: Icar
    {
        private int _topSpeed = 100;
        public int Icar()
        {
            return _topSpeed;
        }
    }

    public class Mercedes:Icar
    {
        private int _topSpeed = 200;
        public int Icar()
        {
            return _topSpeed;
        }
    }

    public class Mclaren : Icar
    {
        private int _topSpeed = 300;
        public int Icar()
        {
            return _topSpeed;
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
           

        }
    }
}
