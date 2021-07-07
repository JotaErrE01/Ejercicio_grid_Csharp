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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void mniRegistrar_Click(object sender, EventArgs e){
            frmBecaInternacional frm = new frmBecaInternacional();
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
    }
}
