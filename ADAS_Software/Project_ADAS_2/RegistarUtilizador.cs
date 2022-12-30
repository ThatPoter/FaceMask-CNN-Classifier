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
    public partial class RegistarUtilizador : Form
    {
        login_adasDataSetTableAdapters.login_adasTableAdapter adapter;
        login_adasDataSet.login_adasDataTable table;

        public RegistarUtilizador()
        {
            InitializeComponent();
        }

        private void RegistarUtilizador_Load(object sender, EventArgs e)
        {
            // liga os diferentes campos ao data set para podermos inserir um novo utilizador na base de dados
            adapter = new login_adasDataSetTableAdapters.login_adasTableAdapter(); // chamar o adapter e guardar numa variavel
            login_adasDataSet.login_adasDataTable table = adapter.GetData(); // vai buscar os dados a tabela com o table adapter
            login_adasBindingSourceRegistar.DataSource = table; // liga os campos ao data set
        }

        private void btn_Registar_Click(object sender, EventArgs e)
        {
            // regista um novo utilizador na base de dados
            login_adasBindingSourceRegistar.EndEdit(); 
            table = adapter.GetData();
            // caso este nome já exista ou faltar algum dos campos, ele devolve uma messagebox
            if (login_adasTableAdapterResgistar.ScalarQuery_existencia(tb_Nome.Text, tb_Pass.Text, cb_estatuto.Text, tb_Email.Text) != null || tb_Pass.Text == "" || tb_Pass.Text != tb_ConfPass.Text || cb_estatuto.Text == "" || tb_Email.Text == "")
            {
                MessageBox.Show("É necessário que todos os campos estejam preenchidos e que as passwords coincidam.\nTambém poderá estar a duplicar utilizadores, pode verificar essa situação na área de consulta!");
            }
            else
            {
                // se tudo estiver em condições ele insere o novo utilizador no DataSet
                adapter.Insert(tb_Nome.Text, tb_Pass.Text, cb_estatuto.Text, tb_Email.Text);
                MessageBox.Show("Utilizador registado com sucesso.");

                // mete os campos todos limpos como começam
                tb_Nome.Clear();
                tb_Pass.Clear();
                cb_estatuto.Text = "";
                tb_Email.Clear();
                tb_ConfPass.Clear();

                // isto era para o caso de termos mais que uma tabela (utilizadores e ocorrencias) ****
                //this.tableAdapterManager.UpdateAll(this.login_adasDataSetRegistar);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            // mete os campos todos limpos como começam
            tb_Nome.Clear();
            tb_Pass.Clear();
            cb_estatuto.Text = "";
            tb_Email.Clear();
            tb_ConfPass.Clear();
        }
    }
}
