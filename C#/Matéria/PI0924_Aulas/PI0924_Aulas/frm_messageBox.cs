using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI0924_Aulas
{
    public partial class frm_messageBox : Form
    {
        public frm_messageBox()
        {
            InitializeComponent();
        }

        private void btn_menuPrincipal_Click(object sender, EventArgs e)
        {
            GerirForms.TrocarForm(this, new Form1());

        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Isto é uma messagebox", "msgbox", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btn_retorno_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("O que irá retornar?", "Retorno", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

            MessageBox.Show("Valor retornado: " + resultado, "Valor", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            if(resultado == DialogResult.Yes)
            {
                MessageBox.Show("Clicou: " + resultado);
            }
            else
                 if(resultado == DialogResult.No)
            {
                MessageBox.Show("Clicou: " + resultado);
            }
            else
                if(resultado == DialogResult.Cancel)
            {
                MessageBox.Show("Clicou: " + resultado);
            }
        }
    }
}
