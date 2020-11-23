namespace EjercicioPrestamo2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTipoPrestamo = new System.Windows.Forms.Panel();
            this.txtCuotaTotal = new System.Windows.Forms.TextBox();
            this.txtCuotaInteres = new System.Windows.Forms.TextBox();
            this.txtCuotaCapital = new System.Windows.Forms.TextBox();
            this.txtPlazo = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtTNA = new System.Windows.Forms.TextBox();
            this.txtLinea = new System.Windows.Forms.TextBox();
            this.lblCuotaTotal = new System.Windows.Forms.Label();
            this.lblCuotaInteres = new System.Windows.Forms.Label();
            this.lblCuotaCapital = new System.Windows.Forms.Label();
            this.btnAltaPrestamo = new System.Windows.Forms.Button();
            this.btnSimular = new System.Windows.Forms.Button();
            this.lblPlazo = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.lblTNA = new System.Windows.Forms.Label();
            this.lblLinea = new System.Windows.Forms.Label();
            this.lstTiposPrestamo = new System.Windows.Forms.ListBox();
            this.lblTipoPrestamo = new System.Windows.Forms.Label();
            this.panelPrestamos = new System.Windows.Forms.Panel();
            this.lblPrestamos = new System.Windows.Forms.Label();
            this.lstPrestamos = new System.Windows.Forms.ListBox();
            this.lblComsionTotal = new System.Windows.Forms.Label();
            this.txtComisionTotal = new System.Windows.Forms.TextBox();
            this.panelTipoPrestamo.SuspendLayout();
            this.panelPrestamos.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTipoPrestamo
            // 
            this.panelTipoPrestamo.Controls.Add(this.txtCuotaTotal);
            this.panelTipoPrestamo.Controls.Add(this.txtCuotaInteres);
            this.panelTipoPrestamo.Controls.Add(this.txtCuotaCapital);
            this.panelTipoPrestamo.Controls.Add(this.txtPlazo);
            this.panelTipoPrestamo.Controls.Add(this.txtMonto);
            this.panelTipoPrestamo.Controls.Add(this.txtTNA);
            this.panelTipoPrestamo.Controls.Add(this.txtLinea);
            this.panelTipoPrestamo.Controls.Add(this.lblCuotaTotal);
            this.panelTipoPrestamo.Controls.Add(this.lblCuotaInteres);
            this.panelTipoPrestamo.Controls.Add(this.lblCuotaCapital);
            this.panelTipoPrestamo.Controls.Add(this.btnAltaPrestamo);
            this.panelTipoPrestamo.Controls.Add(this.btnSimular);
            this.panelTipoPrestamo.Controls.Add(this.lblPlazo);
            this.panelTipoPrestamo.Controls.Add(this.lblMonto);
            this.panelTipoPrestamo.Controls.Add(this.lblTNA);
            this.panelTipoPrestamo.Controls.Add(this.lblLinea);
            this.panelTipoPrestamo.Controls.Add(this.lstTiposPrestamo);
            this.panelTipoPrestamo.Controls.Add(this.lblTipoPrestamo);
            this.panelTipoPrestamo.Location = new System.Drawing.Point(23, 26);
            this.panelTipoPrestamo.Name = "panelTipoPrestamo";
            this.panelTipoPrestamo.Size = new System.Drawing.Size(593, 479);
            this.panelTipoPrestamo.TabIndex = 0;
            this.panelTipoPrestamo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTipoPrestamo_Paint);
            // 
            // txtCuotaTotal
            // 
            this.txtCuotaTotal.Location = new System.Drawing.Point(472, 390);
            this.txtCuotaTotal.Name = "txtCuotaTotal";
            this.txtCuotaTotal.Size = new System.Drawing.Size(96, 22);
            this.txtCuotaTotal.TabIndex = 17;
            // 
            // txtCuotaInteres
            // 
            this.txtCuotaInteres.Location = new System.Drawing.Point(472, 345);
            this.txtCuotaInteres.Name = "txtCuotaInteres";
            this.txtCuotaInteres.Size = new System.Drawing.Size(96, 22);
            this.txtCuotaInteres.TabIndex = 16;
            // 
            // txtCuotaCapital
            // 
            this.txtCuotaCapital.Location = new System.Drawing.Point(472, 300);
            this.txtCuotaCapital.Name = "txtCuotaCapital";
            this.txtCuotaCapital.Size = new System.Drawing.Size(96, 22);
            this.txtCuotaCapital.TabIndex = 15;
            // 
            // txtPlazo
            // 
            this.txtPlazo.Enabled = false;
            this.txtPlazo.Location = new System.Drawing.Point(431, 202);
            this.txtPlazo.Name = "txtPlazo";
            this.txtPlazo.Size = new System.Drawing.Size(137, 22);
            this.txtPlazo.TabIndex = 14;
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Location = new System.Drawing.Point(431, 155);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(137, 22);
            this.txtMonto.TabIndex = 13;
            // 
            // txtTNA
            // 
            this.txtTNA.Location = new System.Drawing.Point(431, 105);
            this.txtTNA.Name = "txtTNA";
            this.txtTNA.ReadOnly = true;
            this.txtTNA.Size = new System.Drawing.Size(137, 22);
            this.txtTNA.TabIndex = 12;
            // 
            // txtLinea
            // 
            this.txtLinea.Location = new System.Drawing.Point(431, 58);
            this.txtLinea.Name = "txtLinea";
            this.txtLinea.ReadOnly = true;
            this.txtLinea.Size = new System.Drawing.Size(137, 22);
            this.txtLinea.TabIndex = 11;
            // 
            // lblCuotaTotal
            // 
            this.lblCuotaTotal.AutoSize = true;
            this.lblCuotaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotaTotal.Location = new System.Drawing.Point(327, 394);
            this.lblCuotaTotal.Name = "lblCuotaTotal";
            this.lblCuotaTotal.Size = new System.Drawing.Size(127, 18);
            this.lblCuotaTotal.TabIndex = 10;
            this.lblCuotaTotal.Text = "CUOTA TOTAL:";
            // 
            // lblCuotaInteres
            // 
            this.lblCuotaInteres.AutoSize = true;
            this.lblCuotaInteres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotaInteres.Location = new System.Drawing.Point(327, 349);
            this.lblCuotaInteres.Name = "lblCuotaInteres";
            this.lblCuotaInteres.Size = new System.Drawing.Size(114, 18);
            this.lblCuotaInteres.TabIndex = 9;
            this.lblCuotaInteres.Text = "Cuota Interes:";
            // 
            // lblCuotaCapital
            // 
            this.lblCuotaCapital.AutoSize = true;
            this.lblCuotaCapital.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuotaCapital.Location = new System.Drawing.Point(327, 301);
            this.lblCuotaCapital.Name = "lblCuotaCapital";
            this.lblCuotaCapital.Size = new System.Drawing.Size(115, 18);
            this.lblCuotaCapital.TabIndex = 8;
            this.lblCuotaCapital.Text = "Cuota Capital:";
            // 
            // btnAltaPrestamo
            // 
            this.btnAltaPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaPrestamo.Location = new System.Drawing.Point(330, 433);
            this.btnAltaPrestamo.Name = "btnAltaPrestamo";
            this.btnAltaPrestamo.Size = new System.Drawing.Size(238, 41);
            this.btnAltaPrestamo.TabIndex = 7;
            this.btnAltaPrestamo.Text = "ALTA";
            this.btnAltaPrestamo.UseVisualStyleBackColor = true;
            // 
            // btnSimular
            // 
            this.btnSimular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimular.Location = new System.Drawing.Point(330, 246);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(238, 31);
            this.btnSimular.TabIndex = 6;
            this.btnSimular.Text = "SIMULAR";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // lblPlazo
            // 
            this.lblPlazo.AutoSize = true;
            this.lblPlazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlazo.Location = new System.Drawing.Point(327, 206);
            this.lblPlazo.Name = "lblPlazo";
            this.lblPlazo.Size = new System.Drawing.Size(56, 18);
            this.lblPlazo.TabIndex = 5;
            this.lblPlazo.Text = "Plazo:";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(327, 159);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(61, 18);
            this.lblMonto.TabIndex = 4;
            this.lblMonto.Text = "Monto:";
            // 
            // lblTNA
            // 
            this.lblTNA.AutoSize = true;
            this.lblTNA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTNA.Location = new System.Drawing.Point(327, 109);
            this.lblTNA.Name = "lblTNA";
            this.lblTNA.Size = new System.Drawing.Size(45, 18);
            this.lblTNA.TabIndex = 3;
            this.lblTNA.Text = "TNA:";
            // 
            // lblLinea
            // 
            this.lblLinea.AutoSize = true;
            this.lblLinea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLinea.Location = new System.Drawing.Point(327, 62);
            this.lblLinea.Name = "lblLinea";
            this.lblLinea.Size = new System.Drawing.Size(53, 18);
            this.lblLinea.TabIndex = 2;
            this.lblLinea.Text = "Linea:";
            // 
            // lstTiposPrestamo
            // 
            this.lstTiposPrestamo.FormattingEnabled = true;
            this.lstTiposPrestamo.ItemHeight = 16;
            this.lstTiposPrestamo.Location = new System.Drawing.Point(18, 54);
            this.lstTiposPrestamo.Name = "lstTiposPrestamo";
            this.lstTiposPrestamo.Size = new System.Drawing.Size(290, 420);
            this.lstTiposPrestamo.TabIndex = 1;
            this.lstTiposPrestamo.SelectedIndexChanged += new System.EventHandler(this.lstTiposPrestamo_SelectedIndexChanged);
            // 
            // lblTipoPrestamo
            // 
            this.lblTipoPrestamo.AutoSize = true;
            this.lblTipoPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPrestamo.Location = new System.Drawing.Point(13, 14);
            this.lblTipoPrestamo.Name = "lblTipoPrestamo";
            this.lblTipoPrestamo.Size = new System.Drawing.Size(205, 25);
            this.lblTipoPrestamo.TabIndex = 0;
            this.lblTipoPrestamo.Text = "TIPOS PRESTAMO";
            // 
            // panelPrestamos
            // 
            this.panelPrestamos.Controls.Add(this.txtComisionTotal);
            this.panelPrestamos.Controls.Add(this.lblComsionTotal);
            this.panelPrestamos.Controls.Add(this.lstPrestamos);
            this.panelPrestamos.Controls.Add(this.lblPrestamos);
            this.panelPrestamos.Location = new System.Drawing.Point(622, 26);
            this.panelPrestamos.Name = "panelPrestamos";
            this.panelPrestamos.Size = new System.Drawing.Size(393, 479);
            this.panelPrestamos.TabIndex = 1;
            this.panelPrestamos.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrestamos_Paint);
            // 
            // lblPrestamos
            // 
            this.lblPrestamos.AutoSize = true;
            this.lblPrestamos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamos.Location = new System.Drawing.Point(15, 14);
            this.lblPrestamos.Name = "lblPrestamos";
            this.lblPrestamos.Size = new System.Drawing.Size(328, 25);
            this.lblPrestamos.TabIndex = 1;
            this.lblPrestamos.Text = "PRESTAMOS DADOS DE ALTA";
            // 
            // lstPrestamos
            // 
            this.lstPrestamos.FormattingEnabled = true;
            this.lstPrestamos.ItemHeight = 16;
            this.lstPrestamos.Location = new System.Drawing.Point(21, 62);
            this.lstPrestamos.Name = "lstPrestamos";
            this.lstPrestamos.Size = new System.Drawing.Size(351, 356);
            this.lstPrestamos.TabIndex = 2;
            // 
            // lblComsionTotal
            // 
            this.lblComsionTotal.AutoSize = true;
            this.lblComsionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComsionTotal.Location = new System.Drawing.Point(17, 443);
            this.lblComsionTotal.Name = "lblComsionTotal";
            this.lblComsionTotal.Size = new System.Drawing.Size(141, 20);
            this.lblComsionTotal.TabIndex = 11;
            this.lblComsionTotal.Text = "Comisión Total:";
            // 
            // txtComisionTotal
            // 
            this.txtComisionTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComisionTotal.Location = new System.Drawing.Point(192, 436);
            this.txtComisionTotal.Name = "txtComisionTotal";
            this.txtComisionTotal.Size = new System.Drawing.Size(180, 27);
            this.txtComisionTotal.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 555);
            this.Controls.Add(this.panelPrestamos);
            this.Controls.Add(this.panelTipoPrestamo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTipoPrestamo.ResumeLayout(false);
            this.panelTipoPrestamo.PerformLayout();
            this.panelPrestamos.ResumeLayout(false);
            this.panelPrestamos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTipoPrestamo;
        private System.Windows.Forms.Label lblCuotaCapital;
        private System.Windows.Forms.Button btnAltaPrestamo;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.Label lblPlazo;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label lblTNA;
        private System.Windows.Forms.Label lblLinea;
        private System.Windows.Forms.ListBox lstTiposPrestamo;
        private System.Windows.Forms.Label lblTipoPrestamo;
        private System.Windows.Forms.Panel panelPrestamos;
        private System.Windows.Forms.Label lblCuotaTotal;
        private System.Windows.Forms.Label lblCuotaInteres;
        private System.Windows.Forms.TextBox txtCuotaTotal;
        private System.Windows.Forms.TextBox txtCuotaInteres;
        private System.Windows.Forms.TextBox txtCuotaCapital;
        private System.Windows.Forms.TextBox txtPlazo;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtTNA;
        private System.Windows.Forms.TextBox txtLinea;
        private System.Windows.Forms.TextBox txtComisionTotal;
        private System.Windows.Forms.Label lblComsionTotal;
        private System.Windows.Forms.ListBox lstPrestamos;
        private System.Windows.Forms.Label lblPrestamos;
    }
}

