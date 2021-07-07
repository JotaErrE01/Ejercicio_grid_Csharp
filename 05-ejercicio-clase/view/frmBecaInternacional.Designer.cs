
namespace _05_ejercicio_clase
{
    partial class frmBecaInternacional
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaViaje = new System.Windows.Forms.DateTimePicker();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTiempoEstudio = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.cmbPais = new System.Windows.Forms.ComboBox();
            this.cmbUniversidad = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cedula:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Universidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tiempo de Estudio:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(393, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Monto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(393, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Pais:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(393, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 24);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fecha de Viaje:";
            // 
            // dtpFechaViaje
            // 
            this.dtpFechaViaje.Location = new System.Drawing.Point(542, 58);
            this.dtpFechaViaje.Name = "dtpFechaViaje";
            this.dtpFechaViaje.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaViaje.TabIndex = 9;
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(197, 59);
            this.txtCedula.MaxLength = 10;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(158, 20);
            this.txtCedula.TabIndex = 10;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(197, 110);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(158, 20);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtTiempoEstudio
            // 
            this.txtTiempoEstudio.Location = new System.Drawing.Point(197, 229);
            this.txtTiempoEstudio.Name = "txtTiempoEstudio";
            this.txtTiempoEstudio.Size = new System.Drawing.Size(158, 20);
            this.txtTiempoEstudio.TabIndex = 13;
            this.txtTiempoEstudio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(465, 111);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(121, 20);
            this.txtMonto.TabIndex = 14;
            this.txtMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMonto_KeyPress);
            // 
            // cmbPais
            // 
            this.cmbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPais.FormattingEnabled = true;
            this.cmbPais.Items.AddRange(new object[] {
            "Ecuador",
            "España",
            "Inglaterra",
            "USA"});
            this.cmbPais.Location = new System.Drawing.Point(465, 166);
            this.cmbPais.Name = "cmbPais";
            this.cmbPais.Size = new System.Drawing.Size(121, 21);
            this.cmbPais.Sorted = true;
            this.cmbPais.TabIndex = 15;
            // 
            // cmbUniversidad
            // 
            this.cmbUniversidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUniversidad.FormattingEnabled = true;
            this.cmbUniversidad.Items.AddRange(new object[] {
            "Universidad de Loja",
            "Universidad de Guayaquil",
            "Escuela Superior Politecnica del Litoral"});
            this.cmbUniversidad.Location = new System.Drawing.Point(197, 166);
            this.cmbUniversidad.Name = "cmbUniversidad";
            this.cmbUniversidad.Size = new System.Drawing.Size(158, 21);
            this.cmbUniversidad.TabIndex = 16;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(132, 316);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(117, 42);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(397, 224);
            this.txtArea.Multiline = true;
            this.txtArea.Name = "txtArea";
            this.txtArea.ReadOnly = true;
            this.txtArea.Size = new System.Drawing.Size(345, 148);
            this.txtArea.TabIndex = 18;
            // 
            // frmBecaInternacional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.cmbUniversidad);
            this.Controls.Add(this.cmbPais);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtTiempoEstudio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.dtpFechaViaje);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "frmBecaInternacional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Beca Internacional";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaViaje;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTiempoEstudio;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.ComboBox cmbPais;
        private System.Windows.Forms.ComboBox cmbUniversidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtArea;
    }
}

