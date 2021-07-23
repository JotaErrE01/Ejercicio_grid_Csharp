using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View{

    public partial class FrmBeca : Form{

        AdmBeca adm = AdmBeca.GetAdm();

        public FrmBeca(){
            InitializeComponent();
            adm.CambiarNacional(lblPaisCiudad, cmbPaisCiudad, cmbUniversidad);
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

            if (adm.EsCorrecto(nombre, cedula, universidad, monto, pais, tiempo, fecha, rutaImagen)) {

                adm.Guardar(nombre, cedula, universidad, monto, pais, tiempo, fecha, rdbNacional, rutaImagen);
                adm.Agregar(txtArea);
                erpGuardar.Clear();

            }
            else{
                adm.Error(txtNombre, txtCedula, cmbUniversidad, txtMonto, cmbPaisCiudad, txtTiempoEstudio, pbImage, erpGuardar);
            }
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
            adm.CambiarNacional(lblPaisCiudad, cmbPaisCiudad, cmbUniversidad);
            dtpFechaViaje.Enabled = false;
        }

        private void rdbInternacional_CheckedChanged(object sender, EventArgs e){
            adm.CambiarInternacional(lblPaisCiudad, cmbPaisCiudad, cmbUniversidad);
            dtpFechaViaje.Enabled = true;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e){

            //adm.SeleccionarImagen(pbImage);

        }
    }
}
