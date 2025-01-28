using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMercado
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

            // Aplica os cantos arredondados
            AddCantosArredondados();
        }

        private void AddCantosArredondados()
        {
            CantosArredondadosForm(this, 50); // Aplica arredondamento ao formulário
            CantosArredondadosButton(btnEntrar, 40);
            CantosArredondadosPanel(panelEmail, 40);
            CantosArredondadosPanel(panelSenha, 40);
        }

        // Método para aplicar cantos arredondados a um Form
        private void CantosArredondadosForm(Form form, int radius)
        {
            GraphicsPath forma = new GraphicsPath();

            // Adicionando um retângulo com cantos arredondados
            forma.AddArc(0, 0, radius, radius, 180, 90);  // Canto superior esquerdo
            forma.AddArc(form.Width - radius, 0, radius, radius, 270, 90);  // Canto superior direito
            forma.AddArc(form.Width - radius, form.Height - radius, radius, radius, 0, 90);  // Canto inferior direito
            forma.AddArc(0, form.Height - radius, radius, radius, 90, 90);  // Canto inferior esquerdo
            forma.CloseFigure();  // Fecha o caminho (formato completo)

            // Aplicando a região (forma com cantos arredondados) ao formulário
            form.Region = new Region(forma);
        }

        // Método para aplicar cantos arredondados a um botão
        private void CantosArredondadosButton(Button button, int radius)
        {
            GraphicsPath forma = new GraphicsPath();

            forma.AddArc(0, 0, radius, radius, 180, 90);
            forma.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
            forma.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);
            forma.AddArc(0, button.Height - radius, radius, radius, 90, 90);
            forma.CloseFigure();

            // Aplicando a região (forma com cantos arredondados) ao botão
            button.Region = new Region(forma);
        }

        // Método para aplicar cantos arredondados a um panel
        private void CantosArredondadosPanel(Panel panel, int radius)
        {
            GraphicsPath forma = new GraphicsPath();

            forma.AddArc(0, 0, radius, radius, 180, 90);
            forma.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);
            forma.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);
            forma.AddArc(0, panel.Height - radius, radius, radius, 90, 90);
            forma.CloseFigure();

            // Aplicando a região (forma com cantos arredondados) ao panel
            panel.Region = new Region(forma);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string resultadoLogin = InteracoesBD.InstanciaPublica().LoginUsuario(txtEmail.Text, txtSenha.Text);

            if (resultadoLogin == "nenhum")
            {
                //Se login e senha estiver errado. Aparace mensagem de erro.
                MessageBox.Show("Login ou Senha Incorretos! Tente Novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEmail.Clear();
                txtSenha.Clear();
                txtEmail.Focus();
            }
            else if (resultadoLogin == "Caixa" || resultadoLogin == "Supervisor")
            {
                frmMercado Mercado = new frmMercado(); // se for "Supervisor" ele tem acesso a tudo do sistema.
                                                       //Se for "Caixa" ele vai ter restrição em algumas coisas
                Mercado.Show();
                this.Hide();
            }
        }
    }
}