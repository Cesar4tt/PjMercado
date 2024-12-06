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
            try
            {
                string sql;

                /* Codigo abaixo cria uma conexão com o banco de dados e prepara o comando SQL para verificar o cargo do funcionário 
                 com base no login (txtEmail.Text) e senha (txtSenha.Text) fornecidos no formulário.*/

                MySqlConnection conexao = new MySqlConnection("Server = 127.0.0.1 ; database = Mercado_Emporio_Blue; User Id = root ; Password = ;");
                MySqlCommand comando = new MySqlCommand();

                MySqlDataReader dr;

                //Consulta SQL para buscar o cargo do funcionário baseado no login e senha fornecidos.
                sql = "SELECT Cargo FROM Funcionarios  WHERE Login = " + "'" + txtEmail.Text + "' AND Senha = '" + txtSenha.Text + "'" + ";";

                comando = conexao.CreateCommand();

                conexao.Open(); //Abre conexao com banco
                comando.CommandText = sql;

                dr = comando.ExecuteReader();  // faz a consulta e armazena o resultado no DataReader.

                if (dr.Read())// Verifica se a consulta retornou algum resultado.
                {
                    variaveisGlobais.Cargo = dr.GetString(0); // Lê o cargo do funcionário e armazena na variável global.

                    if (variaveisGlobais.Cargo == "Caixa" || variaveisGlobais.Cargo == "Supervisor") //verifica qual Cargo está fazendo login
                    {

                        frmMercado Mercado = new frmMercado(); // se for "Supervisor" ele tem acesso a tudo do sistema.
                                                               //Se for "Caixa" ele vai ter restrição em algumas coisas
                        Mercado.Show();
                        this.Hide();
                    }
                }
                else
                {
                    //Se login e senha estiver errado. Aparace mensagem de erro.
                    MessageBox.Show("Login ou Senha Incorretos! Tente Novamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtEmail.Clear();
                    txtSenha.Clear();
                    txtEmail.Focus();
                }

                conexao.Close(); //fechar conexao com banco
            }
            catch (Exception ex)
            {
                //try catch para pegar os erros e exibe a mensagem.
                MessageBox.Show("Erro ao tentar fazer login: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
    }
}
    
