namespace Projeto_ADAS_2
{
    partial class PrincipalAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrincipalAdmin));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panel_Relatorios = new System.Windows.Forms.Panel();
            this.btn_relatorios = new System.Windows.Forms.Button();
            this.btn_ConsultarOco = new System.Windows.Forms.Button();
            this.btn_Ocorrencias = new System.Windows.Forms.Button();
            this.panel_Funcionario = new System.Windows.Forms.Panel();
            this.btn_Registar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Funcionario = new System.Windows.Forms.Button();
            this.panelPerfil = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_NomeAdmin = new System.Windows.Forms.Label();
            this.panel_FormsChamar = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panel_Relatorios.SuspendLayout();
            this.panel_Funcionario.SuspendLayout();
            this.panelPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.panelSideMenu.Controls.Add(this.panel_Relatorios);
            this.panelSideMenu.Controls.Add(this.btn_Ocorrencias);
            this.panelSideMenu.Controls.Add(this.panel_Funcionario);
            this.panelSideMenu.Controls.Add(this.btn_Sair);
            this.panelSideMenu.Controls.Add(this.btn_Funcionario);
            this.panelSideMenu.Controls.Add(this.panelPerfil);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 611);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panel_Relatorios
            // 
            this.panel_Relatorios.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Relatorios.Controls.Add(this.btn_relatorios);
            this.panel_Relatorios.Controls.Add(this.btn_ConsultarOco);
            this.panel_Relatorios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Relatorios.Location = new System.Drawing.Point(0, 417);
            this.panel_Relatorios.Name = "panel_Relatorios";
            this.panel_Relatorios.Size = new System.Drawing.Size(200, 81);
            this.panel_Relatorios.TabIndex = 2;
            this.panel_Relatorios.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Relatorios_Paint);
            // 
            // btn_relatorios
            // 
            this.btn_relatorios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.btn_relatorios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_relatorios.FlatAppearance.BorderSize = 0;
            this.btn_relatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_relatorios.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_relatorios.Location = new System.Drawing.Point(0, 40);
            this.btn_relatorios.Name = "btn_relatorios";
            this.btn_relatorios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_relatorios.Size = new System.Drawing.Size(200, 41);
            this.btn_relatorios.TabIndex = 0;
            this.btn_relatorios.Text = "Relatórios";
            this.btn_relatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_relatorios.UseVisualStyleBackColor = false;
            // 
            // btn_ConsultarOco
            // 
            this.btn_ConsultarOco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.btn_ConsultarOco.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ConsultarOco.FlatAppearance.BorderSize = 0;
            this.btn_ConsultarOco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConsultarOco.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ConsultarOco.Location = new System.Drawing.Point(0, 0);
            this.btn_ConsultarOco.Name = "btn_ConsultarOco";
            this.btn_ConsultarOco.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_ConsultarOco.Size = new System.Drawing.Size(200, 40);
            this.btn_ConsultarOco.TabIndex = 0;
            this.btn_ConsultarOco.Text = "Consultar";
            this.btn_ConsultarOco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ConsultarOco.UseVisualStyleBackColor = false;
            // 
            // btn_Ocorrencias
            // 
            this.btn_Ocorrencias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btn_Ocorrencias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Ocorrencias.FlatAppearance.BorderSize = 0;
            this.btn_Ocorrencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ocorrencias.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Ocorrencias.Location = new System.Drawing.Point(0, 367);
            this.btn_Ocorrencias.Name = "btn_Ocorrencias";
            this.btn_Ocorrencias.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Ocorrencias.Size = new System.Drawing.Size(200, 50);
            this.btn_Ocorrencias.TabIndex = 5;
            this.btn_Ocorrencias.Text = "Ocorrências";
            this.btn_Ocorrencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Ocorrencias.UseVisualStyleBackColor = false;
            this.btn_Ocorrencias.Click += new System.EventHandler(this.btn_Ocorrencias_Click);
            // 
            // panel_Funcionario
            // 
            this.panel_Funcionario.BackColor = System.Drawing.Color.Crimson;
            this.panel_Funcionario.Controls.Add(this.btn_Registar);
            this.panel_Funcionario.Controls.Add(this.btn_Eliminar);
            this.panel_Funcionario.Controls.Add(this.btn_Consultar);
            this.panel_Funcionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Funcionario.Location = new System.Drawing.Point(0, 247);
            this.panel_Funcionario.Name = "panel_Funcionario";
            this.panel_Funcionario.Size = new System.Drawing.Size(200, 120);
            this.panel_Funcionario.TabIndex = 4;
            // 
            // btn_Registar
            // 
            this.btn_Registar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.btn_Registar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Registar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Registar.FlatAppearance.BorderSize = 0;
            this.btn_Registar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Registar.Location = new System.Drawing.Point(0, 80);
            this.btn_Registar.Name = "btn_Registar";
            this.btn_Registar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Registar.Size = new System.Drawing.Size(200, 40);
            this.btn_Registar.TabIndex = 1;
            this.btn_Registar.Text = "Registar";
            this.btn_Registar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Registar.UseVisualStyleBackColor = false;
            this.btn_Registar.Click += new System.EventHandler(this.btn_Registar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Eliminar.Location = new System.Drawing.Point(0, 40);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Eliminar.Size = new System.Drawing.Size(200, 40);
            this.btn_Eliminar.TabIndex = 2;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.btn_Consultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Consultar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Consultar.FlatAppearance.BorderSize = 0;
            this.btn_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Consultar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Consultar.Location = new System.Drawing.Point(0, 0);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_Consultar.Size = new System.Drawing.Size(200, 40);
            this.btn_Consultar.TabIndex = 3;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Consultar.UseVisualStyleBackColor = false;
            this.btn_Consultar.Click += new System.EventHandler(this.btn_Consultar_Click);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btn_Sair.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Sair.FlatAppearance.BorderSize = 0;
            this.btn_Sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Sair.Location = new System.Drawing.Point(0, 561);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Sair.Size = new System.Drawing.Size(200, 50);
            this.btn_Sair.TabIndex = 3;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Funcionario
            // 
            this.btn_Funcionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btn_Funcionario.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_Funcionario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Funcionario.FlatAppearance.BorderSize = 0;
            this.btn_Funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Funcionario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Funcionario.Location = new System.Drawing.Point(0, 197);
            this.btn_Funcionario.Name = "btn_Funcionario";
            this.btn_Funcionario.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Funcionario.Size = new System.Drawing.Size(200, 50);
            this.btn_Funcionario.TabIndex = 0;
            this.btn_Funcionario.Text = "Funcionários";
            this.btn_Funcionario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Funcionario.UseVisualStyleBackColor = false;
            this.btn_Funcionario.Click += new System.EventHandler(this.btn_Funcionario_Click);
            // 
            // panelPerfil
            // 
            this.panelPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelPerfil.Controls.Add(this.pictureBox1);
            this.panelPerfil.Controls.Add(this.lb_NomeAdmin);
            this.panelPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPerfil.Location = new System.Drawing.Point(0, 0);
            this.panelPerfil.Name = "panelPerfil";
            this.panelPerfil.Size = new System.Drawing.Size(200, 197);
            this.panelPerfil.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_NomeAdmin
            // 
            this.lb_NomeAdmin.AutoSize = true;
            this.lb_NomeAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_NomeAdmin.Location = new System.Drawing.Point(12, 154);
            this.lb_NomeAdmin.Name = "lb_NomeAdmin";
            this.lb_NomeAdmin.Size = new System.Drawing.Size(73, 22);
            this.lb_NomeAdmin.TabIndex = 1;
            this.lb_NomeAdmin.Text = "(Nome)";
            // 
            // panel_FormsChamar
            // 
            this.panel_FormsChamar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_FormsChamar.Location = new System.Drawing.Point(200, 0);
            this.panel_FormsChamar.Name = "panel_FormsChamar";
            this.panel_FormsChamar.Size = new System.Drawing.Size(984, 611);
            this.panel_FormsChamar.TabIndex = 1;
            // 
            // PrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.panel_FormsChamar);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "PrincipalAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADAS | Coimbra Business School";
            this.panelSideMenu.ResumeLayout(false);
            this.panel_Relatorios.ResumeLayout(false);
            this.panel_Funcionario.ResumeLayout(false);
            this.panelPerfil.ResumeLayout(false);
            this.panelPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelPerfil;
        private System.Windows.Forms.Label lb_NomeAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Registar;
        private System.Windows.Forms.Button btn_Funcionario;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Panel panel_FormsChamar;
        private System.Windows.Forms.Panel panel_Relatorios;
        private System.Windows.Forms.Panel panel_Funcionario;
        private System.Windows.Forms.Button btn_ConsultarOco;
        private System.Windows.Forms.Button btn_relatorios;
        private System.Windows.Forms.Button btn_Ocorrencias;
    }
}