using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class MotorElectricoAdapter : Motor
    {
        MotorElectrico motorElectrico = new MotorElectrico();

        public override void Acelerar()
        {
            motorElectrico.Mover();
        }

        public override void Arrancar()
        {
            motorElectrico.Activar();
        }

        public override void Detener()
        {
            motorElectrico.Parar();
        }

        public override void Tanquear()
        {
            motorElectrico.Conectar();
        }
    }
}
