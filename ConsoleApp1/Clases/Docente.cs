using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public abstract class Docente : Empleado
    {
        public override void Trabajar()
        {
            throw new NotImplementedException();
        }
        public abstract void DarClase();
    }
}
