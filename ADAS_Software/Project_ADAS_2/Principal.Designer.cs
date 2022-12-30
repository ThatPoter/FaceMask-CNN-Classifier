namespace Projeto_ADAS_2
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.label3 = new System.Windows.Forms.Label();
            this.lb_Piso = new System.Windows.Forms.Label();
            this.picb_Alerta = new System.Windows.Forms.PictureBox();
            this.btn_IrVerificar = new System.Windows.Forms.Button();
            this.btn_Verificado = new System.Windows.Forms.Button();
            this.btn_Ignorar = new System.Windows.Forms.Button();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lb_Data = new System.Windows.Forms.Label();
            this.lb_Hora = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPerfil = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_NomeFunc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picb_Alerta)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelPerfil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Piso:";
            // 
            // lb_Piso
            // 
            this.lb_Piso.AutoSize = true;
            this.lb_Piso.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Piso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Piso.Location = new System.Drawing.Point(85, 196);
            this.lb_Piso.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lb_Piso.Name = "lb_Piso";
            this.lb_Piso.Size = new System.Drawing.Size(22, 22);
            this.lb_Piso.TabIndex = 3;
            this.lb_Piso.Text = "--";
            // 
            // picb_Alerta
            // 
            this.picb_Alerta.Location = new System.Drawing.Point(212, 22);
            this.picb_Alerta.Name = "picb_Alerta";
            this.picb_Alerta.Size = new System.Drawing.Size(960, 480);
            this.picb_Alerta.TabIndex = 4;
            this.picb_Alerta.TabStop = false;
            // 
            // btn_IrVerificar
            // 
            this.btn_IrVerificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btn_IrVerificar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_IrVerificar.Location = new System.Drawing.Point(261, 531);
            this.btn_IrVerificar.Name = "btn_IrVerificar";
            this.btn_IrVerificar.Size = new System.Drawing.Size(165, 46);
            this.btn_IrVerificar.TabIndex = 5;
            this.btn_IrVerificar.Text = "Ir Verificar";
            this.btn_IrVerificar.UseVisualStyleBackColor = false;
            this.btn_IrVerificar.Click += new System.EventHandler(this.btn_IrVerificar_Click);
            // 
            // btn_Verificado
            // 
            this.btn_Verificado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btn_Verificado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Verificado.Location = new System.Drawing.Point(606, 531);
            this.btn_Verificado.Name = "btn_Verificado";
            this.btn_Verificado.Size = new System.Drawing.Size(165, 46);
            this.btn_Verificado.TabIndex = 6;
            this.btn_Verificado.Text = "Verificado";
            this.btn_Verificado.UseVisualStyleBackColor = false;
            this.btn_Verificado.Click += new System.EventHandler(this.btn_Verificado_Click);
            // 
            // btn_Ignorar
            // 
            this.btn_Ignorar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btn_Ignorar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Ignorar.Location = new System.Drawing.Point(968, 531);
            this.btn_Ignorar.Name = "btn_Ignorar";
            this.btn_Ignorar.Size = new System.Drawing.Size(165, 46);
            this.btn_Ignorar.TabIndex = 7;
            this.btn_Ignorar.Text = "Ignorar";
            this.btn_Ignorar.UseVisualStyleBackColor = false;
            this.btn_Ignorar.Click += new System.EventHandler(this.btn_Ignorar_Click);
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
            this.btn_Sair.TabIndex = 8;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lb_Data
            // 
            this.lb_Data.AutoSize = true;
            this.lb_Data.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Data.Location = new System.Drawing.Point(12, 242);
            this.lb_Data.Name = "lb_Data";
            this.lb_Data.Size = new System.Drawing.Size(22, 22);
            this.lb_Data.TabIndex = 9;
            this.lb_Data.Text = "--";
            // 
            // lb_Hora
            // 
            this.lb_Hora.AutoSize = true;
            this.lb_Hora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Hora.Location = new System.Drawing.Point(54, 286);
            this.lb_Hora.Name = "lb_Hora";
            this.lb_Hora.Size = new System.Drawing.Size(22, 22);
            this.lb_Hora.TabIndex = 10;
            this.lb_Hora.Text = "--";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.panel1.Controls.Add(this.panelPerfil);
            this.panel1.Controls.Add(this.btn_Sair);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 611);
            this.panel1.TabIndex = 11;
            // 
            // panelPerfil
            // 
            this.panelPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panelPerfil.Controls.Add(this.pictureBox1);
            this.panelPerfil.Controls.Add(this.lb_Hora);
            this.panelPerfil.Controls.Add(this.lb_NomeFunc);
            this.panelPerfil.Controls.Add(this.lb_Data);
            this.panelPerfil.Controls.Add(this.label3);
            this.panelPerfil.Controls.Add(this.lb_Piso);
            this.panelPerfil.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPerfil.Location = new System.Drawing.Point(0, 0);
            this.panelPerfil.Name = "panelPerfil";
            this.panelPerfil.Size = new System.Drawing.Size(200, 330);
            this.panelPerfil.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lb_NomeFunc
            // 
            this.lb_NomeFunc.AutoSize = true;
            this.lb_NomeFunc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_NomeFunc.Location = new System.Drawing.Point(12, 149);
            this.lb_NomeFunc.Name = "lb_NomeFunc";
            this.lb_NomeFunc.Size = new System.Drawing.Size(73, 22);
            this.lb_NomeFunc.TabIndex = 1;
            this.lb_NomeFunc.Text = "(Nome)";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Ignorar);
            this.Controls.Add(this.btn_Verificado);
            this.Controls.Add(this.btn_IrVerificar);
            this.Controls.Add(this.picb_Alerta);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADAS | Coimbra Business School";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picb_Alerta)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelPerfil.ResumeLayout(false);
            this.panelPerfil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picb_Alerta;
        private System.Windows.Forms.Button btn_IrVerificar;
        private System.Windows.Forms.Button btn_Verificado;
        private System.Windows.Forms.Button btn_Ignorar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_Data;
        private System.Windows.Forms.Label lb_Hora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelPerfil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_NomeFunc;
        public System.Windows.Forms.Label lb_Piso;
    }
}