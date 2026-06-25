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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_caixaTexto_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Cx abrirFrmCx = new frm_Cx();
            abrirFrmCx.ShowDialog();
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void btn_messageBox_Click(object sender, EventArgs e)
        {
            GerirForms.TrocarForm(this, new frm_messageBox());
        }

        private void btn_inputbox_Click(object sender, EventArgs e)
        {
            GerirForms.TrocarForm(this, new frm_inputbox());
        }

        private void btn_combobox_Click(object sender, EventArgs e)
        {
            GerirForms.TrocarForm(this, new frm_combobox());
        }
    }
}
