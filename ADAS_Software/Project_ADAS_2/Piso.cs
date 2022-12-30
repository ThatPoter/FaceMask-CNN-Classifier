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
    public partial class Piso : Form
    {
        public Piso()
        {
            InitializeComponent();
        }

        private void btn_Piso_Click(object sender, EventArgs e)
        {
            if (cbx_Piso.Text == "1" || cbx_Piso.Text == "2" || cbx_Piso.Text == "3")
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Selecione um piso");
            }
        }
    }
}
