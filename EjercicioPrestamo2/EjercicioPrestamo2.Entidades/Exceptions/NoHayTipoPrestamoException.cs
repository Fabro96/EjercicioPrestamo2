using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrestamo2.Entidades.Exceptions
{
    public class NoHayTipoPrestamoException : Exception
    {
        public NoHayTipoPrestamoException() : base("No hay Tipos de Préstamo para seleccionar.")
        {

        }
    }
}
