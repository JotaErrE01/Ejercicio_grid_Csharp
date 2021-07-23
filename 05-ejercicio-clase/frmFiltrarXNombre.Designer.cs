
namespace View
{
    partial class frmFiltrarXNombre
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontoB = new System.Windows.Forms.TextBox();
            this.txtNombreB = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvBecas = new System.Windows.Forms.DataGridView();
            this.ColNro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPaisCiuada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUniversidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaEs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFehcaV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbInternacional = new System.Windows.Forms.RadioButton();
            this.rdbNacional = new System.Windows.Forms.RadioButton();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cmbUniversidad = new System.Windows.Forms.ComboBox();
            this.cmbPaisCiudad = new System.Windows.Forms.ComboBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtTiempoEstudio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.dtpFechaViaje = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPaisCiudad = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPresentar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Monto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre:";
            // 
            // txtMontoB
            // 
            this.txtMontoB.Location = new System.Drawing.Point(127, 51);
            this.txtMontoB.MaxLength = 10;
            this.txtMontoB.Name = "txtMontoB";
            this.txtMontoB.Size = new System.Drawing.Size(120, 20);
            this.txtMontoB.TabIndex = 12;
            this.txtMontoB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoB_KeyPress);
            // 
            // txtNombreB
            // 
            this.txtNombreB.Location = new System.Drawing.Point(127, 14);
            this.txtNombreB.MaxLength = 10;
            this.txtNombreB.Name = "txtNombreB";
            this.txtNombreB.Size = new System.Drawing.Size(120, 20);
            this.txtNombreB.TabIndex = 13;
            this.txtNombreB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreB_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(340, 12);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(117, 32);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvBecas
            // 
            this.dgvBecas.AllowUserToAddRows = false;
            this.dgvBecas.AllowUserToDeleteRows = false;
            this.dgvBecas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBecas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNro,
            this.colCedula,
            this.colNombre,
            this.colPaisCiuada,
            this.colUniversidad,
            this.colMonto,
            this.colFechaEs,
            this.colFehcaV});
            this.dgvBecas.Location = new System.Drawing.Point(46, 77);
            this.dgvBecas.Name = "dgvBecas";
            this.dgvBecas.ReadOnly = true;
            this.dgvBecas.Size = new System.Drawing.Size(704, 161);
            this.dgvBecas.TabIndex = 14;
            // 
            // ColNro
            // 
            this.ColNro.HeaderText = "Nro.";
            this.ColNro.Name = "ColNro";
            this.ColNro.ReadOnly = true;
            // 
            // colCedula
            // 
            this.colCedula.HeaderText = "Cedula";
            this.colCedula.Name = "colCedula";
            this.colCedula.ReadOnly = true;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            // 
            // colPaisCiuada
            // 
            this.colPaisCiuada.HeaderText = "Pais/Ciudad";
            this.colPaisCiuada.Name = "colPaisCiuada";
            this.colPaisCiuada.ReadOnly = true;
            // 
            // colUniversidad
            // 
            this.colUniversidad.HeaderText = "Universidad";
            this.colUniversidad.Name = "colUniversidad";
            this.colUniversidad.ReadOnly = true;
            // 
            // colMonto
            // 
            this.colMonto.HeaderText = "Monto";
            this.colMonto.Name = "colMonto";
            this.colMonto.ReadOnly = true;
            // 
            // colFechaEs
            // 
            this.colFechaEs.HeaderText = "Tiempo Estudio (meses)";
            this.colFechaEs.Name = "colFechaEs";
            this.colFechaEs.ReadOnly = true;
            // 
            // colFehcaV
            // 
            this.colFehcaV.HeaderText = "Fecha de Viaje";
            this.colFehcaV.Name = "colFehcaV";
            this.colFehcaV.ReadOnly = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(496, 12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(117, 32);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(8, 588);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(217, 53);
            this.btnSeleccionar.TabIndex = 41;
            this.btnSeleccionar.Text = "Seleccionar Imagen";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(412, 294);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(112, 103);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImage.TabIndex = 40;
            this.pbImage.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbInternacional);
            this.groupBox1.Controls.Add(this.rdbNacional);
            this.groupBox1.Location = new System.Drawing.Point(568, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 112);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // rdbInternacional
            // 
            this.rdbInternacional.AutoSize = true;
            this.rdbInternacional.Location = new System.Drawing.Point(35, 74);
            this.rdbInternacional.Name = "rdbInternacional";
            this.rdbInternacional.Size = new System.Drawing.Size(114, 17);
            this.rdbInternacional.TabIndex = 0;
            this.rdbInternacional.Text = "Beca Internacional";
            this.rdbInternacional.UseVisualStyleBackColor = true;
            this.rdbInternacional.CheckedChanged += new System.EventHandler(this.rdbInternacional_CheckedChanged);
            // 
            // rdbNacional
            // 
            this.rdbNacional.AutoSize = true;
            this.rdbNacional.Checked = true;
            this.rdbNacional.Location = new System.Drawing.Point(35, 20);
            this.rdbNacional.Name = "rdbNacional";
            this.rdbNacional.Size = new System.Drawing.Size(95, 17);
            this.rdbNacional.TabIndex = 19;
            this.rdbNacional.TabStop = true;
            this.rdbNacional.Text = "Beca Nacional";
            this.rdbNacional.UseVisualStyleBackColor = true;
            this.rdbNacional.CheckedChanged += new System.EventHandler(this.rdbNacional_CheckedChanged);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(412, 543);
            this.txtArea.Multiline = true;
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(345, 148);
            this.txtArea.TabIndex = 38;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(266, 593);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 42);
            this.btnGuardar.TabIndex = 37;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cmbUniversidad
            // 
            this.cmbUniversidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUniversidad.FormattingEnabled = true;
            this.cmbUniversidad.Location = new System.Drawing.Point(180, 422);
            this.cmbUniversidad.Name = "cmbUniversidad";
            this.cmbUniversidad.Size = new System.Drawing.Size(158, 21);
            this.cmbUniversidad.TabIndex = 36;
            // 
            // cmbPaisCiudad
            // 
            this.cmbPaisCiudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaisCiudad.FormattingEnabled = true;
            this.cmbPaisCiudad.Location = new System.Drawing.Point(180, 467);
            this.cmbPaisCiudad.Name = "cmbPaisCiudad";
            this.cmbPaisCiudad.Size = new System.Drawing.Size(158, 21);
            this.cmbPaisCiudad.Sorted = true;
            this.cmbPaisCiudad.TabIndex = 35;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(180, 528);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(158, 20);
            this.txtMonto.TabIndex = 34;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoB_KeyPress);
            // 
            // txtTiempoEstudio
            // 
            this.txtTiempoEstudio.Location = new System.Drawing.Point(571, 481);
            this.txtTiempoEstudio.Name = "txtTiempoEstudio";
            this.txtTiempoEstudio.Size = new System.Drawing.Size(200, 20);
            this.txtTiempoEstudio.TabIndex = 33;
            this.txtTiempoEstudio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTiempoEstudio_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(180, 366);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 20);
            this.txtNombre.TabIndex = 32;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreB_KeyPress);
            // 
            // txtCedula
            // 
            this.txtCedula.Enabled = false;
            this.txtCedula.Location = new System.Drawing.Point(180, 315);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(158, 20);
            this.txtCedula.TabIndex = 31;
            // 
            // dtpFechaViaje
            // 
            this.dtpFechaViaje.Enabled = false;
            this.dtpFechaViaje.Location = new System.Drawing.Point(568, 426);
            this.dtpFechaViaje.Name = "dtpFechaViaje";
            this.dtpFechaViaje.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaViaje.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(397, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Fecha de Viaje:";
            // 
            // lblPaisCiudad
            // 
            this.lblPaisCiudad.AutoSize = true;
            this.lblPaisCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaisCiudad.Location = new System.Drawing.Point(50, 467);
            this.lblPaisCiudad.Name = "lblPaisCiudad";
            this.lblPaisCiudad.Size = new System.Drawing.Size(75, 24);
            this.lblPaisCiudad.TabIndex = 28;
            this.lblPaisCiudad.Text = "Ciudad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 24);
            this.label6.TabIndex = 27;
            this.label6.Text = "Monto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(375, 476);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 24);
            this.label4.TabIndex = 26;
            this.label4.Text = "Tiempo de Estudio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Universidad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "Nombre:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 24);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cedula:";
            // 
            // btnPresentar
            // 
            this.btnPresentar.Location = new System.Drawing.Point(316, 244);
            this.btnPresentar.Name = "btnPresentar";
            this.btnPresentar.Size = new System.Drawing.Size(141, 32);
            this.btnPresentar.TabIndex = 42;
            this.btnPresentar.Text = "Presentar";
            this.btnPresentar.UseVisualStyleBackColor = true;
            this.btnPresentar.Click += new System.EventHandler(this.btnPresentar_Click);
            // 
            // frmFiltrarXNombre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 701);
            this.Controls.Add(this.btnPresentar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbUniversidad);
            this.Controls.Add(this.cmbPaisCiudad);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtTiempoEstudio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.dtpFechaViaje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPaisCiudad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dgvBecas);
            this.Controls.Add(this.txtNombreB);
            this.Controls.Add(this.txtMontoB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "frmFiltrarXNombre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBecas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMontoB;
        private System.Windows.Forms.TextBox txtNombreB;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvBecas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNro;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPaisCiuada;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUniversidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaEs;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFehcaV;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbInternacional;
        private System.Windows.Forms.RadioButton rdbNacional;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cmbUniversidad;
        private System.Windows.Forms.ComboBox cmbPaisCiudad;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtTiempoEstudio;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.DateTimePicker dtpFechaViaje;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPaisCiudad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPresentar;
    }
}