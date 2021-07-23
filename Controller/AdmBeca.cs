using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller{
    public class AdmBeca{

        private static AdmBeca adm = null;
        List<Beca> lista = null;
        ValidacionJARR validacion = null;
        Beca beca = null;
        int index = -1;

        public List<Beca> Lista { get => lista; set => lista = value; }

        private AdmBeca() {
            Lista = new List<Beca>();
            validacion = new ValidacionJARR();
        }

        public void LLenarGrid(DataGridView dgvBecas, Label lblTotal){
            BecaInternacional bi = null;
            BecaNacional bn = null;
            int i = 1;
            Lista.ForEach(beca => {
                if(beca.GetType() == typeof(BecaInternacional)){
                    bi = (BecaInternacional)beca;
                    dgvBecas.Rows.Add(i, beca.Cedula, beca.Nombre, bi.Pais, beca.Universidad, beca.Monto, beca.TiempoEstudio, bi.FechaViajeIda.ToShortDateString());
                }else if (beca.GetType() == typeof(BecaNacional)){
                    bn = (BecaNacional)beca;
                    dgvBecas.Rows.Add(i, beca.Cedula, beca.Nombre, bn.Ciudad, beca.Universidad, beca.Monto, beca.TiempoEstudio, "");
                }
                i++;
            });
            lblTotal.Text = i - 1 + "";
        }

        public void Presentar(DataGridView dgvBecas, TextBox txtCedula, TextBox txtNombre, ComboBox cmbUniversidad, ComboBox cmbPaisCiudad, TextBox txtMonto, DateTimePicker dtpFechaViaje, TextBox txtTiempoEstudio, RadioButton rdbNacional, RadioButton rdbInternacional, PictureBox pbImage, Label lblPaisCiudad)
        {

            if(dgvBecas.SelectedRows.Count != 1){
                MessageBox.Show("Seleccione una fila");
                return;
            }

            index = validacion.AEntero(dgvBecas[0, dgvBecas.CurrentRow.Index].Value.ToString()) - 1;

            Beca element = lista.ElementAt(index);

            cmbPaisCiudad.Items.Clear();
            cmbUniversidad.Items.Clear();

            if (element.GetType() == typeof(BecaNacional)) {
                rdbNacional.Checked = true;
                CambiarNacional(lblPaisCiudad, cmbPaisCiudad, cmbUniversidad);
                cmbPaisCiudad.SelectedItem = ((BecaNacional)element).Ciudad;
                dtpFechaViaje.Enabled = false;
            }
            else {
                //rdbNacional.Checked = false;
                rdbInternacional.Checked = true;
                CambiarInternacional(lblPaisCiudad, cmbPaisCiudad, cmbUniversidad);
                cmbPaisCiudad.SelectedItem = ((BecaInternacional)element).Pais;
                dtpFechaViaje.Value = ((BecaInternacional)element).FechaViajeIda.Date;
                dtpFechaViaje.Enabled = true;
            }
            
            txtCedula.Text = element.Cedula;
            txtNombre.Text = element.Nombre;
            cmbUniversidad.SelectedItem = (element).Universidad;
            txtMonto.Text = element.Monto.ToString();
            txtTiempoEstudio.Text = element.TiempoEstudio.ToString();
            pbImage.ImageLocation = element.Ruta;

        }

        public void Editar(string nombre, string cedula, string universidad, string monto, string pais, string tiempo, DateTime fecha, RadioButton rdbNacional, string rutaImagen){

            if (index == -1) return;

            if (rdbNacional.Checked){

                double dMonto = validacion.AReal(monto);
                int iTiempo = validacion.AEntero(tiempo);
                BecaNacional becaNacional = new BecaNacional(nombre, cedula, pais, universidad, dMonto, iTiempo, rutaImagen);
                //Lista.Add(becaNacional);
                Lista.RemoveAt(index);
                Lista.Insert(index, becaNacional);

            }
            else{

                double dMonto = validacion.AReal(monto);
                int iTiempo = validacion.AEntero(tiempo);
                BecaInternacional becaInternacional = new BecaInternacional(nombre, cedula, pais, universidad, dMonto, iTiempo, fecha, rutaImagen);
                //Lista.Add(becaInternacional);
                Lista.RemoveAt(index);
                Lista.Insert(index, becaInternacional);

            }

        }

        public void SeleccionarImagen(PictureBox pbImage){
            OpenFileDialog ofdSeleccionar = new OpenFileDialog();
            ofdSeleccionar.Filter = "FotoPerfil|*.jpg; *.png";
            ofdSeleccionar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofdSeleccionar.Title = "Seleccionar Imagen";

            if (ofdSeleccionar.ShowDialog() == DialogResult.OK)
            {
                //pbImage.Image = Image.FromFile(ofdSeleccionar.FileName);
                pbImage.ImageLocation = ofdSeleccionar.FileName;
            }
        }

        public void FiltrarxNombre(string nombre, string monto, DataGridView dgvBecas)
        {
            //validar campos vacios
            if (monto == "" && nombre == "") {
                MessageBox.Show("El Nombre y el Monto son obligatorios");
                return;
            };

            //limpiar tabla
            dgvBecas.Rows.Clear();

            int i = 1;

            if (validacion.EsReal(monto)){
                double dmonto = validacion.AReal(monto);
                lista.ForEach( beca => {
                    if (beca.Monto >= dmonto){
                        ObtenerTipos(dgvBecas, i, beca,  nombre);
                    }
                    i++;
                } );
            }
            else if(monto == "*"){
                lista.ForEach(beca => {
                    ObtenerTipos(dgvBecas, i, beca, nombre);
                    i++;
                });
            }
        }

        public void ObtenerTipos(DataGridView dgvBecas, int i, Beca beca, string nombre) {

            if (beca.GetType() == typeof(BecaNacional)){
                BecaNacional bn = (BecaNacional)beca;
                if (bn.Nombre == nombre){
                    dgvBecas.Rows.Add(i, beca.Cedula, beca.Nombre, bn.Ciudad, beca.Universidad, beca.Monto, beca.TiempoEstudio, "");
                }
            }

            if (beca.GetType() == typeof(BecaInternacional)){
                BecaInternacional bi = (BecaInternacional)beca;
                if (bi.Nombre == nombre){
                    dgvBecas.Rows.Add(i, beca.Cedula, beca.Nombre, bi.Pais, beca.Universidad, beca.Monto, beca.TiempoEstudio, bi.FechaViajeIda.ToShortDateString());
                }
            }
        }

        public void filtrarInternacionales(string pais, string dias, string monto, DataGridView dgvBecasInternacionales){

            //validar campos vacios
            if (pais == "" ||  monto == "" || dias == "") return;

            //limpiar tabla
            dgvBecasInternacionales.Rows.Clear();

            int i = 1;
            BecaInternacional bi = null;

            if (validacion.EsReal(monto) || validacion.EsReal(dias)){
                double dmonto = validacion.AReal(monto);

                lista.ForEach(beca => {
                    if (beca.Monto >= dmonto){
                        ObtenerInternacionales(dgvBecasInternacionales, i, beca, pais, dias);
                    }
                    i++;
                });
            }
        }

        private void ObtenerInternacionales(DataGridView dgvBecasInternacionales, int i, Beca beca, string pais, string dias){

            int diasBeca = validacion.AEntero(dias);

            if (beca.GetType() == typeof(BecaInternacional)){
                BecaInternacional bi = (BecaInternacional)beca;
                if (bi.Nombre == pais || calcularDias(bi.FechaViajeIda) == diasBeca){
                    dgvBecasInternacionales.Rows.Add(i, beca.Cedula, beca.Nombre, bi.Pais, beca.Universidad, beca.Monto, beca.TiempoEstudio, bi.FechaViajeIda.ToShortDateString());
                }
            }

        }

        private int calcularDias(DateTime fechaViajeIda){
            return fechaViajeIda.Day - DateTime.Now.Day;
        }

        public void filtrar(string lugar, string monto, DataGridView dgvBecas, int v){
            
            //validar campos vacios
            if (monto == "" && lugar == "") return;

            //validar si el monto es real
            if (!validacion.EsReal(monto)) return;

            //limpiar tabla
            dgvBecas.Rows.Clear();

            int i = 1;
            double dmonto = validacion.AReal(monto);
            BecaInternacional bi = null;
            BecaNacional bn = null;

            lista.ForEach(beca => {
                if (beca.Monto >= dmonto){
                    if (v == 1){
                        if (beca.GetType() == typeof(BecaNacional)){
                            bn = (BecaNacional)beca;
                            if(bn.Ciudad == lugar) {
                                dgvBecas.Rows.Add(i, beca.Cedula, beca.Nombre, bn.Ciudad, beca.Universidad, beca.Monto, beca.TiempoEstudio, "");
                            }
                        }
                    }
                    else if (v == 2){
                        if (beca.GetType() == typeof(BecaInternacional)){
                            bi = (BecaInternacional)beca;
                            if(bi.Pais == lugar) { 
                                dgvBecas.Rows.Add(i, beca.Cedula, beca.Nombre, bi.Pais, beca.Universidad, beca.Monto, beca.TiempoEstudio, bi.FechaViajeIda.ToShortDateString());
                            }
                        }
                    }
                    else if (v == 0){
                        if (beca.GetType() == typeof(BecaNacional)){
                            bn = (BecaNacional)beca;
                            dgvBecas.Rows.Add(i, beca.Cedula, beca.Nombre, bn.Ciudad, beca.Universidad, beca.Monto, beca.TiempoEstudio, "");
                        }

                        if (beca.GetType() == typeof(BecaInternacional))
                        {
                            bi = (BecaInternacional)beca;
                            dgvBecas.Rows.Add(i, beca.Cedula, beca.Nombre, bi.Pais, beca.Universidad, beca.Monto, beca.TiempoEstudio, bi.FechaViajeIda.ToShortDateString());
                        }
                    }
                }
                i++;
            });
        }

        public void CantidadInternacional(Label lblInternacional){
            int counter = 0;

            lista.ForEach(beca => {
                if (beca.GetType() == typeof(BecaInternacional)){
                    counter++;
                }
            });

            lblInternacional.Text = $"{counter}";
        }

        public void CantidadNacional(Label lblNacional){

            int counter = 0;

            lista.ForEach( beca => {
                if ( beca.GetType() == typeof(BecaNacional) ) {
                    counter++;
                }
            });

            lblNacional.Text = $"{counter}";
        }

        public void Eliminar(DataGridView dgvBecas, int posicion, Label lblTotal){
            dgvBecas.Rows.RemoveAt(posicion);//eliminando de la tabla
            lista.RemoveAt(posicion);//eliminando de la lista
            lblTotal.Text = lista.Count + "";
        }

        public static AdmBeca GetAdm() {
            if(adm == null) {
                adm = new AdmBeca();
            }
            return adm;        
        }

        public bool EsCorrecto(string nombre, string cedula, string universidad, string monto, string pais, string tiempo, DateTime fecha, string rutaImagen) {

            if(!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(rutaImagen) && !string.IsNullOrEmpty(cedula) && !string.IsNullOrEmpty(universidad) && !string.IsNullOrEmpty(monto) && !string.IsNullOrEmpty(pais) && !string.IsNullOrEmpty(tiempo) && fecha!=null && validacion.EsReal(monto)) {

                return true;
            }

            return false;
        }

        public void Error(TextBox txtNombre, TextBox txtCedula, ComboBox cmbUniversidad, TextBox txtMonto, ComboBox cmbPaisCiudad, TextBox txtTiempoEstudio, PictureBox imageLocation, ErrorProvider erpGuardar)
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

        public void Guardar(string nombre, string cedula, string universidad, string monto, string pais, string tiempo, DateTime fecha, RadioButton rdbNacional, string rutaImagen) {

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

        public void CambiarNacional(Label lblPaisCiudad, ComboBox cmbPaisCiudad, ComboBox cmbUniversidad){
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

        public void CambiarInternacional(Label lblPaisCiudad, ComboBox cmbPaisCiudad, ComboBox cmbUniversidad){
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

        public void agregarInternacional(ListBox lstNacional, ListBox lstInternacional, int indice){
            beca = lista[indice];

            if (beca.GetType() == typeof(BecaNacional)){
                lstNacional.Items.Add(beca.Cedula);
            }else{
                lstInternacional.Items.Add(beca.Cedula);
            }
        }

        public int getLengthList() {
            return lista.Count;
        }

        public void Agregar(TextBox txtContenido) {
            txtContenido.Text += Lista[Lista.Count - 1].ToString();
        }

    }
}