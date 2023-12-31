﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class MotorElectrico
    {
        private bool _conectado = false;
        private readonly bool _activo = false;
        private readonly bool _moviendo = false;
        private readonly bool _parar = false;

        public void Conectar()
        {
            if (_conectado) Console.WriteLine("Imposible conectar un motor electrico, ya esta conectado");
            else
            {
                Console.WriteLine("Conectado Correctamente");
                _conectado = true;
            }                
        }

        public void Activar()
        {
            if (_activo) Console.WriteLine("Imposible activar un motor electrico, ya esta activo");
            else
            {
                Console.WriteLine("Activo Correctamente");
                _conectado = true;
            }
        }

        public void Mover()
        {
            if (_moviendo) Console.WriteLine("Imposible mover un motor electrico, ya esta en movimiento");
            else
            {
                Console.WriteLine("Moviendo Correctamente");
                _conectado = true;
            }
        }

        public void Parar()
        {
            if (_parar) Console.WriteLine("Imposible parar un motor electrico, ya esta en detenido");
            else
            {
                Console.WriteLine("Detenido Correctamente");
                _conectado = false;
            }
        }



    }
}
