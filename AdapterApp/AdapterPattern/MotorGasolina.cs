using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class MotorGasolina : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando un Motor Gasolina");
        }

        public override void Arrancar()
        {
            Console.WriteLine("Arrancando un Motor Gasolina");
        }

        public override void Detener()
        {
            Console.WriteLine("Deteniendo un Motor Gasolina");
        }

        public override void Tanquear()
        {
            Console.WriteLine("Tanqueando un Motor Gasolina");
        }
    }
}
