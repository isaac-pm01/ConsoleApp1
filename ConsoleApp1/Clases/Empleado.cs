using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public abstract class Empleado : MiembroComunidad
    {
        public override void Caminar()
        {
          
        }

        public abstract void Trabajar();
    }
}
