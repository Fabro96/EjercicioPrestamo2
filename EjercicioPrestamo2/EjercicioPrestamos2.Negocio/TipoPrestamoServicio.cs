using EjercicioPrestamo2.Datos;
using EjercicioPrestamo2.Entidades;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrestamos2.Negocio
{
    public class TipoPrestamoServicio
    {
        private TipoPrestamoMapper _tipoPrestamoMapper;

        public TipoPrestamoServicio()
        {
            this._tipoPrestamoMapper = new TipoPrestamoMapper();
        }

        public List<TipoPrestamo> TraerTiposPrestamo()
        {
            List<TipoPrestamo> listaTipoPrestamos = this._tipoPrestamoMapper.GetTipoPrestamos();
            return listaTipoPrestamos;
        }
    }
}
