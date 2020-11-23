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
        public void CargarPrestamos(List<Prestamo> prestamos)
        {
            lstPrestamos.DataSource = null;
            lstPrestamos.DataSource = prestamos;

            
        }
        public void ValidacionBotonSimular()
        {
            if (string.IsNullOrWhiteSpace(txtLinea.Text)  ||
                string.IsNullOrWhiteSpace(txtTNA.Text)    ||
                string.IsNullOrWhiteSpace(txtMonto.Text)  ||
                string.IsNullOrWhiteSpace(txtPlazo.Text))
            {
                throw new CamposVaciosSimularException();
            }
        }

        public void ValidacionBotonAlta()
        {
            if (string.IsNullOrWhiteSpace(txtLinea.Text)        ||
                string.IsNullOrWhiteSpace(txtTNA.Text)          ||
                string.IsNullOrWhiteSpace(txtMonto.Text)        ||
                string.IsNullOrWhiteSpace(txtPlazo.Text)        ||
                string.IsNullOrWhiteSpace(txtCuotaCapital.Text) ||
                string.IsNullOrWhiteSpace(txtCuotaInteres.Text) ||
                string.IsNullOrWhiteSpace(txtCuotaTotal.Text))
            {
                throw new CamposVaciosAltaException();
            }
        }

        public void BloquearCampos()
        {
            txtMonto.Text = string.Empty;
            txtPlazo.Text = string.Empty;
            txtCuotaInteres.Text = string.Empty;
            txtCuotaCapital.Text = string.Empty;
            txtCuotaTotal.Text = string.Empty;

        }

        //EVENTOS
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarTiposPrestamo(_tipoPrestamoServicio.TraerTiposPrestamo());
            CargarPrestamos(_prestamoServicio.TraerPrestamos());
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
                
                string linea = txtLinea.Text;
                double tna = double.Parse(txtTNA.Text);
                int plazo = int.Parse(txtPlazo.Text);
                double monto = double.Parse(txtMonto.Text);

                Prestamo prestamo = new Prestamo(linea, tna, plazo, monto);

                txtCuotaCapital.Text = prestamo.CuotaCapital.ToString();
                txtCuotaInteres.Text = prestamo.CuotaInteres.ToString();
                txtCuotaTotal.Text = prestamo.CuotaTotal.ToString();


            }
            catch (CamposVaciosSimularException ex1)
            {
                MessageBox.Show(ex1.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BloquearCampos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BloquearCampos();
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPlazo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnAltaPrestamo_Click(object sender, EventArgs e)
        {
            try
            {

                ValidacionBotonAlta();

                string linea = txtLinea.Text;
                double tna = double.Parse(txtTNA.Text);
                int plazo = int.Parse(txtPlazo.Text);
                double monto = double.Parse(txtMonto.Text);
                double cuota = double.Parse(txtCuotaTotal.Text);
                int id = _prestamoServicio.ProximoId();

                Prestamo prestamo = new Prestamo(linea, tna, plazo, monto, cuota, id);

                _prestamoServicio.AgregarPrestamo(prestamo);

                MessageBox.Show("Alta Exitosa!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                CargarPrestamos(_prestamoServicio.TraerPrestamos());

                BloquearCampos();

            }
            catch (CamposVaciosAltaException ex1)
            {
                MessageBox.Show(ex1.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BloquearCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                BloquearCampos();
            }
        }
    }
}
