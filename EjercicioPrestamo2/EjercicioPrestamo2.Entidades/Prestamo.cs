using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrestamo2.Entidades
{
    [DataContract]
    public class Prestamo
    {
        //ATRIBUTOS
        private string _linea;
        private double _tna;
        private int _plazo;
        private double _monto;
        private double _cuota;
        private string _usuario;
        private int _id;

        //CONSTRUCTORES
        public Prestamo(string linea, double tna, int plazo, double monto, double cuota, int id)
        {
            this._linea = linea;
            this._tna = tna;
            this._plazo = plazo;
            this._monto = monto;
            this._cuota = cuota;
            this._id = id;
        }
        public Prestamo(string linea, double tna, int plazo, double monto)
        {
            this._linea = linea;
            this._tna = tna;
            this._plazo = plazo;
            this._monto = monto;
        }
        public Prestamo()
        {

        }

        //PROPIEDADES
        [DataMember]
        public string Linea
        {
            set { _linea = value; }
            get { return _linea; }
        }
        [DataMember]
        public double TNA
        {
            set { _tna = value; }
            get { return _tna; }
        }
        [DataMember]
        public int Plazo
        {
            set { _plazo = value; }
            get { return _plazo; }
        }
        [DataMember]
        public double Monto
        {
            set { _monto = value; }
            get { return _monto; }
        }
        public string Usuario
        {
            set { _usuario = value; }
            get { return _usuario; }
        }
        [DataMember]
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
        [DataMember]
        public double CuotaTotal
        {
            get { return (this.CuotaCapital + this.CuotaInteres); }
        }

        //MÉTODOS
        public override string ToString()
        {
            return string.Format("{0} - Linea: {1} / Plazo: {2} / Cuota: $ {3}", this.Id, this.Linea, this.Plazo, this.CuotaTotal);
        }
    }
}
