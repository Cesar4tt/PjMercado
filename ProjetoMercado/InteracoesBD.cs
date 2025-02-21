using MySql.Data.MySqlClient;
using ProjetoMercado;
using System;

public class InteracoesBD
{
    string dataSource = "Server = localhost; Database = Mercado_Emporio_Blue; User ID = root; Password =admin;";

    private static InteracoesBD instanciaInterna;
    public static InteracoesBD InstanciaPublica()
    {
        if (instanciaInterna == null)
            instanciaInterna = new InteracoesBD();

        return instanciaInterna;
    }

    public string LoginUsuario(string login, string senha)
    {
        string cargo = "nenhum";

        if (login == "" || senha == "")
            return cargo;

        try
        {
            string sql;

            /* Codigo abaixo cria uma conexão com o banco de dados e prepara o comando SQL para verificar o cargo do funcionário 
             com base no login (txtEmail.Text) e senha (txtSenha.Text) fornecidos no formulário.*/

            MySqlConnection conexao = new MySqlConnection("dataSource");
            MySqlCommand comando = new MySqlCommand();

            MySqlDataReader dr;

            //Consulta SQL para buscar o cargo do funcionário baseado no login e senha fornecidos.
            sql = "SELECT Cargo FROM Funcionarios  WHERE Login = " + "'" + login + "' AND Senha = '" + senha + "'" + ";";

            comando = conexao.CreateCommand();

            conexao.Open(); //Abre conexao com banco
            comando.CommandText = sql;

            dr = comando.ExecuteReader();  // faz a consulta e armazena o resultado no DataReader.

            if (dr.Read())// Verifica se a consulta retornou algum resultado.
            {
                variaveisGlobais.Cargo = dr.GetString(0); // Lê o cargo do funcionário e armazena na variável global.
                cargo = variaveisGlobais.Cargo;

                conexao.Close(); //fechar conexao com banco
                return cargo;
            }
            else
            {
                conexao.Close(); //fechar conexao com banco
                return cargo;
            }
        }
        catch (Exception ex)
        {
            //try catch para pegar os erros e exibe a mensagem.
            MessageBox.Show("Erro ao tentar fazer login: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return cargo;
        }
    }
    // Função para cadastrar produtos no BD, a partir da tela de cadastro (somente adm)
    public bool CadastroProduto(string descricao, string codBarras, string marca, string valor, string dataSource)
    {
        try
        {
            int RowAffect = 0;
            string sql;

            MySqlConnection conexao = new MySqlConnection(dataSource);
            MySqlCommand comando = new MySqlCommand();

            if (codBarras == "" || marca == "" || valor == "" || descricao == "")
                return false;

            sql = "INSERT INTO Produtos (Marca, Preco, Codigo, Descricao) VALUES ('" + marca + "', '" + valor + "', '" + codBarras + "', '" + descricao + "' )";
            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = sql;

            RowAffect = comando.ExecuteNonQuery();
            conexao.Close();

            if (RowAffect == 1)
                return true;
            else
                return false;

        }
        catch
        {
            MessageBox.Show("Erro na conexão com o Banco de Dados");
            return false;
        }
    }


    public bool LerProduto(string codBarras, string dataSource, out string descricaoProduto, out string marcaProduto, out string codigoProduto, out string valor)
    {
        descricaoProduto = "";
        marcaProduto = "";
        codigoProduto = "";
        valor = "";

        try
        {
            MySqlDataReader dr;

            MySqlCommand comando = new MySqlCommand();
            MySqlConnection conexao = new MySqlConnection(dataSource);

            string sql;

            sql = "SELECT * FROM Produtos WHERE Codigo = " + "'" + codBarras + "'" + ";";

            //MessageBox.Show(sql);
            //Carregar_Produto();
            conexao.Open();
            comando.Connection = conexao;
            comando.CommandText = sql;

            dr = comando.ExecuteReader();
            //MessageBox.Show(dataSource);

            while (dr.Read())
            {
                marcaProduto = dr.GetString(1);
                valor = dr.GetDouble(2).ToString("C");
                codigoProduto = dr.GetString(3);
                descricaoProduto = dr.GetString(4);

                //MessageBox.Show(marcaProduto + valor + codigoProduto + descricaoProduto);
            }

            conexao.Close();

            if (marcaProduto.ToString() == "" && valor.ToString() == "" && codigoProduto.ToString() == "" && descricaoProduto.ToString() == "")
                return false;
            else return true;
        }

        catch
        {
            MessageBox.Show("Erro ao buscar  os dados, certifique-se de preencher os campos corretamente");
            return false;
        }
    }

    public bool LerCodigo(string codigo, string dataSource, out string descricaoProduto, out string marcaProduto, out string codigoProduto, out string valor)
    {
        descricaoProduto = "";
        marcaProduto = "";
        codigoProduto = "";
        valor = "";




        // Esse Código faz a conexão com o banco de Dados
        MySqlConnection conexao = new MySqlConnection("Server = 127.0.0.1 ; database = Mercado_Emporio_Blue; User Id = root ; Password = ;");
        MySqlCommand comando = new MySqlCommand();

        MySqlDataReader dr;

        // Esse Código faz a busca dos produtos e joga na list view a partir do codigo que o usuario digitar na text box
        codigoProduto = "SELECT * FROM Produtos  WHERE Codigo = " + "'" + codigo + "'" + ";";

        comando = conexao.CreateCommand();


        conexao.Open();
        comando.CommandText = codigoProduto;

        dr = comando.ExecuteReader();
        // valor = dr.GetDouble(2).ToString("C");
        //double valor1;

        while (dr.Read())
        {
            marcaProduto = dr.GetString(1);
            valor = dr.GetDouble(2).ToString();
            codigoProduto = dr.GetString(3);
            descricaoProduto = dr.GetString(4);

        }

        if (codigo.ToString() == "")
        {
            return false;
        }
        else
        {
            return true;
        }

    }

    public bool CadastroFiscal(string NotaFiscal, string Quantidade, string Subtotal, string TotalRecebido, string FormaPagamento, string Troco)
    {

        int RowAffect = 0;
        string sql;


        MySqlConnection conexao = new MySqlConnection("Server = 127.0.0.1 ; database = Mercado_Emporio_Blue; User Id = root ; Password = ;");
        MySqlCommand comando = new MySqlCommand();



        sql = "INSERT INTO Nota_Fiscal (CPF, Quantidade, Valor_Compra, Valor_Pago, Forma_Pagamento, Troco) VALUES ('" + NotaFiscal + "','" + Quantidade + "','" + Subtotal + "','" + TotalRecebido + "','" + FormaPagamento + "','" + Troco + "')";

        conexao.Open();
        comando.Connection = conexao;

        comando.CommandText = sql;

        RowAffect = comando.ExecuteNonQuery();

        conexao.Close();

        if (RowAffect == 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public class GerenciadorUsuarios
    {
        private static GerenciadorUsuarios instanciaInterna;
        string dataSource = "Server = 127.0.0.1 ; database = Mercado_Emporio_Blue; User Id = root ; Password = ;";

        // Singleton para GerenciadorUsuarios
        public static GerenciadorUsuarios InstanciaPublica()
        {
            if (instanciaInterna == null)
                instanciaInterna = new GerenciadorUsuarios();
            return instanciaInterna;
        }

        public bool AdicionarUsuario(string nome, string cpf, string senha)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(dataSource))
                {
                    string sql = "INSERT INTO Funcionarios (Nome, CPF, Senha) VALUES (@Nome, @CPF, @Senha)";
                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@Nome", nome);
                        comando.Parameters.AddWithValue("@CPF", cpf);
                        comando.Parameters.AddWithValue("@Senha", senha);
                        conexao.Open();
                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao adicionar usuário: " + ex.Message);
                return false;
            }
        }

        public bool RemoverUsuario(string cpf)
        {
            try
            {
                using (MySqlConnection conexao = new MySqlConnection(dataSource))
                {
                    string sql = "DELETE FROM Funcionarios WHERE CPF = @CPF";
                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@CPF", cpf);
                        conexao.Open();
                        return comando.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao remover usuário: " + ex.Message);
                return false;
            }
        }

        
    }
}