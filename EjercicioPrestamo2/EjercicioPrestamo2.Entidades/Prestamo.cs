using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrestamo2.Entidades
{
    public class Prestamo
    {
        //ATRIBUTOS
        private string _linea;
        private double _tna;
        private int _plazo;
        private double _monto;
        private string _usuario;
        private int _id;

        //CONSTRUCTORES
        public Prestamo(string linea, double tna, int plazo, double monto, string usuario, int id)
        {
            this._linea = linea;
            this._tna = tna;
            this._plazo = plazo;
            this._monto = monto;
            this._usuario = usuario;
            this._id = id;
        }
        public Prestamo()
        {

        }

        //PROPIEDADES
        public string Linea
        {
            set { _linea = value; }
            get { return _linea;  }
        }
        public double TNA
        {
            set { _tna = value; }
            get { return _tna;  }
        }
        public int Plazo
        {
            set { _plazo = value; }
            get { return _plazo;  }
        }
        public double Monto
        {
            set { _monto = value; }
            get { return _monto;  }
        }
        public string Usuario
        {
            set { _usuario = value; }
            get { return _usuario;  }
        }
        public int Id
        {
            set { _id = value; }
            get { return _id;  }
        }
        public double CuotaCapital
        {
            get { return (this.Monto / this.Plazo); }
        }
        public double CuotaInteres
        {
            get { return (this.CuotaCapital * (this.TNA / 12 / 100)); }
        }
        public double CuotaTotal
        {
            get { return (this.CuotaCapital + this.CuotaInteres); }
        }

        //MÉTODOS
    }
}
