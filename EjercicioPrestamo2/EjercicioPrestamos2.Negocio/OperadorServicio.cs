using EjercicioPrestamo2.Datos;
using EjercicioPrestamo2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrestamos2.Negocio
{
    public class OperadorServicio
    {
        private PrestamoMapper _prestamoMapper;

        public OperadorServicio()
        {
            this._prestamoMapper = new PrestamoMapper();
        }

    }
}
