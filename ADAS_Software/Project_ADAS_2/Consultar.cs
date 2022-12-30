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
    public partial class Consultar : Form
    {
        login_adasDataSetTableAdapters.login_adasTableAdapter adapter;
        login_adasDataSet.login_adasDataTable table;

        public Consultar()
        {
            InitializeComponent();
            // esconde os campos para o update dos dados
            btn_Update.Hide();
            btn_Cancelar.Hide();
            tb_Nome.Hide();
            tb_Pass.Hide();
            tb_Email.Hide();
            cb_estatuto.Hide();
            tb_ConfPass.Hide();
            label_nome.Hide();
            label_password.Hide();
            label_email.Hide();
            label_estatuto.Hide();
            label_confpass.Hide();
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'login_adasDataSet.login_adas' table. You can move, or remove it, as needed.
            this.login_adasTableAdapter.Fill(this.login_adasDataSet.login_adas);

            // liga os diferentes campos ao data set para podermos inserir um novo utilizador na base de dados
            adapter = new login_adasDataSetTableAdapters.login_adasTableAdapter(); // chamar o adapter e guardar numa variavel
            login_adasDataSet.login_adasDataTable table = adapter.GetData(); // vai buscar os dados a tabela com o table adapter
            login_adasBindingSourceUpdate.DataSource = table; // liga os campos ao data set
            
            
            //this.login_adasBindingSourceUpdate.DataMember = "login_adas";
            //this.login_adasBindingSourceUpdate.DataSource = this.login_adasDataSet;
            //this.login_adasTableAdapter.Fill(this.login_adasDataSet.login_adas);

            
            //tb_Nome.DataBindings.Add(new Binding("Text", login_adasBindingSourceUpdate, "username", true));
            tb_Pass.DataBindings.Add(new Binding("Text", login_adasBindingSourceUpdate, "password", true));
            tb_ConfPass.DataBindings.Add(new Binding("Text", login_adasBindingSourceUpdate, "password", true));
            cb_estatuto.DataBindings.Add(new Binding("Text", login_adasBindingSourceUpdate, "autoridade", true));
            tb_Email.DataBindings.Add(new Binding("Text", login_adasBindingSourceUpdate, "email", true));
        }

        private void btn_AtualizarSelecionado_Click(object sender, EventArgs e)
        {
            // faz aparecer os campos todos para actualizar os dados do utilizador
            btn_Update.Show();
            btn_Cancelar.Show();
            tb_Nome.Show();
            tb_Pass.Show();
            tb_Email.Show();
            cb_estatuto.Show();
            tb_ConfPass.Show();
            label_nome.Show();
            label_password.Show();
            label_email.Show();
            label_estatuto.Show();
            label_confpass.Show();
        }

        private void btn_Procurar_Click(object sender, EventArgs e)
        {
            this.login_adasTableAdapter.FillByPesquisa(this.login_adasDataSet.login_adas, "%" + tb_Pesquisa.Text + "%");
        }

        private void btn_MostrarTudo_Click(object sender, EventArgs e)
        {
            // mostra os dados todos outra vez (ainda não testado) #*#*
            this.login_adasTableAdapter.Fill(this.login_adasDataSet.login_adas);
        }

        private void btn_Apaga_Click(object sender, EventArgs e)
        {
            // volta a mostrar a tabela com os dados todos e apaga o texto na caixa de texto
            tb_Pesquisa.Clear();
            this.login_adasTableAdapter.Fill(this.login_adasDataSet.login_adas);
        }
        
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (tb_Pass.Text != tb_ConfPass.Text)
            {
                MessageBox.Show("É as passwords não coincidem.");
            }
            else
            {
                adapter.UpdateConsultar(tb_Nome.Text, tb_Pass.Text, cb_estatuto.Text, tb_Email.Text);
                login_adasBindingSourceUpdate.ResetBindings(false);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            // esconde os campos para o update dos dados
            btn_Update.Hide();
            btn_Cancelar.Hide();
            tb_Nome.Hide();
            tb_Pass.Hide();
            tb_Email.Hide();
            cb_estatuto.Hide();
            tb_ConfPass.Hide();
            label_nome.Hide();
            label_password.Hide();
            label_email.Hide();
            label_estatuto.Hide();
            label_confpass.Hide();
        }
    }
}
