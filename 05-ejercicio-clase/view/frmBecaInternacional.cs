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
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e){
            char c = e.KeyChar;
            if (!char.IsDigit(c) && (e.KeyChar!=Convert.ToChar(Keys.Back))){
                e.Handled = true;
                return;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e){
            string nombre = txtNombre.Text.Trim(), cedula = txtCedula.Text, universidad = cmbUniversidad.Text, monto = txtMonto.Text, pais = cmbPais.Text, tiempo = txtTiempoEstudio.Text;
            DateTime fecha = dtpFechaViaje.Value.Date;

            if (admBecaInternacional.EsCorrecto(nombre, cedula, universidad, monto, pais, tiempo, fecha)) {

                admBecaInternacional.Guardar(nombre, cedula, universidad, monto, pais, tiempo, fecha);
                admBecaInternacional.Agregar(txtArea);

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
    }
}
