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

namespace ProjetoMercado.UserControls
{
    public partial class UC_UserCadastro : UserControl
    {
        MySqlCommand comando = new MySqlCommand();
        string SQL;
        string dataSource = "Server = localhost; Database = Mercado_Emporio_Blue; User ID = root; Password = ; ";
        MySqlConnection conexao;

        public UC_UserCadastro()
        {
            InitializeComponent();

            // Configurações da ListView (a tabela onde mostra os usuários)
            Configlistiview();

            // Aplicando os cantos arredondados
            AddCantosArredondados();

            // Aplicando os eventos de mouse para os botões
            AddMouseEventosButoes();

            carregar_usuario();
        }

        private void Configlistiview()
        {
            listView1.View = View.Details; // Mostra os detalhes
            listView1.AllowColumnReorder = true; // Permite arrastar as colunas
            listView1.FullRowSelect = true; // Seleciona a linha toda quando clica
            listView1.GridLines = true; // Mostra linhas de grade

            // Adiciona colunas na ListView
            listView1.Columns.Add("Nome", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("DataNascimento", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("RG", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("CPF", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Sexo", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Telefone", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Login", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Senha", 150, HorizontalAlignment.Left);
        }

        private void carregar_usuario()
        {
            try
            {
                conexao = new MySqlConnection(dataSource);
                SQL = "SELECT * FROM Funcionarios ORDER BY nome DESC";

                conexao.Open();
                comando.Connection = conexao;
                comando.CommandText = SQL;

                MySqlDataReader reader = comando.ExecuteReader();
                listView1.Items.Clear();

                while (reader.Read()) // Enquanto tiver dados pra ler
                {
                    string[] row = // Cria um array(ou vetor) com os dados do usuário | row = linha
                    {
                        reader["Nome"].ToString(),
                        reader["DataNascimento"].ToString(),
                        reader["RG"].ToString(),
                        reader["CPF"].ToString(),
                        reader["Sexo"].ToString(),
                        reader["Telefone"].ToString(),
                        reader["Login"].ToString(),
                        reader["Senha"].ToString(),
                    };

                    var linhaListView = new ListViewItem(row); // Cria um item pra adicionar na ListView
                    listView1.Items.Add(linhaListView); // Adiciona o item na lista
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erro: {ex.Number} - {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }
        }


        // Método para aplicar cantos arredondados 
        private void AddCantosArredondados()
        {
            CantosArredondadosButton(btnAtualizar, 40);
            CantosArredondadosButton(btnAdicionar, 40);
            CantosArredondadosButton(btnProcurarFoto, 30);
            CantosArredondadosButton(btnRemoverFoto, 30);
            CantosArredondadosButton(btnRemoverUser, 40);

            CantosArredondadosText(txtNomeCompleto, 20);
            CantosArredondadosText(txtRG, 20);
            CantosArredondadosText(txtSenha, 20);
            CantosArredondadosText(txtLogin, 20);

            CantosArredondadosMskd(mskdCPF, 20);
            CantosArredondadosMskd(mskdCelular, 20);
            CantosArredondadosMskd(mskdDataNascimento, 20);

            CantosArredondadosComboBox(cmbSexo, 20);
            CantosArredondadosComboBox(cmbCargo, 20);

            CantosArredondadosPictureBox(pictureFotoUser, 20);
        }

        // Método para aplicar cantos arredondados a um botão
        private void CantosArredondadosButton(Button button, int radius)
        {
            // Criando a GraphicsPath para os cantos arredondados
            GraphicsPath forma = new GraphicsPath();

            // Adicionando um retângulo com cantos arredondados
            forma.AddArc(0, 0, radius, radius, 180, 90);  // Canto superior esquerdo
            forma.AddArc(button.Width - radius, 0, radius, radius, 270, 90);  // Canto superior direito
            forma.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);  // Canto inferior direito
            forma.AddArc(0, button.Height - radius, radius, radius, 90, 90);  // Canto inferior esquerdo
            forma.CloseFigure();  // Fecha o caminho (formato completo)

            // Aplicando a região (forma com cantos arredondados) ao botão
            button.Region = new Region(forma);
        }

        // Método para aplicar cantos arredondados a um text
        private void CantosArredondadosText(TextBox text, int radius)
        {
            GraphicsPath forma = new GraphicsPath();

            forma.AddArc(0, 0, radius, radius, 180, 90);
            forma.AddArc(text.Width - radius, 0, radius, radius, 270, 90);
            forma.AddArc(text.Width - radius, text.Height - radius, radius, radius, 0, 90);
            forma.AddArc(0, text.Height - radius, radius, radius, 90, 90);
            forma.CloseFigure();

            // Aplicando a região (forma com cantos arredondados) ao text
            text.Region = new Region(forma);
        }

        // Método para aplicar cantos arredondados a um maskedText
        private void CantosArredondadosMskd(MaskedTextBox maskedText, int radius)
        {
            GraphicsPath forma = new GraphicsPath();

            forma.AddArc(0, 0, radius, radius, 180, 90);
            forma.AddArc(maskedText.Width - radius, 0, radius, radius, 270, 90);
            forma.AddArc(maskedText.Width - radius, maskedText.Height - radius, radius, radius, 0, 90);
            forma.AddArc(0, maskedText.Height - radius, radius, radius, 90, 90);
            forma.CloseFigure();

            // Aplicando a região (forma com cantos arredondados) ao maskedText
            maskedText.Region = new Region(forma);
        }

        // Método para aplicar cantos arredondados a um comboBox
        private void CantosArredondadosComboBox(ComboBox comboBox, int radius)
        {
            GraphicsPath forma = new GraphicsPath();

            forma.AddArc(0, 0, radius, radius, 180, 90);
            forma.AddArc(comboBox.Width - radius, 0, radius, radius, 270, 90);
            forma.AddArc(comboBox.Width - radius, comboBox.Height - radius, radius, radius, 0, 90);
            forma.AddArc(0, comboBox.Height - radius, radius, radius, 90, 90);
            forma.CloseFigure();

            // Aplicando a região (forma com cantos arredondados) ao comboBox
            comboBox.Region = new Region(forma);
        }

        // Método para aplicar cantos arredondados a um pictureBox
        private void CantosArredondadosPictureBox(PictureBox pictureBox, int radius)
        {
            GraphicsPath forma = new GraphicsPath();


            forma.AddArc(0, 0, radius, radius, 180, 90);
            forma.AddArc(pictureBox.Width - radius, 0, radius, radius, 270, 90);
            forma.AddArc(pictureBox.Width - radius, pictureBox.Height - radius, radius, radius, 0, 90);
            forma.AddArc(0, pictureBox.Height - radius, radius, radius, 90, 90);
            forma.CloseFigure();

            // Aplicando a região (forma com cantos arredondados) ao pictureBox
            pictureBox.Region = new Region(forma);
        }

        // Metodo para Adicionar eventos de "sair e entrar" para os botões
        private void AddMouseEventosButoes()
        {
            btnAdicionar.MouseEnter += Btn_MouseEnter;
            btnAdicionar.MouseLeave += Btn_MouseLeave;

            btnAtualizar.MouseEnter += Btn_MouseEnter;
            btnAtualizar.MouseLeave += Btn_MouseLeave;

            btnProcurarFoto.MouseEnter += Btn_MouseEnter;
            btnProcurarFoto.MouseLeave += Btn_MouseLeave;

            btnRemoverFoto.MouseEnter += Btn_MouseEnter;
            btnRemoverFoto.MouseLeave += Btn_MouseLeave;

            btnBuscar.MouseEnter += Btn_MouseEnter;
            btnBuscar.MouseLeave += Btn_MouseLeave;

            btnRemoverUser.MouseEnter += Btn_MouseEnter;
            btnRemoverUser.MouseLeave += Btn_MouseLeave;
        }

        // Evento de mudar a cor quando o mouse ENTRAR no botão
        private void Btn_MouseEnter(object? sender, EventArgs e)
        {
            // Verifica se o 'sender' é realmente um botão
            if (sender is Button btn)
            {
                if (btn.BackColor == Color.SpringGreen)
                {
                    btn.BackColor = Color.SeaGreen;
                }
                else
                {
                    btn.BackColor = ColorTranslator.FromHtml("#252525");
                }
            }
        }

        // Evento de mudar a cor quando o mouse SAIR do botão
        private void Btn_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.BackColor == Color.SeaGreen)
                {
                    btn.BackColor = Color.SpringGreen;
                }
                else
                {
                    btn.BackColor = Color.Black;
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtNomeCompleto.Text == "" || mskdCPF.Text == "")
            {
                MessageBox.Show("Preencha os campos obrigatórios.");
                return;
            }


            MySqlConnection conexao = new MySqlConnection(dataSource);//Aqui é feita a conexão com o banco de dados com o numero do localhost e a nome da tabela de banco de dados

            MySqlCommand comando = new MySqlCommand();

            SQL = "INSERT INTO Funcionarios (Nome, DataNascimento, RG, CPF, Sexo, Telefone, Login, Senha, idCargo) " +
                  "VALUES (@Nome, @DataNascimento, @RG, @CPF, @Sexo, @Telefone, @Login, @Senha, @idCargo)";//Com esse SQL insert to adicionamos qualquer informaçao no banco de dados, colocando sempre o nome  da tabela do banco de dados e as colunas delas 

            comando.CommandText = SQL;
            comando.Parameters.AddWithValue("@Nome", txtNomeCompleto.Text);
            comando.Parameters.AddWithValue("@DataNascimento", mskdDataNascimento.Text);
            comando.Parameters.AddWithValue("@RG", txtRG.Text);
            comando.Parameters.AddWithValue("@CPF", mskdCPF.Text);
            comando.Parameters.AddWithValue("@Sexo", cmbSexo.Text);
            comando.Parameters.AddWithValue("@Telefone", mskdCelular.Text);
            comando.Parameters.AddWithValue("@Login", txtLogin.Text);
            comando.Parameters.AddWithValue("@Senha", txtSenha.Text);
            comando.Parameters.AddWithValue("@idCargo", cmbCargo.Text);

            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = SQL;

            int RowAffect = 0;
            RowAffect = comando.ExecuteNonQuery();
            if (RowAffect == 1)

            {
                MessageBox.Show("Cadastro realizado com sucesso!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeCompleto.Text = "";
                txtNomeCompleto.Focus();
                carregar_usuario();
            }
            else
            {
                MessageBox.Show("Cadastro não realizado!", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                conexao.Close();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //bntSELECT
            int RowAffect = 0;
            String NomeCompleto = "";
            String CodigoCliente = "";
            String SQL;
            string Codigo = "";

            if (txtBuscarUsuario.Text == "")
            {
                MessageBox.Show("Preencha os campos obrigatórios.");
                return;
            }

            MySqlConnection conexao = new MySqlConnection(dataSource);//Aqui é feita a conexão com o banco de dados com o numero do localhost e a nome da tabela de banco de dados
            MySqlDataReader dr;
            MySqlCommand comando = new MySqlCommand();


            SQL = "SELECT Nome,DataNascimento,RG,CPF,Sexo,Telefone,Login,Senha,idCargo FROM Funcionarios WHERE CPF  = " + "'" + txtBuscarUsuario.Text + "'" + ";"; //Aqui chamamos a string SQL da  conexao e colocamos os nome das colunas da tabela junto com o nome da tabela e colocamos um where no CPF para puxar por ele a pessoa pois CPF é UNICO
            comando.Parameters.AddWithValue("@CPF", txtBuscarUsuario.Text);
            //MessageBox.Show(SQL);
            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = SQL;
            dr = comando.ExecuteReader();

            while (dr.Read())
            {
                Codigo = dr.ToString();

            };

            if (Codigo.ToString() == "")
            {
                MessageBox.Show("Não existe esse registro no banco de dados!", "Aviso", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                txtBuscarUsuario.Clear();
                txtBuscarUsuario.Focus();
                carregar_usuario();
            }
            else
            {
                txtNomeCompleto.Text = dr["Nome"].ToString();
                mskdDataNascimento.Text = dr["DataNascimento"].ToString();
                txtRG.Text = dr["RG"].ToString();
                mskdCPF.Text = dr["CPF"].ToString();
                mskdCelular.Text = dr["Telefone"].ToString();
                txtLogin.Text = dr["Login"].ToString();
                txtSenha.Text = dr["Senha"].ToString();
                cmbSexo.Text = dr["Sexo"].ToString();
                cmbCargo.Text = dr["Cargo"].ToString();
            }
            conexao.Close();
        }

        private void btnRemoverUser_Click(object sender, EventArgs e)
        {
            int RowAffect = 0;
            String SQL;


            if (txtBuscarUsuario.Text == "")//txt que vai ser obrigatório ser preenchido
            {
                MessageBox.Show("Preencha os campos obrigatórios, BUSCAR USUARIO");
                return;
            }

            MySqlConnection conexao = new MySqlConnection(dataSource);//Aqui é feita a conexão com o banco de dados com o numero do localhost e a nome da tabela de banco de dados
            MySqlCommand comando = new MySqlCommand();

            SQL = "DELETE FROM Funcionarios WHERE CPF= " + "'" + txtBuscarUsuario.Text + "'";
            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = SQL;
            RowAffect = comando.ExecuteNonQuery();


            if (RowAffect == 1)
            {
                MessageBox.Show("Registro excluído com com sucesso!",
               "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNomeCompleto.Text = "";
                txtNomeCompleto.Focus();
                txtNomeCompleto.Clear();
                txtRG.Clear();
                mskdCPF.Clear();
                mskdCelular.Clear();
                mskdDataNascimento.Clear();
                txtLogin.Clear();
                txtSenha.Clear();
                txtBuscarUsuario.Clear();
                carregar_usuario();
            }
            else
            {
                MessageBox.Show("Exclusão não realizada!", "Aviso",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int RowAffect = 0;
            String SQL;

            if (txtBuscarUsuario.Text == "")//txt que vai ser obrigatório ser preenchido 
            {
                MessageBox.Show("Preencha os campos obrigatórios.");
                return;
            }

            MySqlConnection conexao = new MySqlConnection(dataSource);//Aqui é feita a conexão com o banco de dados com o numero do localhost e a nome da tabela de banco de dados
            MySqlCommand comando = new MySqlCommand();

            SQL = "UPDATE Funcionarios SET Nome = '" + txtNomeCompleto.Text + "', DataNascimento = '" + mskdDataNascimento.Text + "', RG = '" + txtRG.Text + "', CPF = '" + mskdCPF.Text + "', Sexo = '" + cmbSexo.Text + "', Telefone = '" + mskdCelular.Text + "' , Login = '" + txtLogin.Text + "', Senha = '" + txtSenha.Text + "', idCargo = '" + cmbCargo.Text + "'  WHERE CPF = '" + txtBuscarUsuario.Text + "';";
            //Com  essa conexão SQL colocamos o nome da tabela e colunas delas para poder fazer o update o setar os dados do banco de dados com o where CPF colocamos uma condição que no caso é o CPF para que assim só vai se feita a atualização do funcionario quando o CPF for igual ao dele
            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = SQL;
            RowAffect = comando.ExecuteNonQuery();
            //MessageBox.Show(SQL);

            if (RowAffect == 1)
            {
                MessageBox.Show("Cadastro atualizado com sucesso!", "Aviso",
               MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                mskdCPF.Clear();
                txtNomeCompleto.Clear();
                carregar_usuario();
            }
            else
            {
                MessageBox.Show("Cadastro não atualizado!", "Aviso",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            conexao.Close();
        }

        private void txtNomeCompleto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))//bloqueia a entrada de letras ao digitar 
                e.Handled = true;

            if (char.IsSymbol(e.KeyChar))//bloqueia a entrada de simbolos ao digitar 
                e.Handled = true;
        }

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))//bloqueia a entrada de letras ao digitar 
                e.Handled = true;

            if (char.IsSymbol(e.KeyChar))//bloqueia a entrada de simbolos ao digitar 
                e.Handled = true;
        }

        private void mskdDataNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))//bloqueia a entrada de letras ao digitar 
                e.Handled = true;

            if (char.IsSymbol(e.KeyChar))//bloqueia a entrada de simbolos ao digitar 
                e.Handled = true;
        }

        private void mskdCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))//bloqueia a entrada de letras ao digitar 
                e.Handled = true;

            if (char.IsSymbol(e.KeyChar))//bloqueia a entrada de simbolos ao digitar 
                e.Handled = true;
        }

        private void mskdCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))//bloqueia a entrada de letras ao digitar 
                e.Handled = true;

            if (char.IsSymbol(e.KeyChar))//bloqueia a entrada de simbolos ao digitar 
                e.Handled = true;
        }

        private void txtBuscarUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))//bloqueia a entrada de letras ao digitar 
                e.Handled = true;

            if (char.IsSymbol(e.KeyChar))//bloqueia a entrada de simbolos ao digitar 
                e.Handled = true;
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))//bloqueia entrada de letras ao digitar
                e.Handled = true;

            if (char.IsSymbol(e.KeyChar))//bloqueia a entrada de simbolos ao digitar
                e.Handled = true;

        }
    }
}