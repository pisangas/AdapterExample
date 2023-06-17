using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class MotorDiesel : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando un Motor Diesel");
        }

        public override void Arrancar()
        {
            Console.WriteLine("Arrancando un Motor Diesel");
        }

        public override void Detener()
        {
            Console.WriteLine("Deteniendo un Motor Diesel");
        }

        public override void Tanquear()
        {
            Console.WriteLine("Tanqueando un Motor Diesel");
        }
    }
}
