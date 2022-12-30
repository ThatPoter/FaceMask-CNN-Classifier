namespace Projeto_ADAS_2
{
    partial class Piso
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_Piso = new System.Windows.Forms.ComboBox();
            this.btn_Piso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira aqui o piso em que se encontra:";
            // 
            // cbx_Piso
            // 
            this.cbx_Piso.FormattingEnabled = true;
            this.cbx_Piso.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbx_Piso.Location = new System.Drawing.Point(59, 122);
            this.cbx_Piso.Name = "cbx_Piso";
            this.cbx_Piso.Size = new System.Drawing.Size(327, 30);
            this.cbx_Piso.TabIndex = 1;
            // 
            // btn_Piso
            // 
            this.btn_Piso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(11)))), ((int)(((byte)(21)))));
            this.btn_Piso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Piso.Location = new System.Drawing.Point(59, 191);
            this.btn_Piso.Name = "btn_Piso";
            this.btn_Piso.Size = new System.Drawing.Size(327, 45);
            this.btn_Piso.TabIndex = 2;
            this.btn_Piso.Text = "OK";
            this.btn_Piso.UseVisualStyleBackColor = false;
            this.btn_Piso.Click += new System.EventHandler(this.btn_Piso_Click);
            // 
            // Piso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(444, 281);
            this.Controls.Add(this.btn_Piso);
            this.Controls.Add(this.cbx_Piso);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Piso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Piso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Piso;
        public System.Windows.Forms.ComboBox cbx_Piso;
    }
}