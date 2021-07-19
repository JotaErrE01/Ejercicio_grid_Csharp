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

namespace _05_ejercicio_clase.view
{
    public partial class frmFiltrarXNombre : Form{

        AdmBecaInternacionalJARR adm = AdmBecaInternacionalJARR.GetAdm();

        public frmFiltrarXNombre()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e){
            string nombre = txtNombreB.Text.Trim(), monto = txtMontoB.Text.Trim();
            adm.FiltrarxNombre(nombre, monto, dgvBecas);
        }

        private void txtMontoB_KeyPress(object sender, KeyPressEventArgs e){
            char c = e.KeyChar;
            if (!char.IsDigit(c) && (e.KeyChar != Convert.ToChar(Keys.Back)) && c != '.' && c != '*')
            {
                e.Handled = true;
                return;
            }
        }

        private void btnPresentar_Click(object sender, EventArgs e){
            adm.Presentar(dgvBecas, txtCedula, txtNombre, cmbUniversidad, cmbPaisCiudad, txtMonto, dtpFechaViaje, txtTiempoEstudio, rdbNacional, rdbInternacional, pbImage, lblPaisCiudad);
        }

        private void txtNombreB_KeyPress(object sender, KeyPressEventArgs e){
            char c = e.KeyChar;
            if (!char.IsLetter(c) && (e.KeyChar != Convert.ToChar(Keys.Back)) && c != ' ')
            {
                e.Handled = true;
                return;
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e){
            adm.SeleccionarImagen(pbImage);
        }

        private void btnGuardar_Click(object sender, EventArgs e){
            string nombre = txtNombre.Text.Trim(), cedula = txtCedula.Text, universidad = cmbUniversidad.Text, monto = txtMonto.Text, pais = cmbPaisCiudad.Text, tiempo = txtTiempoEstudio.Text, rutaImagen = pbImage.ImageLocation;
            DateTime fecha = dtpFechaViaje.Value.Date;

            if (adm.EsCorrecto(nombre, cedula, universidad, monto, pais, tiempo, fecha, rutaImagen))
            {

                adm.Editar(nombre, cedula, universidad, monto, pais, tiempo, fecha, rdbNacional, rutaImagen);
                adm.Agregar(txtArea);

            }
        }
    }
}
