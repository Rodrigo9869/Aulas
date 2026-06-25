using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI0924_Aulas
{
    internal class GerirForms
    {
        public static void TrocarForm (Form formAtual, Form NovoForm)
        {
            formAtual.Hide();
            NovoForm.ShowDialog();
            formAtual.Close();
        }
    }
}
