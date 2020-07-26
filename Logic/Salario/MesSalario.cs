using Logic.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Models
{
    public class MesSalario : EmpleadoI
    {
        public double Salario { set; get; }

        public MesSalario(double salario)
        {
            Salario = salario;
        }

        public double CalcularSalarioAnual()
        {
            return Salario * 12;
        }
    }
}
