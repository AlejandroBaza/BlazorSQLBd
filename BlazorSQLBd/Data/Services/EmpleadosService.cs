using BlazorSQLBd.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace BlazorSQLBd.Data.Services
{
    public class EmpleadosService : IEmpleadosService
    {
        private readonly AppDbContext _context;
            
        public EmpleadosService(AppDbContext context)
        {
            _context = context;
        }

        public Task<List<Empleado>> Actualizar(int id, Empleado empleadoactualizar)
        {
            throw new NotImplementedException();
        }

        public Task<Empleado> Crear(Empleado empleadocrear)
        {
            throw new NotImplementedException();
        }

        public Task<List<Empleado>> Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Empleado> ObtenerId(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Empleado>> ObtenerTodos()
        {
            return await _context.Empleados.ToListAsync();
        }
    }
}
