using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Interface
{
    public interface EmpleadoI
    {
        double Salario { set; get; }

        double CalcularSalarioAnual();
    }
}
