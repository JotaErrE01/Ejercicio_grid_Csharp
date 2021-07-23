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
    public partial class frmListar : Form{

        AdmBeca adm = AdmBeca.GetAdm();

        public frmListar(){
            InitializeComponent();
            adm.LLenarGrid(dgvBecas, lblTotal);
        }

        private void btnEliminar_Click(object sender, EventArgs e){
            int posicion = dgvBecas.CurrentRow.Index; //indice de la fila seleccionada
            if (posicion >= 0){
                adm.Eliminar(dgvBecas, posicion, lblTotal);
            }
        }
    }
}
