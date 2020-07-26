using Logic.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Models
{
    public class HoraSalario : EmpleadoI
    {
        public double Salario { set; get; }

        public HoraSalario(double salario)
        {
            Salario = salario;
        }

        public double CalcularSalarioAnual()
        {
            return 120 * Salario * 12;
        }
    }
}
