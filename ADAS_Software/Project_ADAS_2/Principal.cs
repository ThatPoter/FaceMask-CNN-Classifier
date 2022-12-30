using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;

namespace Projeto_ADAS_2
{
    public partial class Principal : Form
    {
        int verificar = 0;
        bool lerPhoto = true;
        string alerta = string.Empty;

        // metodo para tentar abrir o exe do python
        private void run_cmd(string cmd, string args)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = cmd;
            start.UseShellExecute = true;
            Process process = Process.Start(start);
        }

        public Principal()
        {
            InitializeComponent();
           
            // chamar o metodo para executar ****
            // run_cmd(@"C:\Users\util\VisualStudioProjects\Projeto_ADAS_2\Python_Model\maindetector\maindetector.exe", null);
           
            // quando inicializada a forms Principal é obrigatório colocar o piso antes de poder mexer na interface
            Piso ps = new Piso();
            ps.ShowDialog();
            // disposição incial dos botões e labels
            lb_Piso.Text = ps.cbx_Piso.Text;


            picb_Alerta.Hide();
            btn_IrVerificar.Hide();
            btn_Ignorar.Hide();
            btn_Verificado.Hide();

            
            try
            {
                // FileWatcher +
                var watcher = new FileSystemWatcher(@"C:\Users\util\VisualStudioProjects\Projeto_ADAS_2\Python_Model\maindetector");

                watcher.NotifyFilter = NotifyFilters.Attributes
                                     | NotifyFilters.CreationTime
                                     | NotifyFilters.DirectoryName
                                     | NotifyFilters.FileName
                                     | NotifyFilters.LastAccess
                                     | NotifyFilters.LastWrite
                                     | NotifyFilters.Security
                                     | NotifyFilters.Size;

                watcher.Filter = "*.txt";
                watcher.IncludeSubdirectories = true;
                watcher.EnableRaisingEvents = true;

                watcher.Changed += (s, e) =>
                {
                    if (e.Name == "outputswitch.txt")
                    {
                        var inStream = new FileStream(@"C:\Users\util\VisualStudioProjects\Projeto_ADAS_2\Python_Model\maindetector\outputswitch.txt", FileMode.Open,
                                FileAccess.Read, FileShare.ReadWrite);

                        StreamReader sr = new StreamReader(inStream);
                        alerta = sr.ReadLine();

                        // alerta é a variavel que vai ser dada pelo python atraves de um txt
                        if (alerta == "sem")
                        {
                            this.Invoke(new Action(() =>
                            {
                                // se não for um falso positivo a pessoa clica no botão "ir verificar" e muda a variavel verificar para 1
                                // desencadeia o processo de verificação e espera até que cliquem em "verificado" para guardar a ocorrências
                                if (lerPhoto)
                                {
                                    lerPhoto = false;

                                    picb_Alerta.Show();
                                    btn_IrVerificar.Show();
                                    btn_Ignorar.Show();

                                    MemoryStream ms = new MemoryStream();


                                    var inStream2 = new FileStream(@"C:\Users\util\VisualStudioProjects\Projeto_ADAS_2\Python_Model\maindetector\imageoutput\opencv_frame_0.png", FileMode.Open,
                                    FileAccess.Read, FileShare.ReadWrite);
                                    // C:\Users\util\VisualStudioProjects\Projeto_ADAS_2\Python_Model\maindetector\imageoutput\opencv_frame_0.png
                                    // E:\Projeto ADAS - Softwares\maindetector
                                    // D:\Projeto ADAS - Softwares\maindetector

                                    inStream2.CopyTo(ms);

                                    inStream.Dispose();
                                    if (ms.Length != 0)
                                        picb_Alerta.Image = Image.FromStream(ms);
                                }

                                //picb_Alerta.Load();
                                // (Ainda não foi feita a parte de guardar ocorrencias) ****
                                if (verificar == 1 && alerta == "sem")
                                {
                                    btn_Verificado.Show();
                                    btn_IrVerificar.Hide();
                                    btn_Ignorar.Hide();
                                    verificar = 0;
                                }
                            }));
                        }
                    }
                };
            }
            catch { }
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            // volta ao form Login
            this.Close();
            Login log = new Login();
            log.ShowDialog();
        }

        private void btn_IrVerificar_Click(object sender, EventArgs e)
        {
            // quando clicamos neste botão desencadeamos o processo de ir verificar (não era falso positivo)
            // aqui tambem guardavamos a data de inicio da ocorrencia (ainda não foi emplementado)
            btn_IrVerificar.Hide();
            btn_Ignorar.Hide();
            btn_Verificado.Show();
            // verificar passa a ser 1
            verificar = 1;
        }

        private void btn_Ignorar_Click(object sender, EventArgs e)
        {
            // caso seja falso positivo alerta passa ao estado inicial bem como a forms
            lerPhoto = true;
            alerta = string.Empty;
            btn_Ignorar.Hide();
            btn_IrVerificar.Hide();
            picb_Alerta.Hide();
            verificar = 0;
        }

        private void btn_Verificado_Click(object sender, EventArgs e)
        {
            // finaliza o "ciclo" e volta ao layout inicial da form
            btn_Ignorar.Hide();
            btn_IrVerificar.Hide();
            btn_Verificado.Hide();
            picb_Alerta.Hide();
            verificar = 0;
            lerPhoto = true;

            // para registar a hora final da ocorrencia (ainda não foi implementado) ****
            //DateTime horaFim;
            //horaFim = DateTime.Now;
            //lb_Data.Text = horaFim.ToString();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            // dá nos a data e horas exatas 
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // passar a data para a label
            lb_Data.Text = DateTime.Now.ToLongDateString();
            // passar a hora para a label
            lb_Hora.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
