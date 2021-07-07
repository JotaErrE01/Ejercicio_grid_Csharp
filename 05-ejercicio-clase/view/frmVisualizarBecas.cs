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
    public partial class frmVisualizarBecas : Form{

        AdmBecaInternacionalJARR adm = AdmBecaInternacionalJARR.GetAdm();

        public frmVisualizarBecas(){
            InitializeComponent();
            cmbBecas.DataSource = adm.Lista;
            cmbBecas.DisplayMember = "Nombre";//el string es del getter y setter
            //cmbBecas.ValueMember = "NombreColumnaClave"; para seleccionar el campo clave de la tabla
            //cmbBecas.Items.Add("sadf"); agregar un valor
            //cmbBecas.Items.Remove("sadf"); eliminar un item
            //cmbBecas.Items.RemoveAt(0); remover por poscicion del item
        }

        private void rdbNacional_CheckedChanged(object sender, EventArgs e){
            picImage.Image = _05_ejercicio_clase.Properties.Resources.Zed_Galaxy_Slayer_nueva_skin_1233486646_144129_1440x600;
        }

        private void rdbInternacional_CheckedChanged(object sender, EventArgs e){
            picImage.Image = _05_ejercicio_clase.Properties.Resources.storm_dragon_lee_sin_splash_art_8k_league_of_legends_lol_papel_pintado_3840x2400_9;
        }

        private void chkNacional_CheckedChanged(object sender, EventArgs e){
            if (chkNacional.Checked) {
                lblNacional.Text = adm.Lista.Count - 1 + "";
            }else{
                lblNacional.Text = "______________";
            }
        }

        private void chkInternacional_CheckedChanged(object sender, EventArgs e){
            if (chkInternacional.Checked){
                lblInternacional.Text = adm.Lista.Count + "";
            }
            else {
                lblInternacional.Text = "______________";
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e){
            int indice = cmbBecas.SelectedIndex;
            if ( indice >= 0 ) {
                adm.agregarInternacional(lstInternacional, indice);
            }
        }
    }
}
