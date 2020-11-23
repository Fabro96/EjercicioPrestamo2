using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrestamo2.Entidades.Exceptions
{
    public class CamposVaciosAltaException : Exception
    {
        public CamposVaciosAltaException() : base("No se puede dar de Alta un Prestamo como campos vacíos")
        {

        }
    }
}
