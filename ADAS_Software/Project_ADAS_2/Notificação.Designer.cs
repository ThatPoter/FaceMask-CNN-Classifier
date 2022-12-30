namespace Projeto_ADAS_2
{
    partial class Notificação
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
            this.lb_Alerta = new System.Windows.Forms.Label();
            this.btn_iconAlerta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timeout = new System.Windows.Forms.Timer(this.components);
            this.mostrar = new System.Windows.Forms.Timer(this.components);
            this.close = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Alerta
            // 
            this.lb_Alerta.AutoSize = true;
            this.lb_Alerta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Alerta.Location = new System.Drawing.Point(13, 28);
            this.lb_Alerta.Name = "lb_Alerta";
            this.lb_Alerta.Size = new System.Drawing.Size(227, 24);
            this.lb_Alerta.TabIndex = 0;
            this.lb_Alerta.Text = "Alerta de Ocorrência";
            // 
            // btn_iconAlerta
            // 
            this.btn_iconAlerta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_iconAlerta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_iconAlerta.FlatAppearance.BorderSize = 0;
            this.btn_iconAlerta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iconAlerta.ForeColor = System.Drawing.Color.White;
            this.btn_iconAlerta.Location = new System.Drawing.Point(0, 0);
            this.btn_iconAlerta.Name = "btn_iconAlerta";
            this.btn_iconAlerta.Size = new System.Drawing.Size(397, 93);
            this.btn_iconAlerta.TabIndex = 1;
            this.btn_iconAlerta.UseVisualStyleBackColor = true;
            this.btn_iconAlerta.Click += new System.EventHandler(this.btn_iconAlerta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Projeto_ADAS_2.Properties.Resources.noti_alerta_icon_peq;
            this.pictureBox1.Location = new System.Drawing.Point(306, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // timeout
            // 
            this.timeout.Interval = 5000;
            this.timeout.Tick += new System.EventHandler(this.timeout_Tick);
            // 
            // mostrar
            // 
            this.mostrar.Tick += new System.EventHandler(this.mostrar_Tick);
            // 
            // close
            // 
            this.close.Tick += new System.EventHandler(this.close_Tick);
            // 
            // Notificação
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(19)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(397, 93);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lb_Alerta);
            this.Controls.Add(this.btn_iconAlerta);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Notificação";
            this.Text = "Notificação";
            this.Load += new System.EventHandler(this.Notificação_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Alerta;
        private System.Windows.Forms.Button btn_iconAlerta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timeout;
        private System.Windows.Forms.Timer mostrar;
        private System.Windows.Forms.Timer close;
    }
}