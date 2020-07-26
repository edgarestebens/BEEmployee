using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Data.Helpers;
using Logic.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : Controller
    {
         List<Empleado> empleados = new List<Empleado>();

        // GET: api/Empleado
        [HttpGet]
        public async Task<IEnumerable<Empleado>> GetAllEmployeesAsync()
        {
           
            empleados = await ApiEmpleados.CargarDatosEmpleados<Empleado>();
           
            foreach (var empleado in empleados)
            {
               
                empleado.AnnualSalary = CalcularSalarioAnual.calcularSalario(empleado.ContractTypeName,empleado.HourlySalary, empleado.MonthlySalary);

            }

            return empleados;
        }

        // GET: api/Empleado/1
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeAsync(int id)
        {
      
            var empleados = await GetAllEmployeesAsync();
            var empleado = empleados.FirstOrDefault(x => x.Id == id);
            if (empleado == null)
            {
                return NotFound();
            }

             return Ok(empleado);
        }

    }
}