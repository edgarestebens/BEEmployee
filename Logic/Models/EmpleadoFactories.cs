using Logic.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Logic.Models
{
    public static class EmpleadoFactories
    {
        public static EmpleadoI Factory(string contractTypeName,double hourlySalary, double monthlySalary)
        {
            if (contractTypeName == "HourlySalaryEmployee")
            {
                return new HoraSalario(hourlySalary);
            }    
            
            if (contractTypeName == "MonthlySalaryEmployee")
            {
                return new MesSalario(monthlySalary);

            }

            throw new ApplicationException();
        }

    }
}
