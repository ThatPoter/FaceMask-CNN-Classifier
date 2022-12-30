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
    public partial class PrincipalAdmin : Form
    {
        public void Design()
        {
            // coloca os paneis invisiveis
            panel_Funcionario.Visible = false;
            panel_Relatorios.Visible = false;
        }
        public void EsconderSubMenu()
        {
            // faz os paineis ficarem sem visibilidade
            if (panel_Funcionario.Visible == true)
            {
                panel_Funcionario.Visible = false;
            }
            if (panel_Relatorios.Visible == true)
            {
                panel_Relatorios.Visible = false;
            }
        }
        private void MostrarSubMenu(Panel submenu)
        {
            // torna aquele em que clicamos visivel e chama o metodo para esconder o outro
            if (submenu.Visible == false)
            {
                EsconderSubMenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
        private Form formEnable = null;
        private void ChamarForms(Form formSec)
        {
            // metodo que chama as forms para o painel secundario faz trocar ma forms pelas outras
            if (formEnable != null)
            {
                formEnable.Close();
            }
            formEnable = formSec;
            formSec.TopLevel = false;
            formSec.FormBorderStyle = FormBorderStyle.None;
            formSec.Dock = DockStyle.Fill;
            panel_FormsChamar.Controls.Add(formSec);
            panel_FormsChamar.Tag = formSec;
            formSec.BringToFront();
            formSec.Show();
        }

        public PrincipalAdmin()
        {
            InitializeComponent();
            Design();
        }

        private void btn_Funcionario_Click(object sender, EventArgs e)
        {
            // abre o painel de opções na aba funcionario
            MostrarSubMenu(panel_Funcionario);
        }

        private void btn_Ocorrencias_Click(object sender, EventArgs e)
        {
            // abre o painel de opções na ocorrencias
            MostrarSubMenu(panel_Relatorios);
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            // chama a forms consultar
            // temos alguns problemas nesta form ****
            ChamarForms(new Consultar());
            EsconderSubMenu();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            // chama a forms eliminar
            // temos alguns problemas nesta form ****
            ChamarForms(new Eliminar());
            EsconderSubMenu();
        }

        private void btn_Registar_Click(object sender, EventArgs e)
        {
            // chama a forms registar
            // não temos problemas aparentes nesta forms ****
            ChamarForms(new RegistarUtilizador());
            EsconderSubMenu();
        }

        private void btn_Relatorios_Click(object sender, EventArgs e)
        {
            // não conseguimos ainda implementar as ocorencias em condições na forms funcionar para as guardar aqui ****
            //MostrarSubMenu(panel_Relatorios);
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            // volta a forms Login
            Login log = new Login();
            this.Close();
            log.Show();
        }

        // não sei tirar isto sem dar erro ****
        private void panel_Relatorios_Paint(object sender, PaintEventArgs e)
        {
            // ****
        }
        private void panel_Funcionario_Paint(object sender, PaintEventArgs e)
        {
            // ****
        }
    }
}
