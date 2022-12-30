namespace Projeto_ADAS_2
{
    partial class RegistarUtilizador
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
            this.login_adasDataSetRegistar = new Projeto_ADAS_2.login_adasDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.tb_Email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Pass = new System.Windows.Forms.TextBox();
            this.login_adasTableAdapterResgistar = new Projeto_ADAS_2.login_adasDataSetTableAdapters.login_adasTableAdapter();
            this.tb_ConfPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_estatuto = new System.Windows.Forms.ComboBox();
            this.login_adasBindingSourceRegistar = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Projeto_ADAS_2.login_adasDataSetTableAdapters.TableAdapterManager();
            this.btn_Registar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.login_adasDataSetRegistar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_adasBindingSourceRegistar)).BeginInit();
            this.SuspendLayout();
            // 
            // login_adasDataSetRegistar
            // 
            this.login_adasDataSetRegistar.DataSetName = "login_adasDataSet";
            this.login_adasDataSetRegistar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Estatuto:";
            // 
            // tb_Nome
            // 
            this.tb_Nome.Location = new System.Drawing.Point(406, 93);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(322, 29);
            this.tb_Nome.TabIndex = 3;
            // 
            // tb_Email
            // 
            this.tb_Email.Location = new System.Drawing.Point(406, 161);
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Size = new System.Drawing.Size(322, 29);
            this.tb_Email.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // tb_Pass
            // 
            this.tb_Pass.Location = new System.Drawing.Point(406, 302);
            this.tb_Pass.Name = "tb_Pass";
            this.tb_Pass.PasswordChar = '*';
            this.tb_Pass.Size = new System.Drawing.Size(322, 29);
            this.tb_Pass.TabIndex = 7;
            // 
            // login_adasTableAdapterResgistar
            // 
            this.login_adasTableAdapterResgistar.ClearBeforeFill = true;
            // 
            // tb_ConfPass
            // 
            this.tb_ConfPass.Location = new System.Drawing.Point(406, 373);
            this.tb_ConfPass.Name = "tb_ConfPass";
            this.tb_ConfPass.PasswordChar = '*';
            this.tb_ConfPass.Size = new System.Drawing.Size(322, 29);
            this.tb_ConfPass.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Confirmar Password:";
            // 
            // cb_estatuto
            // 
            this.cb_estatuto.FormattingEnabled = true;
            this.cb_estatuto.Items.AddRange(new object[] {
            "Administrador",
            "Funcionário"});
            this.cb_estatuto.Location = new System.Drawing.Point(406, 232);
            this.cb_estatuto.Name = "cb_estatuto";
            this.cb_estatuto.Size = new System.Drawing.Size(322, 29);
            this.cb_estatuto.TabIndex = 12;
            // 
            // login_adasBindingSourceRegistar
            // 
            this.login_adasBindingSourceRegistar.DataMember = "login_adas";
            this.login_adasBindingSourceRegistar.DataSource = this.login_adasDataSetRegistar;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.login_adasTableAdapter = this.login_adasTableAdapterResgistar;
            this.tableAdapterManager.UpdateOrder = Projeto_ADAS_2.login_adasDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btn_Registar
            // 
            this.btn_Registar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btn_Registar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Registar.Location = new System.Drawing.Point(236, 458);
            this.btn_Registar.Name = "btn_Registar";
            this.btn_Registar.Size = new System.Drawing.Size(174, 38);
            this.btn_Registar.TabIndex = 13;
            this.btn_Registar.Text = "Registar";
            this.btn_Registar.UseVisualStyleBackColor = false;
            this.btn_Registar.Click += new System.EventHandler(this.btn_Registar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Cancelar.Location = new System.Drawing.Point(554, 458);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(174, 38);
            this.btn_Cancelar.TabIndex = 14;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // RegistarUtilizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Registar);
            this.Controls.Add(this.cb_estatuto);
            this.Controls.Add(this.tb_ConfPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_Pass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_Email);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RegistarUtilizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistarUtilizador";
            this.Load += new System.EventHandler(this.RegistarUtilizador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.login_adasDataSetRegistar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.login_adasBindingSourceRegistar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private login_adasDataSet login_adasDataSetRegistar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.TextBox tb_Email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Pass;
        private login_adasDataSetTableAdapters.login_adasTableAdapter login_adasTableAdapterResgistar;
        private System.Windows.Forms.TextBox tb_ConfPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_estatuto;
        private System.Windows.Forms.BindingSource login_adasBindingSourceRegistar;
        private login_adasDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btn_Registar;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}