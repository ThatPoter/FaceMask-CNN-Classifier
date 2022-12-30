namespace Projeto_ADAS_2
{
    partial class Eliminar
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
            this.dataGridViewEliminar = new System.Windows.Forms.DataGridView();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autoridadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.login_adasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.login_adasDataSet = new Projeto_ADAS_2.login_adasDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Pesquisa = new System.Windows.Forms.TextBox();
            this.btn_MostrarTudo = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Procurar = new System.Windows.Forms.Button();
            this.login_adasTableAdapter = new Projeto_ADAS_2.login_adasDataSetTableAdapters.login_adasTableAdapter();
            this.tableAdapterManager = new Projeto_ADAS_2.login_adasDataSetTableAdapters.TableAdapterManager();
            this.btn_Apaga = new System.Windows.Forms.Button();
            this.login_adasDataSet1 = new Projeto_ADAS_2.login_adasDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_adasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_adasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_adasDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewEliminar
            // 
            this.dataGridViewEliminar.AllowUserToOrderColumns = true;
            this.dataGridViewEliminar.AutoGenerateColumns = false;
            this.dataGridViewEliminar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEliminar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.autoridadeDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dataGridViewEliminar.DataSource = this.login_adasBindingSource;
            this.dataGridViewEliminar.Location = new System.Drawing.Point(83, 187);
            this.dataGridViewEliminar.Margin = new System.Windows.Forms.Padding(5);
            this.dataGridViewEliminar.Name = "dataGridViewEliminar";
            this.dataGridViewEliminar.RowHeadersWidth = 51;
            this.dataGridViewEliminar.RowTemplate.Height = 24;
            this.dataGridViewEliminar.Size = new System.Drawing.Size(820, 400);
            this.dataGridViewEliminar.TabIndex = 0;
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
            // login_adasBindingSource
            // 
            this.login_adasBindingSource.DataMember = "login_adas";
            this.login_adasBindingSource.DataSource = this.login_adasDataSet;
            // 
            // login_adasDataSet
            // 
            this.login_adasDataSet.DataSetName = "login_adasDataSet";
            this.login_adasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // tb_Pesquisa
            // 
            this.tb_Pesquisa.Location = new System.Drawing.Point(151, 62);
            this.tb_Pesquisa.Name = "tb_Pesquisa";
            this.tb_Pesquisa.Size = new System.Drawing.Size(572, 29);
            this.tb_Pesquisa.TabIndex = 2;
            // 
            // btn_MostrarTudo
            // 
            this.btn_MostrarTudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btn_MostrarTudo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_MostrarTudo.Location = new System.Drawing.Point(739, 122);
            this.btn_MostrarTudo.Name = "btn_MostrarTudo";
            this.btn_MostrarTudo.Size = new System.Drawing.Size(164, 34);
            this.btn_MostrarTudo.TabIndex = 3;
            this.btn_MostrarTudo.Text = "Mostrar Tudo";
            this.btn_MostrarTudo.UseVisualStyleBackColor = false;
            this.btn_MostrarTudo.Click += new System.EventHandler(this.btn_MostrarTudo_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btn_Eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Eliminar.Location = new System.Drawing.Point(377, 122);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(236, 34);
            this.btn_Eliminar.TabIndex = 4;
            this.btn_Eliminar.Text = "Eliminar Selecionado";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Procurar
            // 
            this.btn_Procurar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btn_Procurar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Procurar.Location = new System.Drawing.Point(83, 122);
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.login_adasTableAdapter = this.login_adasTableAdapter;
            this.tableAdapterManager.UpdateOrder = Projeto_ADAS_2.login_adasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btn_Apaga
            // 
            this.btn_Apaga.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btn_Apaga.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Apaga.Location = new System.Drawing.Point(739, 58);
            this.btn_Apaga.Name = "btn_Apaga";
            this.btn_Apaga.Size = new System.Drawing.Size(164, 34);
            this.btn_Apaga.TabIndex = 28;
            this.btn_Apaga.Text = "Apagar Texto";
            this.btn_Apaga.UseVisualStyleBackColor = false;
            // 
            // login_adasDataSet1
            // 
            this.login_adasDataSet1.DataSetName = "login_adasDataSet";
            this.login_adasDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.btn_Apaga);
            this.Controls.Add(this.btn_Procurar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_MostrarTudo);
            this.Controls.Add(this.tb_Pesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewEliminar);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Eliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar_Consultar";
            this.Load += new System.EventHandler(this.Eliminar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_adasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_adasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_adasDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Pesquisa;
        private System.Windows.Forms.Button btn_MostrarTudo;
        private System.Windows.Forms.Button btn_Procurar;
        private System.Windows.Forms.Button btn_Eliminar;
        private login_adasDataSet login_adasDataSet;
        private System.Windows.Forms.BindingSource login_adasBindingSource;
        private login_adasDataSetTableAdapters.login_adasTableAdapter login_adasTableAdapter;
        private login_adasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autoridadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btn_Apaga;
        private login_adasDataSet login_adasDataSet1;
    }
}