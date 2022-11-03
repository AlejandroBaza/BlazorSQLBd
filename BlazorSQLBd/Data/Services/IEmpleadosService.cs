using BlazorSQLBd.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorSQLBd.Data.Services
{
    public interface IEmpleadosService
    {
        //Devuelve una lista de empleados
        public Task<List<Empleado>> ObtenerTodos();
        
        //Recibe el id del empleado para obtener un empleado
        public Task<Empleado> ObtenerId(int id);
        
        //Recibe el objeto de tipo empleado que se insertara
        public Task<Empleado> Crear(Empleado empleadocrear);

        //Recibe el id y el objeto de tipo empleado que trae los datos a actualizar
        public Task<List<Empleado>> Actualizar(int id, Empleado empleadoactualizar);
        
        //Recibe el id del empleado a eliminar
        public Task<List<Empleado>> Eliminar(int id);

    }
}
