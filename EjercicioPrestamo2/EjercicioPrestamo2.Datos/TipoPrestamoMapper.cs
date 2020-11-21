using EjercicioPrestamo2.Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrestamo2.Datos
{
    public class TipoPrestamoMapper
    {
        public List<TipoPrestamo> GetTipoPrestamos()
        {
            string json2 = WebHelper.Get("/api/v1/prestamotipo");
            List<TipoPrestamo> resultado = MapList(json2);
            return resultado;
        }

        private List<TipoPrestamo> MapList(string json)
        {
            List<TipoPrestamo> lst = JsonConvert.DeserializeObject<List<TipoPrestamo>>(json);
            return lst;
        }

    }
}
