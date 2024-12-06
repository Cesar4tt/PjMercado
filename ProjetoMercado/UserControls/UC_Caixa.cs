using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Mysqlx;
using Mysqlx.Notice;

namespace ProjetoMercado.UserControls
{
    public partial class UC_Caixa : UserControl
    {
        double subtotal;
        public UC_Caixa()
        {
            InitializeComponent();

            // Configurações da ListView (a tabela onde mostra os usuários)
            Colunaslistview();

            // Aplicando os cantos arredondados
            AddCantosArredondados();

            // Aplicando os eventos de mouse para os botões
            AddMouseEventosButoes();
        }

        private void Colunaslistview()
        {

            checkNotaFiscal.Enabled = false;
            txtCodigo.Enabled = false;
            btnAdicionar.Enabled = false;
            txtCodigo.Enabled = false;
            txtQuantidade.Enabled = false;

        }

        // Método para aplicar cantos arredondados 
        private void AddCantosArredondados()
        {
            CantosArredondadosButton(btnAbrirCupom, 40);
            CantosArredondadosButton(btnAdicionar, 40);
            CantosArredondadosButton(btnPagar, 40);
            CantosArredondadosButton(btnFinalizarCompra, 40);
            CantosArredondadosButton(btnRemoverProd, 40);
            CantosArredondadosButton(btnSimRemover, 30);
            CantosArredondadosButton(btnNãoRemover, 30);
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

        // Metodo para Adicionar eventos de "sair e entrar" para os botões
        private void AddMouseEventosButoes()
        {
            btnAdicionar.MouseEnter += Btn_MouseEnter;
            btnAdicionar.MouseLeave += Btn_MouseLeave;

            btnPagar.MouseEnter += Btn_MouseEnter;
            btnPagar.MouseLeave += Btn_MouseLeave;

            btnAbrirCupom.MouseEnter += Btn_MouseEnter;
            btnAbrirCupom.MouseLeave += Btn_MouseLeave;

            btnFinalizarCompra.MouseEnter += Btn_MouseEnter;
            btnFinalizarCompra.MouseLeave += Btn_MouseLeave;

            btnRemoverProd.MouseEnter += Btn_MouseEnter;
            btnRemoverProd.MouseLeave += Btn_MouseLeave;

            btnSimRemover.MouseEnter += Btn_MouseEnter;
            btnSimRemover.MouseLeave += Btn_MouseLeave;

            btnNãoRemover.MouseEnter += Btn_MouseEnter;
            btnNãoRemover.MouseLeave += Btn_MouseLeave;
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
                else if (btn.BackColor == Color.Black)
                {
                    btn.BackColor = ColorTranslator.FromHtml("#252525");
                }
                else
                {
                    btn.BackColor = Color.Firebrick;
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
                else if (btn.BackColor == ColorTranslator.FromHtml("#252525"))
                {
                    btn.BackColor = Color.Black;
                }
                else
                {
                    btn.BackColor = Color.OrangeRed;
                }
            }
        }

        private void btnAbrirCupom_Click(object sender, EventArgs e)
        {
            // Mudar a cor e texto é dasabilita o "lblCaixaFechado" 
            lblCaixaFechado.ForeColor = Color.Black;
            lblCaixaFechado.Text = "CAIXA ABERTO";
            btnAbrirCupom.Enabled = false;

            checkNotaFiscal.Enabled = true;
            btnAdicionar.Enabled = true;
            txtCodigo.Enabled = true;
            txtQuantidade.Enabled = true;
            lblSubtotal.Visible = true;
            lsvProdutos.View = View.Details; // Mostra os detalhes
            lsvProdutos.AllowColumnReorder = true; // Permite arrastar as colunas
            lsvProdutos.FullRowSelect = true; // Seleciona a linha toda quando clica
            lsvProdutos.GridLines = true; // Mostra linhas de grade

            //lsvProdutos.Columns.Add("Id", 100, HorizontalAlignment.Left);
            lsvProdutos.Columns.Add("Marca", 200, HorizontalAlignment.Left);
            lsvProdutos.Columns.Add("Preco", 200, HorizontalAlignment.Left);
            lsvProdutos.Columns.Add("Codigo", 200, HorizontalAlignment.Left);
            lsvProdutos.Columns.Add("Descricao", 350, HorizontalAlignment.Left);
            lsvProdutos.Columns.Add("Quantidade", 200, HorizontalAlignment.Left);







        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            //Desabilita e habilitia
            cmbFormaPagamento.Enabled = true;
            txtPagamento.Enabled = true;

            mskdNotaFiscal.Enabled = false;
            txtCodigo.Enabled = false;
            txtQuantidade.Enabled = false;
            btnAdicionar.Enabled = false;
        }

        private void btnRemoverProd_Click(object sender, EventArgs e)
        {
            panelRemoverPd.Visible = true;
        }

        private void btnNãoRemover_Click(object sender, EventArgs e)
        {
            panelRemoverPd.Visible = false;
            txtSenha.Clear();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                string CodigoBarras;
                int quantindade = int.Parse(txtQuantidade.Text);
                double resultado;
                double somaItem;

                // Esse Código faz a conexão com o banco de Dados
                MySqlConnection conexao = new MySqlConnection("Server = 127.0.0.1 ; database = Mercado_Emporio_Blue; User Id = root ; Password = ;");
                MySqlCommand comando = new MySqlCommand();

                MySqlDataReader dr;

                // Esse Código faz a busca dos produtos e joga na list view a partir do codigo que o usuario digitar na text box
                CodigoBarras = "SELECT * FROM Produtos  WHERE Codigo = " + "'" + txtCodigo.Text + "'" + ";";

                comando = conexao.CreateCommand();

                conexao.Open();
                comando.CommandText = CodigoBarras;

                dr = comando.ExecuteReader();

                while (dr.Read())
                {
                    CodigoBarras = dr.GetString(3);

                }


                if (CodigoBarras.ToString() == "")
                {
                    MessageBox.Show("Nenhum Resultado Encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigo.Clear();
                }

                else
                {
                    ListViewItem item = new ListViewItem(dr.GetString(1));

                    item.SubItems.Add(dr.GetDouble(2).ToString("C"));
                    item.SubItems.Add(dr.GetString(3));
                    item.SubItems.Add(dr.GetString(4));
                    item.SubItems.Add(quantindade.ToString());
                    lsvProdutos.Items.Add(item);
                    lblValoUnitario.Text = dr.GetDouble(2).ToString("C");

                    resultado = dr.GetDouble(2) * quantindade;
                    subtotal = subtotal + resultado;
                    lblSubtotal.Text = subtotal.ToString("C");

                    lblNomeProduto.Text = dr.GetString(4);

                    somaItem = dr.GetDouble(2) * quantindade;
                    lblTotalItem.Text = somaItem.ToString("C");

                    txtCodigo.Clear();
                    txtQuantidade.Clear();
                    txtCodigo.Focus();
                }

                conexao.Close();
            }
            catch
            {
                MessageBox.Show("Código incorreto ou Informe a quantidade do Produto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
            }
        }

        private void btnSimRemover_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSenha.Text == "")
                {
                    MessageBox.Show("Você precisa digitar sua senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenha.Visible = true;
                    txtSenha.Focus();
                }

                // Esse código não deixa o Usuário digitar outra senha que não seja '1234'

                else if (txtSenha.Text != "1234")
                {
                    MessageBox.Show("Senha Inválida. Produto não excluído", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSenha.Clear();
                    txtSenha.Focus();
                }

                else
                {
                    // Esse Código irá pegar da listview o preço que nela está
                    // NumberStyles .AllowCurrencySymbol retira o R$ que está na listview 
                    // NumberStyles.Currency corrigi a string e só pega o número

                    double valorUnitario = double.Parse(lsvProdutos.SelectedItems[0].SubItems[1].Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency);

                    // Esse código pega a Quantidade que está na listview
                    double Quantidade = double.Parse(lsvProdutos.SelectedItems[0].SubItems[4].Text);

                    // Esse código irá subtrair o campo Subtotal Retirando o Valor Unitário e a Quantidade do Produto Selecionado Na listview
                    subtotal = subtotal - (Quantidade * valorUnitario);
                    lblSubtotal.Text = subtotal.ToString("C");

                    // Esse código irá fazer com que ao clicar no produto da listview seja Removido 
                    lsvProdutos.SelectedItems[0].Remove();

                    txtSenha.Clear();
                    panelRemoverPd.Visible = false;

                }

            }

            catch
            {
                MessageBox.Show("Por favor Selecione o Produto na Lista ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Não deixa o usuário digitar pontos , simbolos e letras no campo senha
            if (Char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Não deixa o usuário digitar pontos , simbolos e letras no campo Codigo
            if (Char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
                e.Handled = true;
        }

        private void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            
          
                double troco = 0;

                int SelecionarFormaPagamento = cmbFormaPagamento.SelectedIndex; //variavel criada para amarzenar o que for escolhido na comboBox.

                switch (SelecionarFormaPagamento) //Switch case criado para cada forma de pagamento disponivel.
                {
                    case 0:
                    double DinheiroRecebido;
                    
                    try
                    {
                        DinheiroRecebido = double.Parse(txtPagamento.Text);
                    }
                    catch
                    {
                        DinheiroRecebido = 0;                    
                    }


                        if (DinheiroRecebido < subtotal)
                        {
                            MessageBox.Show("Valor menor que o Total da Compra.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                       else if (DinheiroRecebido == 0)
                        {
                       MessageBox.Show("Informe o valor recebido em dinheiro.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            troco = DinheiroRecebido - subtotal;
                            lblTroco.Text = troco.ToString("C");
                            lblTotalRecebido.Text = DinheiroRecebido.ToString("C");
                        }

                        break;

                    case 1:
                        // txtPagamento.Text = "";
                        lblTotalRecebido.Text = subtotal.ToString("C");
                        MessageBox.Show("Compra no Credito Aprovada", "Aprovada", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        break;

                    case 2:

                        lblTotalRecebido.Text = subtotal.ToString("C");
                        MessageBox.Show("Compra no Débito Aprovada", "Aprovada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  

                    break;
                }
          
            int RowAffect = 0;
            string sql;


            MySqlConnection conexao = new MySqlConnection("Server = localhost; database = Mercado_Emporio_Blue; User ID = root; Password =;");


            MySqlCommand comando = new MySqlCommand();


            sql = "INSERT INTO Nota_Fiscal (CPF, Quantidade, Valor_Compra, Valor_Pago, Forma_Pagamento, Troco) VALUES ('" + mskdNotaFiscal.Text + "','" + txtQuantidade.Text + "','" + lblSubtotal.Text + "','" + lblTotalRecebido.Text + "','" + cmbFormaPagamento.Text + "','" + lblTroco.Text + "')";

            conexao.Open();
            comando.Connection = conexao;

            comando.CommandText = sql;

            RowAffect = comando.ExecuteNonQuery();

            conexao.Close();



            lsvProdutos.Clear();
            lblValoUnitario.Text = "R$ 0,00";
            lblTotalItem.Text = "R$ 0,00";
            lblTotalRecebido.Text = "R$ 0,00";
            lblSubtotal.Text = "R$ 0,00";
            lblNomeProduto.Text = "Nome do Produto";
            txtPagamento.Clear();
            cmbFormaPagamento.SelectedIndex = -1;
            checkNotaFiscal.Checked = false;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void checkNotaFiscal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkNotaFiscal.Checked == true)
            {
                mskdNotaFiscal.Enabled = true;

            }

            else
            {
                mskdNotaFiscal.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNomeProduto_Click(object sender, EventArgs e)
        {

        }
    }
}