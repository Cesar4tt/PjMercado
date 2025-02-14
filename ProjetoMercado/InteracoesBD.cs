using MySql.Data.MySqlClient;
using ProjetoMercado;
using System;

public class InteracoesBD
{
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

            MySqlConnection conexao = new MySqlConnection("Server = 127.0.0.1 ; database = Mercado_Emporio_Blue; User Id = root ; Password = ;");
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


    public bool ValidarCodigo(string CodigoBarras )

    {


            // Esse Código faz a conexão com o banco de Dados
            MySqlConnection conexao = new MySqlConnection("Server = 127.0.0.1 ; database = Mercado_Emporio_Blue; User Id = root ; Password = ;");
            MySqlCommand comando = new MySqlCommand();

            MySqlDataReader dr;

            // Esse Código faz a busca dos produtos e joga na list view a partir do codigo que o usuario digitar na text box
            string sql = "SELECT * FROM Produtos  WHERE Codigo = " + "'" + CodigoBarras + "'" + ";";
       
            comando = conexao.CreateCommand();

            conexao.Open();
            comando.CommandText = sql;

            dr = comando.ExecuteReader();

        string caixa = dr.GetString(3);

        if (dr.Read())
            {
                return true;
            }
        else
            {
                return false;
            } 

    }
}

