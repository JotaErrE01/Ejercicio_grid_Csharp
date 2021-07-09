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

        internal void Guardar(string nombre, string cedula, string universidad, string monto, string pais, string tiempo, DateTime fecha, RadioButton rdbNacional, string rutaImagen) {

            if (rdbNacional.Checked) {

                //BecaNacional becaNacional = null;
                double dMonto = validacion.AReal(monto);
                int iTiempo = validacion.AEntero(tiempo);
                BecaNacional becaNacional = new BecaNacional(nombre, cedula, pais, universidad, dMonto, iTiempo, rutaImagen);
                Lista.Add(becaNacional);


            }else {

                //BecaInternacional becaInternacional = null;
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