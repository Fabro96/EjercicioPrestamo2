using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrestamo2.Entidades
{
    public class Operador
    {
        //ATRIBUTOS
        private List<Prestamo> _prestamos;
        private double _comision;
        private double _porcentajeComision;

        //CONSTRUCTORES
        public Operador(List<Prestamo> prestamos, double comision, double porcentajeComsion)
        {
            this._prestamos = prestamos;
            this._comision = comision;
            this._porcentajeComision = porcentajeComsion;
        }
        public Operador()
        {

        }

        //PROPIEDADES
        public List<Prestamo> Prestamos
        { 
            get { return _prestamos;  }
        }
        public double Comision
        {
            set { _comision = value; }
            get { return _comision;  }
        }
        public double PorcentajeComision
        {
            get { return _porcentajeComision; }
        }

        //MÉTODOS

    }
}
