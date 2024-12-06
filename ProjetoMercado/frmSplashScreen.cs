using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMercado
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void timerCarregar_Tick(object sender, EventArgs e)
        {
            panelCarregar.Width += 2; // Adiciona 2 à largura do painel

            if (panelCarregar.Width > 500) // Verifica se a largura é maior que 500
            {
                timerCarregar.Stop();
                frmLogin login = new frmLogin();
                login.Show();
                this.Hide();// Esconde a janela "frmSplashScreen"
            }
        }
    }
}