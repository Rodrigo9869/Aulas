using Microsoft.VisualBasic;
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
    public partial class frm_inputbox : Form
    {
        public frm_inputbox()
        {
            InitializeComponent();
        }

        private void btn_inserirnome_Click(object sender, EventArgs e)
        {
            /*
             * 1º Adicionar referencia ao projeto: Microsoft.VisualBasic
             * bt direito do rato sobre o nome do projeto (dentro do solution explorer)
             * 
             * 2º no codigo cs deste formulario, adicionar: using Microsoft.VisualBasic;
             * 
             * 3º para usar a inputbox, digitar: Interaction.InputBox("Insira o seu nome", "Dados Pessoais");
             */

            string nome;
            nome = Interaction.InputBox("Insira o seu nome", "Dados Pessoais");

            if(string.IsNullOrEmpty(nome))
            {
                MessageBox.Show("Não inseriu nenhum nome!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            lbl_nomeinserido.Text = nome;
        }

        private void btn_menuPrincipal_Click(object sender, EventArgs e)
        {
            GerirForms.TrocarForm(this, new Form1());
        }
    }
}
