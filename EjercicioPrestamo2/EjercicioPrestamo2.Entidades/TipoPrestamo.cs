using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrestamo2.Entidades
{
    [DataContract]
    public class TipoPrestamo
    {
        //ATRIBUTOS
        private string _linea;
        private double _tna;

        //CONSTRUCTORES
        public TipoPrestamo(string linea, double tna)
        {
            this._linea = linea;
            this._tna = tna;
        }
        public TipoPrestamo()
        {

        }

        [DataMember]
        //PROPIEDADES
        public string Linea
        {
            set { _linea = value; }
            get { return _linea;  }
        }

        [DataMember]
        public double TNA
        {
            set { _tna = value; }
            get { return _tna;  }
        }

        //MÉTODOS
        public override string ToString()
        {
            return string.Format("TNA: {0}, Linea: {1}.", this.TNA, this.Linea);
        }
    }
}
