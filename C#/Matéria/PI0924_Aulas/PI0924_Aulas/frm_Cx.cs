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
    public partial class frm_Cx : Form
    {
        public frm_Cx()
        {
            InitializeComponent();

            
            txt_nome_completo.TextChanged += validarCampo;
            txt_nome.TextChanged += validarCampo;
            txt_apelido.TextChanged += validarCampo;
        }

        private void validarCampo(object sender, EventArgs e)
        {
            if (txt_nome.Text != "" && txt_apelido.Text != "" && txt_nome_completo.Text != "")
            {
                btn_limparTudo.Enabled = true;
            }
            else
            {
                btn_limparTudo.Enabled = false;
            }
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 abrirMenuPrincipal = new Form1();
            abrirMenuPrincipal.ShowDialog();
            this.Close();
        }

        private void btn_nome_completo_Click(object sender, EventArgs e)
        {
            txt_nome_completo.Text=txt_nome.Text +" "+ txt_apelido.Text;
        }

        private void frm_Cx_Load(object sender, EventArgs e)
        {
            btn_limpar_nome.Enabled=false;
            btn_Limpar_Apelido.Enabled=false;
            btn_Limpar_Completo.Enabled=false;
            btn_limparTudo.Enabled=false;

            Random rnd = new Random();
            int num_alt = rnd.Next(1, 100);
            lbl_aletaorio.Text = num_alt.ToString();

            
        }

        private void btn_limpar_nome_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            // txt_nome.text="";
            //txt_nome.Text=string.Empty;
        }

    

        private void btn_limparTudo_Click(object sender, EventArgs e)
        {
                txt_nome.Clear();
                txt_apelido.Clear();
                txt_nome_completo.Clear();
        }

        private void btn_Limpar_Apelido_Click(object sender, EventArgs e)
        {
            txt_apelido.Clear();
        }

        private void btn_Limpar_Completo_Click(object sender, EventArgs e)
        {
            txt_nome_completo.Clear();
        }

        private void txt_nome_KeyPress(object sender, KeyPressEventArgs e)
        {
            btn_limpar_nome.Enabled = true;
        }

        private void txt_apelido_Enter(object sender, EventArgs e)
        {
            btn_Limpar_Apelido.Enabled = true;
        }

       

        private void txt_nome_completo_MouseClick_1(object sender, MouseEventArgs e)
        {
            btn_nome_completo.Enabled= true;    
        }

        private void btn_corFundo_Click(object sender, EventArgs e)
        {
            lbl_corFundo.BackColor = Color.FromArgb(100, 100, 100);
            lbl_corFundo.ForeColor = Color.White;
            //lbl_corFundo.BackColor = Color.Blue;

            this.BackColor = Color.Aqua;
        }

        private void btn_resetColor_Click(object sender, EventArgs e)
        {
            lbl_corFundo.BackColor = SystemColors.Control;
            lbl_corFundo.ForeColor = SystemColors.ControlText;

            this.BackColor = SystemColors.Window;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
             {
                e.Handled = true;
            }
        }
    }
}
