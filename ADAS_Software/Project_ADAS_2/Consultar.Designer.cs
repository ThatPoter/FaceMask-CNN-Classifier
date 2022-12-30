namespace Projeto_ADAS_2
{
    partial class Consultar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoridadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login_adasBindingSourceUpdate = new System.Windows.Forms.BindingSource(this.components);
            this.login_adasDataSet = new Projeto_ADAS_2.login_adasDataSet();
            this.label_Pesquisa = new System.Windows.Forms.Label();
            this.tb_Pesquisa = new System.Windows.Forms.TextBox();
            this.btn_MostrarTudo = new System.Windows.Forms.Button();
            this.btn_Procurar = new System.Windows.Forms.Button();
            this.login_adasTableAdapter = new Projeto_ADAS_2.login_adasDataSetTableAdapters.login_adasTableAdapter();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.cb_estatuto = new System.Windows.Forms.ComboBox();
            this.tb_ConfPass = new System.Windows.Forms.TextBox();
            this.label_confpass = new System.Windows.Forms.Label();
            this.tb_Pass = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.label_estatuto = new System.Windows.Forms.Label();
            this.label_email = new System.Windows.Forms.Label();
            this.label_nome = new System.Windows.Forms.Label();
            this.btn_Apaga = new System.Windows.Forms.Button();
            this.tableAdapterManager = new Projeto_ADAS_2.login_adasDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_adasBindingSourceUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_adasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.autoridadeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.login_adasBindingSourceUpdate;
            this.dataGridView.Location = new System.Drawing.Point(81, 169);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(820, 205);
            this.dataGridView.TabIndex = 0;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 165;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.Width = 160;
            // 
            // autoridadeDataGridViewTextBoxColumn
            // 
            this.autoridadeDataGridViewTextBoxColumn.DataPropertyName = "autoridade";
            this.autoridadeDataGridViewTextBoxColumn.HeaderText = "Estatuto";
            this.autoridadeDataGridViewTextBoxColumn.Name = "autoridadeDataGridViewTextBoxColumn";
            this.autoridadeDataGridViewTextBoxColumn.Width = 160;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 282;
            // 
            // login_adasBindingSourceUpdate
            // 
            this.login_adasBindingSourceUpdate.DataMember = "login_adas";
            this.login_adasBindingSourceUpdate.DataSource = this.login_adasDataSet;
            // 
            // login_adasDataSet
            // 
            this.login_adasDataSet.DataSetName = "login_adasDataSet";
            this.login_adasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_Pesquisa
            // 
            this.label_Pesquisa.AutoSize = true;
            this.label_Pesquisa.BackColor = System.Drawing.Color.Transparent;
            this.label_Pesquisa.ForeColor = System.Drawing.Color.Black;
            this.label_Pesquisa.Location = new System.Drawing.Point(77, 64);
            this.label_Pesquisa.Name = "label_Pesquisa";
            this.label_Pesquisa.Size = new System.Drawing.Size(66, 22);
            this.label_Pesquisa.TabIndex = 1;
            this.label_Pesquisa.Text = "Nome:";
            // 
            // tb_Pesquisa
            // 
            this.tb_Pesquisa.Location = new System.Drawing.Point(149, 61);
            this.tb_Pesquisa.Name = "tb_Pesquisa";
            this.tb_Pesquisa.Size = new System.Drawing.Size(572, 29);
            this.tb_Pesquisa.TabIndex = 2;
            // 
            // btn_MostrarTudo
            // 
            this.btn_MostrarTudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btn_MostrarTudo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_MostrarTudo.Location = new System.Drawing.Point(737, 120);
            this.btn_MostrarTudo.Name = "btn_MostrarTudo";
            this.btn_MostrarTudo.Size = new System.Drawing.Size(164, 34);
            this.btn_MostrarTudo.TabIndex = 3;
            this.btn_MostrarTudo.Text = "Mostrar Tudo";
            this.btn_MostrarTudo.UseVisualStyleBackColor = false;
            this.btn_MostrarTudo.Click += new System.EventHandler(this.btn_MostrarTudo_Click);
            // 
            // btn_Procurar
            // 
            this.btn_Procurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btn_Procurar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Procurar.Location = new System.Drawing.Point(81, 120);
            this.btn_Procurar.Name = "btn_Procurar";
            this.btn_Procurar.Size = new System.Drawing.Size(164, 34);
            this.btn_Procurar.TabIndex = 5;
            this.btn_Procurar.Text = "Procurar";
            this.btn_Procurar.UseVisualStyleBackColor = false;
            this.btn_Procurar.Click += new System.EventHandler(this.btn_Procurar_Click);
            // 
            // login_adasTableAdapter
            // 
            this.login_adasTableAdapter.ClearBeforeFill = true;
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btn_Atualizar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Atualizar.Location = new System.Drawing.Point(386, 120);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(223, 34);
            this.btn_Atualizar.TabIndex = 6;
            this.btn_Atualizar.Text = "Atualizar Selecionado";
            this.btn_Atualizar.UseVisualStyleBackColor = false;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_AtualizarSelecionado_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancelar.Location = new System.Drawing.Point(727, 515);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(174, 38);
            this.btn_Cancelar.TabIndex = 26;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Update.Location = new System.Drawing.Point(547, 515);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(174, 38);
            this.btn_Update.TabIndex = 25;
            this.btn_Update.Text = "Actualizar";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // cb_estatuto
            // 
            this.cb_estatuto.FormattingEnabled = true;
            this.cb_estatuto.Items.AddRange(new object[] {
            "Administrador",
            "Funcionário"});
            this.cb_estatuto.Location = new System.Drawing.Point(206, 450);
            this.cb_estatuto.Name = "cb_estatuto";
            this.cb_estatuto.Size = new System.Drawing.Size(220, 29);
            this.cb_estatuto.TabIndex = 24;
            // 
            // tb_ConfPass
            // 
            this.tb_ConfPass.Location = new System.Drawing.Point(681, 453);
            this.tb_ConfPass.Name = "tb_ConfPass";
            this.tb_ConfPass.PasswordChar = '*';
            this.tb_ConfPass.Size = new System.Drawing.Size(220, 29);
            this.tb_ConfPass.TabIndex = 23;
            // 
            // label_confpass
            // 
            this.label_confpass.AutoSize = true;
            this.label_confpass.ForeColor = System.Drawing.Color.Black;
            this.label_confpass.Location = new System.Drawing.Point(450, 456);
            this.label_confpass.Name = "label_confpass";
            this.label_confpass.Size = new System.Drawing.Size(187, 22);
            this.label_confpass.TabIndex = 22;
            this.label_confpass.Text = "Confirmar Password:";
            // 
            // tb_Pass
            // 
            this.tb_Pass.Location = new System.Drawing.Point(681, 382);
            this.tb_Pass.Name = "tb_Pass";
            this.tb_Pass.PasswordChar = '*';
            this.tb_Pass.Size = new System.Drawing.Size(220, 29);
            this.tb_Pass.TabIndex = 21;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.ForeColor = System.Drawing.Color.Black;
            this.label_password.Location = new System.Drawing.Point(538, 385);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(99, 22);
            this.label_password.TabIndex = 20;
            this.label_password.Text = "Password:";
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(206, 521);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(329, 29);
            this.tb_Email.TabIndex = 19;
            // 
            // tb_Nome
            // 
            this.tb_Nome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.login_adasBindingSourceUpdate, "username", true));
            this.tb_Nome.Location = new System.Drawing.Point(206, 382);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(220, 29);
            this.tb_Nome.TabIndex = 18;
            // 
            // label_estatuto
            // 
            this.label_estatuto.AutoSize = true;
            this.label_estatuto.ForeColor = System.Drawing.Color.Black;
            this.label_estatuto.Location = new System.Drawing.Point(78, 453);
            this.label_estatuto.Name = "label_estatuto";
            this.label_estatuto.Size = new System.Drawing.Size(84, 22);
            this.label_estatuto.TabIndex = 17;
            this.label_estatuto.Text = "Estatuto:";
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.ForeColor = System.Drawing.Color.Black;
            this.label_email.Location = new System.Drawing.Point(100, 524);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(62, 22);
            this.label_email.TabIndex = 16;
            this.label_email.Text = "Email:";
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.ForeColor = System.Drawing.Color.Black;
            this.label_nome.Location = new System.Drawing.Point(100, 385);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(66, 22);
            this.label_nome.TabIndex = 15;
            this.label_nome.Text = "Nome:";
            // 
            // btn_Apaga
            // 
            this.btn_Apaga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btn_Apaga.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Apaga.Location = new System.Drawing.Point(737, 57);
            this.btn_Apaga.Name = "btn_Apaga";
            this.btn_Apaga.Size = new System.Drawing.Size(164, 34);
            this.btn_Apaga.TabIndex = 27;
            this.btn_Apaga.Text = "Apagar Texto";
            this.btn_Apaga.UseVisualStyleBackColor = false;
            this.btn_Apaga.Click += new System.EventHandler(this.btn_Apaga_Click);
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.login_adasTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Projeto_ADAS_2.login_adasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.btn_Apaga);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.cb_estatuto);
            this.Controls.Add(this.tb_ConfPass);
            this.Controls.Add(this.label_confpass);
            this.Controls.Add(this.tb_Pass);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.label_estatuto);
            this.Controls.Add(this.label_email);
            this.Controls.Add(this.label_nome);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.btn_Procurar);
            this.Controls.Add(this.btn_MostrarTudo);
            this.Controls.Add(this.tb_Pesquisa);
            this.Controls.Add(this.label_Pesquisa);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Consultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar_Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_adasBindingSourceUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_adasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label_Pesquisa;
        private System.Windows.Forms.TextBox tb_Pesquisa;
        private System.Windows.Forms.Button btn_MostrarTudo;
        private System.Windows.Forms.Button btn_Procurar;
        private login_adasDataSet login_adasDataSet;
        private System.Windows.Forms.BindingSource login_adasBindingSourceUpdate;
        private login_adasDataSetTableAdapters.login_adasTableAdapter login_adasTableAdapter;
        private login_adasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.ComboBox cb_estatuto;
        private System.Windows.Forms.TextBox tb_ConfPass;
        private System.Windows.Forms.Label label_confpass;
        private System.Windows.Forms.TextBox tb_Pass;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Label label_estatuto;
        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_nome;
        private System.Windows.Forms.Button btn_Apaga;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoridadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}