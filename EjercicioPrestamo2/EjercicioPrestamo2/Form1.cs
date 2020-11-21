using System;
using EjercicioPrestamo2.Entidades;
using EjercicioPrestamos2.Negocio;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioPrestamo2
{
    public partial class Form1 : Form
    {
        private PrestamoServicio _prestamoServicio;
        private TipoPrestamoServicio _tipoPrestamoServicio;

        public Form1()
        {
            
            InitializeComponent();
            this._tipoPrestamoServicio = new TipoPrestamoServicio();
            this._prestamoServicio = new PrestamoServicio();

        }

        //MÉTODOS
        public void CargarTiposPrestamo(List<TipoPrestamo> tiposPrestamo)
        {
            lstTiposPrestamo.DataSource = null;
            lstTiposPrestamo.DataSource = tiposPrestamo;
        }

        //EVENTOS
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarTiposPrestamo(_tipoPrestamoServicio.TraerTiposPrestamo());
        }

        private void panelPrestamos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelTipoPrestamo_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
