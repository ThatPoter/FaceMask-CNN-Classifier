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
    public partial class Eliminar : Form
    {
        login_adasDataSetTableAdapters.login_adasTableAdapter adapter;
        login_adasDataSet.login_adasDataTable table;

        public Eliminar()
        {
            InitializeComponent();
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'login_adasDataSet.login_adas' table. You can move, or remove it, as needed.
            this.login_adasTableAdapter.Fill(this.login_adasDataSet.login_adas);

            
            this.login_adasTableAdapter.FillByPesquisa(this.login_adasDataSet.login_adas, "%");

            // liga os diferentes campos ao data set para podermos inserir um novo utilizador na base de dados
            adapter = new login_adasDataSetTableAdapters.login_adasTableAdapter(); // chamar o adapter e guardar numa variavel
            login_adasDataSet.login_adasDataTable table = adapter.GetData(); // vai buscar os dados a tabela com o table adapter
            login_adasBindingSource.DataSource = table; // liga os campos ao data set
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Tem a certeza que quer eliminar este utilizador?", "Eliminar utilizador", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                // elimina a posição selecionada no DataGridView #*#*
                
                adapter.DeleteQuery(((System.Data.DataRowView)login_adasBindingSource.Current).Row["email"] as string);
                login_adasBindingSource.RemoveCurrent();
                adapter.Update(login_adasDataSet);
            }
        }

        private void btn_Procurar_Click(object sender, EventArgs e)
        {
            // não conseguimos fazer com que funcione #*#*
            this.login_adasTableAdapter.FillByPesquisa(this.login_adasDataSet.login_adas, "%" + tb_Pesquisa.Text + "%");
            login_adasTableAdapter.Fill(this.login_adasDataSet.login_adas);
        }

        private void btn_MostrarTudo_Click(object sender, EventArgs e)
        {
            // volta a mostrar a tabela com os dados todos (ainda não foi testado visto que não conseguimos pesquisar) #*#*
            this.login_adasTableAdapter.Fill(this.login_adasDataSet.login_adas);
        }
    }
}
