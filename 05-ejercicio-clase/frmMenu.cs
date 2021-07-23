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

namespace View
{
    public partial class frmMenu : Form{

        AdmBeca adm = AdmBeca.GetAdm();

        public frmMenu(){
            InitializeComponent();
        }

        private void mniRegistrar_Click(object sender, EventArgs e){
            FrmBeca frm = new FrmBeca();
            frm.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e){
            Application.Exit();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e){
            frmListar listar = new frmListar();
            listar.ShowDialog();
        }

        private void mniVisualizar_Click(object sender, EventArgs e){
            frmVisualizarBecas frm = new frmVisualizarBecas();
            frm.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e){
            if (adm.getLengthList() > 0){
                frmListar listar = new frmListar();
                listar.ShowDialog();
            }
            else{
                MessageBox.Show("No existen registros de becas");
            }
        }

        private void filtrarToolStripMenuItem_Click(object sender, EventArgs e){
            FrmFiltrar filtar = new FrmFiltrar();
            filtar.ShowDialog();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e){
            frmFiltrarXNombre editar = new frmFiltrarXNombre();
            editar.ShowDialog();
        }
    }
}
