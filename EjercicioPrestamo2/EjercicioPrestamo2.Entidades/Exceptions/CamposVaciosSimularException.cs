using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrestamo2.Entidades.Exceptions
{
    public class CamposVaciosSimularException : Exception
    {
        public CamposVaciosSimularException() : base("No se puede simular con campos vacíos.")
        {

        }
    }
}
