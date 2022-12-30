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
    public partial class Notificação : Form
    {
        public Notificação()
        {
            InitializeComponent();
        }
        
        public static void Alert(string message)
        {
            
        }

        private void Notificação_Load(object sender, EventArgs e)
        {
            this.Top = -1 * (this.Height);
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;
        }

        private void timeout_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        int intervalo = 0;
        private void mostrar_Tick(object sender, EventArgs e)
        {
            if(this.Top < 60)
            {
                this.Top += intervalo;
                intervalo += 2;
            }
            else
            {
                mostrar.Stop();
            }
        }

        private void close_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0)
            {
                this.Opacity -= 0.01;
            }
            else
            {
                this.Close();
            }
        }

        private void btn_iconAlerta_Click(object sender, EventArgs e)
        {
            close.Start();
        }
    }
}
