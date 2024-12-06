using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using MySql.Data.MySqlClient;
using MySql;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoMercado.UserControls
{
    public partial class UC_ProdutoCadastro : UserControl
    {
        MySqlCommand comando = new MySqlCommand();
        string dataSource = "Server = localhost; Database = Mercado_Emporio_Blue; User ID = root; Password =;";
        MySqlConnection conexao;

        public UC_ProdutoCadastro()
        {
            InitializeComponent();
            configlistViewProd();
            Carregar_Produto();

            // Aplicando os cantos arredondados
            AddCantosArredondados();

            // Aplicando os eventos de mouse para os botões
            AddMouseEventosButoes();
        }

        // Método para aplicar cantos arredondados 
        private void AddCantosArredondados()
        {
            CantosArredondadosButton(btnAtualizar, 40);
            CantosArredondadosButton(btnAdicionar, 40);
            CantosArredondadosButton(btnProcurarFoto, 25);
            CantosArredondadosButton(btnRemoverFoto, 25);
            CantosArredondadosButton(btnRemoverProduto, 40);

            CantosArredondadosText(txtDescricao, 20);
            CantosArredondadosText(txtMarca, 20);
            CantosArredondadosText(txtCodigo, 20);
            CantosArredondadosText(txtValor, 20);

            CantosArredondadosPictureBox(pictureFoto, 20);
        }


        private void configlistViewProd()
        {
            // Configurações da ListView (a tabela onde mostra os usuários)
            listViewProd.View = View.Details; // Mostra os detalhes
            listViewProd.AllowColumnReorder = true; // Permite arrastar as colunas
            listViewProd.FullRowSelect = true; // Seleciona a linha toda quando clica
            listViewProd.GridLines = true; // Mostra linhas de grade

            // Adiciona colunas na ListView
            listViewProd.Columns.Add("Marca", 200, HorizontalAlignment.Left);
            listViewProd.Columns.Add("Preco", 200, HorizontalAlignment.Left);
            listViewProd.Columns.Add("Codigo", 200, HorizontalAlignment.Left);
            listViewProd.Columns.Add("Descricao", 500, HorizontalAlignment.Left);
        }
        private void Carregar_Produto()
        {
            try
            {
                conexao = new MySqlConnection(dataSource);
                string SQL = "SELECT * FROM Produtos ORDER BY Marca DESC";

                conexao.Open();
                comando.Connection = conexao;
                comando.CommandText = SQL;

                MySqlDataReader reader = comando.ExecuteReader();
                listViewProd.Items.Clear();

                while (reader.Read()) // Enquanto tiver dados pra ler
                {
                    string[] row = // Cria um array(ou vetor) com os dados do usuário | row = linha
                    {
                        reader["Marca"].ToString(),
                        reader["Preco"].ToString(),
                        reader["Codigo"].ToString(),
                        reader["Descricao"].ToString(),

                    };

                    var linhaListView = new ListViewItem(row); // Cria um item pra adicionar na ListView
                    listViewProd.Items.Add(linhaListView); // Adiciona o item na lista
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

            btnRemoverProduto.MouseEnter += Btn_MouseEnter;
            btnRemoverProduto.MouseLeave += Btn_MouseLeave;
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
        public void Limpar()
        {
            txtCodigo.Clear();
            txtDescricao.Clear();
            txtMarca.Clear();
            txtValor.Clear();
            txtBuscarProduto.Clear();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                int RowAffect = 0;
                string sql;

                MySqlConnection conexao = new MySqlConnection(dataSource);
                MySqlCommand comando = new MySqlCommand();


                if (txtCodigo.Text == "" || txtMarca.Text == "" || txtValor.Text == "" || txtDescricao.Text == "")
                {
                    MessageBox.Show("Preencha os campos obrigatórios.");
                    return;
                }

                sql = "INSERT INTO Produtos (Marca, Preco, Codigo, Descricao) VALUES ('" + txtMarca.Text + "', '" + txtValor.Text + "', '" + txtCodigo.Text + "', '" + txtDescricao.Text + "' )";
                conexao.Open();
                comando.Connection = conexao;
                comando.CommandText = sql;

                RowAffect = comando.ExecuteNonQuery();

                if (RowAffect == 1)
                {
                    MessageBox.Show("Cadastro realizado com sucesso!", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpar();
                    Carregar_Produto();
                }
                else
                {
                    MessageBox.Show("Cadastro não realizado!", "Aviso",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                conexao.Close();

            }
            catch
            {
                MessageBox.Show("Erro ao adicionar os dados: ");
            }

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {

            try
            {
                int RowAffect = 0;
                String sql;
                MySqlConnection conexao = new MySqlConnection(dataSource);
                MySqlCommand comando = new MySqlCommand();
                sql = "UPDATE Produtos SET Marca= '" + txtMarca.Text + "', Preco = '" + txtValor.Text + "',  codigo= '" + txtCodigo.Text + "',  descricao= '" + txtDescricao.Text + "'   WHERE Codigo = " + "'" + txtCodigo.Text + "'" + ";";

                conexao.Open();
                comando.Connection = conexao;
                comando.CommandText = sql;
                RowAffect = comando.ExecuteNonQuery();

                if (RowAffect == 1)
                {
                    MessageBox.Show("Cadastro atualizado com sucesso!", "Aviso", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    Carregar_Produto();
                }
                else
                {
                    MessageBox.Show("Cadastro não atualizado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                Limpar();
                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Erro ao Atualizar  os dados, certifique-se de preencher os campos corretamente");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                string descricaoProduto = "";
                string marcaProduto = "";
                string codigoProduto = "";
                string valor = "";

                MySqlDataReader dr;

                MySqlCommand comando = new MySqlCommand();
                MySqlConnection conexao = new MySqlConnection(dataSource);

                string sql;

                sql = "SELECT * FROM Produtos WHERE Codigo = " + "'" + txtBuscarProduto.Text + "'" + ";";
                MessageBox.Show(sql);
                Carregar_Produto();
                conexao.Open();
                comando.Connection = conexao;
                comando.CommandText = sql;

                dr = comando.ExecuteReader();

                while (dr.Read())
                {

                    codigoProduto = dr.GetString(3);

                }
                if (marcaProduto.ToString() == "" && valor.ToString() == "" && codigoProduto.ToString() == "" && descricaoProduto.ToString() == "")
                {
                    MessageBox.Show("não foi possivel encontrar o produto!", "Aviso",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtBuscarProduto.Focus();
                }
                else
                {
                    txtMarca.Text = dr.GetString(1);
                    txtCodigo.Text = dr.GetString(3);
                    txtDescricao.Text = dr.GetString(4);
                    txtValor.Text = dr.GetDouble(2).ToString("C");
                }
                conexao.Close();
            }

            catch
            {
                MessageBox.Show("Erro ao buscar  os dados, certifique-se de preencher os campos corretamente");
            }
        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            int RowAffect = 0;
            String SQL;


            if (txtBuscarProduto.Text == "")//txt que vai ser obrigatório ser preenchido
            {
                MessageBox.Show("Preencha os campos obrigatórios, BUSCAR USUARIO");
                return;
            }

            MySqlCommand comando = new MySqlCommand();
            MySqlConnection conexao = new MySqlConnection(dataSource);

            SQL = "DELETE FROM Produtos WHERE Codigo= " + "'" + txtBuscarProduto.Text + "'";
            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = SQL;
            RowAffect = comando.ExecuteNonQuery();


            if (RowAffect == 1)
            {

                MessageBox.Show("Registro excluído com com sucesso!",
               "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMarca.Text = "";
                txtMarca.Focus();
                txtMarca.Clear();
                txtCodigo.Clear();
                txtDescricao.Clear();
                txtValor.Clear();
                Carregar_Produto();
            }
            else
            {
                MessageBox.Show("Exclusão não realizada!", "Aviso",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}