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

        internal bool EsCorrecto(string nombre, string cedula, string universidad, string monto, string pais, string tiempo, DateTime fecha) {

            if(!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(universidad) && !string.IsNullOrEmpty(monto) && !string.IsNullOrEmpty(pais) && !string.IsNullOrEmpty(tiempo) && fecha!=null && validacion.EsReal(monto)) {

                return true;
            }
                return false;
        }

        internal void Guardar(string nombre, string cedula, string universidad, string monto, string pais, string tiempo, DateTime fecha) {

            BecaInternacional becaInternacional = null;
            double dMonto = validacion.AReal(monto);
            int iTiempo = validacion.AEntero(tiempo);
            becaInternacional = new BecaInternacional(nombre, cedula, pais, universidad, dMonto, iTiempo, fecha);
            Lista.Add(becaInternacional);
        }

        internal void agregarInternacional(ListBox lstInternacional, int indice){
            beca = lista[indice]  ;
            lstInternacional.Items.Add(beca.Cedula);

            //if(beca.GetType() == typeof(BecaNacional)) {

            //}else{
            //}
        }

        internal void Agregar(TextBox txtContenido) {
            txtContenido.Text += Lista[Lista.Count - 1].ToString();
        }

    }
}
