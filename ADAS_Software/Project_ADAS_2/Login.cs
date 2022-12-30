using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_ADAS_2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            tb_Email.Select();
        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            // vai devolver um count como null ou notnull usando os table adapters
            // abre form funcionário
            if (login_adasTableAdapter1.ScalarQuery_autenticacao(tb_Password.Text, tb_Email.Text, cbx_stats.Text) != null && cbx_stats.Text == "Funcionário")
            {
                Principal pr = new Principal();
                pr.Show();
                this.Hide();
            }
            //abre form admin
            else if (login_adasTableAdapter1.ScalarQuery_autenticacao(tb_Password.Text, tb_Email.Text, cbx_stats.Text) != null && cbx_stats.Text == "Administrador")
            {
                PrincipalAdmin pra = new PrincipalAdmin();
                pra.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Credências erradas!\n Verique se todos os campos estão corretos!");
            }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
