﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Clases
{
    public abstract class ExAlumno : MiembroComunidad
    {
        public override void Caminar()
        {
            throw new NotImplementedException();
        }
        public abstract void Vivir();
    }
}
