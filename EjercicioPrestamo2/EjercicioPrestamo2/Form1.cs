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
using EjercicioPrestamo2.Entidades.Exceptions;

namespace EjercicioPrestamo2
{
    public partial class Form1 : Form
    {
        private PrestamoServicio _prestamoServicio;
        private TipoPrestamoServicio _tipoPrestamoServicio;
        private Prestamo _prestamo;

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
        public void ValidacionBotonSimular()
        {
            if (string.IsNullOrWhiteSpace(txtLinea.Text) ||
                string.IsNullOrWhiteSpace(txtTNA.Text) ||
                string.IsNullOrWhiteSpace(txtMonto.Text) ||
                string.IsNullOrWhiteSpace(txtPlazo.Text))
            {
                throw new CamposVaciosSimularException();
            }
        }
        public void BlaquearCampos()
        {
            txtMonto.Text = string.Empty;
            txtPlazo.Text = string.Empty;
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

        private void lstTiposPrestamo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoPrestamo tipoPrestamos = (TipoPrestamo)lstTiposPrestamo.SelectedItem;

            if (tipoPrestamos != null)
            {
                txtLinea.Text = tipoPrestamos.Linea;
                txtTNA.Text = tipoPrestamos.TNA.ToString();
                txtMonto.Enabled = true;
                txtPlazo.Enabled = true;

            }
            else
            {
                throw new NoHayTipoPrestamoException();
            }
            
            
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            try
            {
                ValidacionBotonSimular();
                double plazo = double.Parse(txtPlazo.Text);
                int monto = int.Parse(txtMonto.Text);
                txtCuotaCapital.Text = 


            }
            catch (CamposVaciosSimularException ex1)
            {
                MessageBox.Show(ex1.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BlaquearCampos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BlaquearCampos();
            }
        }
    }
}
