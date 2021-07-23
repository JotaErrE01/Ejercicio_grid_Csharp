
namespace View
{
    partial class frmVisualizarBecas
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
            this.rdbNacional = new System.Windows.Forms.RadioButton();
            this.rdbInternacional = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbBecas = new System.Windows.Forms.ComboBox();
            this.lstNacional = new System.Windows.Forms.ListBox();
            this.lstInternacional = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.chkInternacional = new System.Windows.Forms.CheckBox();
            this.chkNacional = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNacional = new System.Windows.Forms.Label();
            this.lblInternacional = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbNacional
            // 
            this.rdbNacional.AutoSize = true;
            this.rdbNacional.Checked = true;
            this.rdbNacional.Location = new System.Drawing.Point(30, 32);
            this.rdbNacional.Name = "rdbNacional";
            this.rdbNacional.Size = new System.Drawing.Size(67, 17);
            this.rdbNacional.TabIndex = 0;
            this.rdbNacional.TabStop = true;
            this.rdbNacional.Text = "Nacional";
            this.rdbNacional.UseVisualStyleBackColor = true;
            this.rdbNacional.CheckedChanged += new System.EventHandler(this.rdbNacional_CheckedChanged);
            // 
            // rdbInternacional
            // 
            this.rdbInternacional.AutoSize = true;
            this.rdbInternacional.Location = new System.Drawing.Point(141, 32);
            this.rdbInternacional.Name = "rdbInternacional";
            this.rdbInternacional.Size = new System.Drawing.Size(86, 17);
            this.rdbInternacional.TabIndex = 1;
            this.rdbInternacional.Text = "Internacional";
            this.rdbInternacional.UseVisualStyleBackColor = true;
            this.rdbInternacional.CheckedChanged += new System.EventHandler(this.rdbInternacional_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNacional);
            this.groupBox1.Controls.Add(this.rdbInternacional);
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Becas";
            // 
            // cmbBecas
            // 
            this.cmbBecas.FormattingEnabled = true;
            this.cmbBecas.Location = new System.Drawing.Point(58, 150);
            this.cmbBecas.Name = "cmbBecas";
            this.cmbBecas.Size = new System.Drawing.Size(121, 21);
            this.cmbBecas.TabIndex = 4;
            // 
            // lstNacional
            // 
            this.lstNacional.FormattingEnabled = true;
            this.lstNacional.Location = new System.Drawing.Point(59, 217);
            this.lstNacional.Name = "lstNacional";
            this.lstNacional.Size = new System.Drawing.Size(120, 95);
            this.lstNacional.TabIndex = 5;
            // 
            // lstInternacional
            // 
            this.lstInternacional.FormattingEnabled = true;
            this.lstInternacional.Location = new System.Drawing.Point(299, 217);
            this.lstInternacional.Name = "lstInternacional";
            this.lstInternacional.Size = new System.Drawing.Size(120, 95);
            this.lstInternacional.TabIndex = 6;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(302, 140);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 39);
            this.btnAgregar.TabIndex = 7;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // chkInternacional
            // 
            this.chkInternacional.AutoSize = true;
            this.chkInternacional.Location = new System.Drawing.Point(557, 306);
            this.chkInternacional.Name = "chkInternacional";
            this.chkInternacional.Size = new System.Drawing.Size(87, 17);
            this.chkInternacional.TabIndex = 8;
            this.chkInternacional.Text = "Internacional";
            this.chkInternacional.UseVisualStyleBackColor = true;
            this.chkInternacional.CheckedChanged += new System.EventHandler(this.chkInternacional_CheckedChanged);
            // 
            // chkNacional
            // 
            this.chkNacional.AutoSize = true;
            this.chkNacional.Location = new System.Drawing.Point(557, 248);
            this.chkNacional.Name = "chkNacional";
            this.chkNacional.Size = new System.Drawing.Size(68, 17);
            this.chkNacional.TabIndex = 9;
            this.chkNacional.Text = "Nacional";
            this.chkNacional.UseVisualStyleBackColor = true;
            this.chkNacional.CheckedChanged += new System.EventHandler(this.chkNacional_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 376);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Total:";
            // 
            // lblNacional
            // 
            this.lblNacional.AutoSize = true;
            this.lblNacional.Location = new System.Drawing.Point(123, 376);
            this.lblNacional.Name = "lblNacional";
            this.lblNacional.Size = new System.Drawing.Size(67, 13);
            this.lblNacional.TabIndex = 12;
            this.lblNacional.Text = "__________";
            // 
            // lblInternacional
            // 
            this.lblInternacional.AutoSize = true;
            this.lblInternacional.Location = new System.Drawing.Point(337, 376);
            this.lblInternacional.Name = "lblInternacional";
            this.lblInternacional.Size = new System.Drawing.Size(67, 13);
            this.lblInternacional.TabIndex = 13;
            this.lblInternacional.Text = "__________";
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(498, 23);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(181, 95);
            this.picImage.TabIndex = 15;
            this.picImage.TabStop = false;
            // 
            // frmVisualizarBecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.lblInternacional);
            this.Controls.Add(this.lblNacional);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkNacional);
            this.Controls.Add(this.chkInternacional);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lstInternacional);
            this.Controls.Add(this.lstNacional);
            this.Controls.Add(this.cmbBecas);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVisualizarBecas";
            this.Text = "frmVisualizarBecas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbNacional;
        private System.Windows.Forms.RadioButton rdbInternacional;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBecas;
        private System.Windows.Forms.ListBox lstNacional;
        private System.Windows.Forms.ListBox lstInternacional;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.CheckBox chkInternacional;
        private System.Windows.Forms.CheckBox chkNacional;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNacional;
        private System.Windows.Forms.Label lblInternacional;
        private System.Windows.Forms.PictureBox picImage;
    }
}