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
    public partial class FrmFiltrarInternacionales : Form{

        AdmBeca adm = AdmBeca.GetAdm();

        public FrmFiltrarInternacionales(){
            InitializeComponent();
            cmbPais.Items.Add();
        }

        private void btnFiltrar_Click(object sender, EventArgs e){
            adm.filtrarInternacionales(cmbPais.Text, txtDias.Text, txtMonto.Text, dgvBecasInternacionales);
        }
    }
}
