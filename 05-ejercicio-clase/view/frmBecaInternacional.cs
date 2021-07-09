using _05_ejercicio_clase.controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_ejercicio_clase{

    public partial class frmBecaInternacional : Form{

        AdmBecaInternacionalJARR admBecaInternacional = AdmBecaInternacionalJARR.GetAdm();

        public frmBecaInternacional(){
            InitializeComponent();
            admBecaInternacional.CambiarNacional(lblPaisCiudad, cmbPaisCiudad, cmbUniversidad);
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e){
            char c = e.KeyChar;
            if (!char.IsDigit(c) && (e.KeyChar!=Convert.ToChar(Keys.Back))){
                e.Handled = true;
                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e){
            string nombre = txtNombre.Text.Trim(), cedula = txtCedula.Text, universidad = cmbUniversidad.Text, monto = txtMonto.Text, pais = cmbPaisCiudad.Text, tiempo = txtTiempoEstudio.Text, rutaImagen = pbImage.ImageLocation;
            DateTime fecha = dtpFechaViaje.Value.Date;

            if (admBecaInternacional.EsCorrecto(nombre, cedula, universidad, monto, pais, tiempo, fecha, rutaImagen)) {

                admBecaInternacional.Guardar(nombre, cedula, universidad, monto, pais, tiempo, fecha, rdbNacional, rutaImagen);
                admBecaInternacional.Agregar(txtArea);
                //erpGuardar.Clear();
            }
            //else{
            //    erpGuardar.SetError(btnGuardar, "No deben haber campos vacios");
            //}
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e){
            char c = e.KeyChar;
            if (!char.IsLetter(c) && (e.KeyChar != Convert.ToChar(Keys.Back)) && c != ' '){
                e.Handled = true;
                return;
            }
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e){
            char c = e.KeyChar;
            if (!char.IsDigit(c) && (e.KeyChar != Convert.ToChar(Keys.Back)) && c != '.'){
                e.Handled = true;
                return;
            }
        }

        private void rdbNacional_CheckedChanged(object sender, EventArgs e){
            admBecaInternacional.CambiarNacional(lblPaisCiudad, cmbPaisCiudad, cmbUniversidad);
            dtpFechaViaje.Enabled = false;
        }

        private void rdbInternacional_CheckedChanged(object sender, EventArgs e){
            admBecaInternacional.CambiarInternacional(lblPaisCiudad, cmbPaisCiudad, cmbUniversidad);
            dtpFechaViaje.Enabled = true;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e){
            OpenFileDialog ofdSeleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "FotoPerfil|*.jpg; *.png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofdSeleccionar.Title = "Seleccionar Imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK){
                //pbImage.Image = Image.FromFile(ofdSeleccionar.FileName);
                pbImage.ImageLocation = ofdSeleccionar.FileName;
            }
        }
    }
}
