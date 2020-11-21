using System;
using EjercicioPrestamo2.Entidades;
using EjercicioPrestamo2.Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrestamos2.Negocio
{
    public class PrestamoServicio
    {
        private PrestamoMapper _prestamoMapper;

        public PrestamoServicio()
        {
            this._prestamoMapper = new PrestamoMapper();
        }

        public List<Prestamo> TraerPrestamos()
        {
            List<Prestamo> listaPrestamos = this._prestamoMapper.GetPrestamos();
            return listaPrestamos;
        }

        public int AgregarPrestamo(Prestamo prestamo)
        {
            ResultadoTransaccion resultante = _prestamoMapper.Insert(prestamo);

            if (resultante.IsOk)
                return resultante.Id;
            else
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultante.Error);
        }
    }
}
