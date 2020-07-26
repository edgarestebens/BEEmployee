using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Models
{
    public class CalcularSalarioAnual
    {
        public static double calcularSalario(string contractTypeName, double hourlySalary, double monthlySalary)
        {
            var calcularsalarioFactory = EmpleadoFactories.Factory(contractTypeName, hourlySalary, monthlySalary);
            return calcularsalarioFactory.CalcularSalarioAnual();
        }

        public static double calcularSalario(double hourlySalary, double monthlySalary)
        {
            throw new NotImplementedException();
        }
    }
}
