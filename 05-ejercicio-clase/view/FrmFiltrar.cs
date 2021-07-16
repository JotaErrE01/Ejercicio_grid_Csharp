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
    public partial class FrmFiltrar : Form{

        AdmBecaInternacionalJARR adm = AdmBecaInternacionalJARR.GetAdm();

        public FrmFiltrar()
        {
            InitializeComponent();
        }

        private void rdbTodos_CheckedChanged(object sender, EventArgs e){
            txtCiudadPais.Enabled = false;
        }

        private void btnFiltrar_Click(object sender, EventArgs e){

            string lugar = txtCiudadPais.Text.Trim(), monto = txtMonto.Text.Trim();

            if (rdbNacional.Checked)
            {
                adm.filtrar(lugar, monto, dgvBecas, 1);//1=nacional
            }else if(rdbInternacional.Checked){
                adm.filtrar(lugar, monto, dgvBecas, 2);
            }else if (rdbTodos.Checked) {
                adm.filtrar(lugar, monto, dgvBecas, 0);
            }

        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e){
            char c = e.KeyChar;
            if (!char.IsDigit(c) && (e.KeyChar != Convert.ToChar(Keys.Back)) && c != '.'){
                e.Handled = true;
                return;
            }
        }

        private void txtCiudadPais_KeyPress(object sender, KeyPressEventArgs e){
            char c = e.KeyChar;
            if (!char.IsLetter(c) && (e.KeyChar != Convert.ToChar(Keys.Back)) && c != ' '){
                e.Handled = true;
                return;
            }
        }

        private void rdbInternacional_CheckedChanged(object sender, EventArgs e){
            txtCiudadPais.Enabled = true;
        }

        private void rdbNacional_CheckedChanged(object sender, EventArgs e){
            txtCiudadPais.Enabled = false;
        }
    }
}
