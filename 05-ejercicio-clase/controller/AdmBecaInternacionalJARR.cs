using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_ejercicio_clase.controller{
    class AdmBecaInternacionalJARR{

        private static AdmBecaInternacionalJARR adm = null;
        List<Beca> lista = null;
        ValidacionJARR validacion = null;
        Beca beca = null;

        internal List<Beca> Lista { get => lista; set => lista = value; }

        private AdmBecaInternacionalJARR() {
            Lista = new List<Beca>();
            validacion = new ValidacionJARR();
        }

        internal void LLenarGrid(DataGridView dgvBecas, Label lblTotal){
            BecaInternacional bi = null;
            int i = 1;
            Lista.ForEach(beca => {
                if(beca.GetType() == typeof(BecaInternacional)){
                    bi = (BecaInternacional)beca;
                    dgvBecas.Rows.Add(i, beca.Cedula, beca.Nombre, bi.Pais, beca.Universidad, beca.Monto, beca.TiempoEstudio, bi.FechaViajeIda.ToShortDateString());
                    i++;
                }
                lblTotal.Text = i + "";
            });
        }

        public static AdmBecaInternacionalJARR GetAdm() {
            if(adm == null) {
                adm = new AdmBecaInternacionalJARR();
            }
            return adm;        
        }

        internal bool EsCorrecto(string nombre, string cedula, string universidad, string monto, string pais, string tiempo, DateTime fecha, string rutaImagen) {

            if(!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(rutaImagen) && !string.IsNullOrEmpty(cedula) && !string.IsNullOrEmpty(universidad) && !string.IsNullOrEmpty(monto) && !string.IsNullOrEmpty(pais) && !string.IsNullOrEmpty(tiempo) && fecha!=null && validacion.EsReal(monto)) {

                return true;
            }

            return false;
        }

        internal void Error(TextBox txtNombre, TextBox txtCedula, ComboBox cmbUniversidad, TextBox txtMonto, ComboBox cmbPaisCiudad, TextBox txtTiempoEstudio, PictureBox imageLocation, ErrorProvider erpGuardar)
        {
            
            if (txtNombre.Text == "") {
                erpGuardar.SetError(txtNombre, "No deben haber campos vacios");
            }

            if (txtCedula.Text == ""){
                erpGuardar.SetError(txtCedula, "No deben haber campos vacios");
            }

            if (cmbUniversidad.Text == ""){
                erpGuardar.SetError(cmbUniversidad, "No deben haber campos vacios");
            }

            if (txtMonto.Text == ""){
                erpGuardar.SetError(txtMonto, "No deben haber campos vacios");
            }

            if (txtMonto.Text == ""){
                erpGuardar.SetError(txtMonto, "No deben haber campos vacios");
            }

            if (cmbPaisCiudad.Text == ""){
                erpGuardar.SetError(cmbPaisCiudad, "No deben haber campos vacios");
            }

            if (txtTiempoEstudio.Text == ""){
                erpGuardar.SetError(txtTiempoEstudio, "No deben haber campos vacios");
            }

            if (imageLocation.ImageLocation == null){
                erpGuardar.SetError(imageLocation, "Debe existir una imagen");
            }

        }

        internal void Guardar(string nombre, string cedula, string universidad, string monto, string pais, string tiempo, DateTime fecha, RadioButton rdbNacional, string rutaImagen) {

            if (rdbNacional.Checked) {

                double dMonto = validacion.AReal(monto);
                int iTiempo = validacion.AEntero(tiempo);
                BecaNacional becaNacional = new BecaNacional(nombre, cedula, pais, universidad, dMonto, iTiempo, rutaImagen);
                Lista.Add(becaNacional);


            }else {

                double dMonto = validacion.AReal(monto);
                int iTiempo = validacion.AEntero(tiempo);
                BecaInternacional becaInternacional = new BecaInternacional(nombre, cedula, pais, universidad, dMonto, iTiempo, fecha, rutaImagen);
                Lista.Add(becaInternacional);

            }

        }

        internal void CambiarNacional(Label lblPaisCiudad, ComboBox cmbPaisCiudad, ComboBox cmbUniversidad){
            //limpiar items anteriores
            cmbUniversidad.Items.Clear();
            cmbPaisCiudad.Items.Clear();

            lblPaisCiudad.Text = "Ciudad:";
            cmbPaisCiudad.Items.Add("Guayaquil");
            cmbPaisCiudad.Items.Add("Loja");
            cmbPaisCiudad.Items.Add("Ambato");
            cmbPaisCiudad.Items.Add("Quito");

            cmbUniversidad.Items.Add("Universidad de Guayaquil");
            cmbUniversidad.Items.Add("Universidad de Loja");
            cmbUniversidad.Items.Add("Espol");
            cmbUniversidad.Items.Add("Universidad Central");
        }

        internal void CambiarInternacional(Label lblPaisCiudad, ComboBox cmbPaisCiudad, ComboBox cmbUniversidad){
            //limpiar items anterioes
            cmbUniversidad.Items.Clear();
            cmbPaisCiudad.Items.Clear();

            lblPaisCiudad.Text = "Pais:";
            cmbPaisCiudad.Items.Add("España");
            cmbPaisCiudad.Items.Add("Estados Unidos");
            cmbPaisCiudad.Items.Add("Londres");
            cmbPaisCiudad.Items.Add("Ecuador");

            cmbUniversidad.Items.Add("Universidad de Barcelona");
            cmbUniversidad.Items.Add("Harvard");
            cmbUniversidad.Items.Add("Oxford");
            cmbUniversidad.Items.Add("Espol");
        }

        internal void agregarInternacional(ListBox lstNacional, ListBox lstInternacional, int indice){
            beca = lista[indice];

            if (beca.GetType() == typeof(BecaNacional)){
                lstNacional.Items.Add(beca.Cedula);
            }else{
                lstInternacional.Items.Add(beca.Cedula);
            }
        }

        internal void Agregar(TextBox txtContenido) {
            txtContenido.Text += Lista[Lista.Count - 1].ToString();
        }

    }
}