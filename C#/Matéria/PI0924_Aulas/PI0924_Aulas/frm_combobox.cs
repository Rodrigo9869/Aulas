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
    public partial class frm_combobox : Form
    {
        public frm_combobox()
        {
            InitializeComponent();
        }

        private void btn_menuPrincipal_Click(object sender, EventArgs e)
        {
            GerirForms.TrocarForm(this, new Form1());
        }

        private void cb_marcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_modelo.Items.Clear();

            if(cb_marcas.Text=="Audi")
            {
                cb_modelo.Enabled = true;
                cb_modelo.Items.Add("A1");
                cb_modelo.Items.Add("A3");
                cb_modelo.Items.Add("A5");
                cb_modelo.Items.Add("TT");
                cb_modelo.Items.Add("R8");
            }
            else
                if (cb_marcas.Text == "Toyota")
                {
                    cb_modelo.Enabled = true;
                    cb_modelo.Items.Add("Mr2");
                    cb_modelo.Items.Add("Trueno");
                    cb_modelo.Items.Add("Supra");
                    cb_modelo.Items.Add("Celica");
                    cb_modelo.Items.Add("Yaris");
                }
            else
                if (cb_marcas.Text == "Nissan")
                {
                    cb_modelo.Enabled = true;
                    cb_modelo.Items.Add("Skyline");
                    cb_modelo.Items.Add("Silvia");
                    cb_modelo.Items.Add("Fairlady");
                    cb_modelo.Items.Add("Z");
                 }
            else
            {
                cb_modelo.Enabled = false;
            }
        }
    }
}
