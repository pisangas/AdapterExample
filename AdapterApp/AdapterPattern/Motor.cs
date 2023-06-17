using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public abstract class Motor
    {
        public abstract void Acelerar();
        public abstract void Arrancar();
        public abstract void Tanquear();
        public abstract void Detener();
        
    }
}
