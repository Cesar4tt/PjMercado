﻿using MySql.Data.MySqlClient;
using ProjetoMercado;
using System;
using System.Diagnostics;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay())}(),nq}}")]
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

            MySqlConnection conexao = new MySqlConnection("Server = localhost ; database = Mercado_Emporio_Blue; User Id = root ; Password = ;");
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
                variaveisGlobais.funcionario = dr.GetString(0); // Lê o cargo do funcionário e armazena na variável global.
                cargo = variaveisGlobais.funcionario;

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

    //Teste de Validação do Campo Nome

    public string AdicionarFuncionario(string txtNomeCompleto, string mskdCPF)
    {
    string funcionario = "nenhum"
    if (txtNomeCompleto == "" || mskdCPF == "")
        return funcionario;
    }

    
        return ToString();
        try
        {
            string sql;

            /* Codigo abaixo cria uma conexão com o banco de dados e prepara o comando SQL para verificar o cargo do funcionário 
             com base no login (txtEmail.Text) e senha (txtSenha.Text) fornecidos no formulário.*/

            MySqlConnection conexao = new MySqlConnection("Server = localhost ; database = Mercado_Emporio_Blue; User Id = root ; Password = ;");
            MySqlCommand comando = new MySqlCommand();

            MySqlDataReader dr;

    //Consulta SQL para buscar o cargo do funcionário baseado no login e senha fornecidos.
    SQL = "INSERT INTO Funcionarios (Nome, DataNascimento, RG, CPF, Sexo, Telefone, Login, Senha, idCargo) " +
                  "VALUES (@Nome, @DataNascimento, @RG, @CPF, @Sexo, @Telefone, @Login, @Senha, @idCargo)";//Com esse SQL insert to adicionamos qualquer informaçao no banco de dados, colocando sempre o nome  da tabela do banco de dados e as colunas delas

            comando = conexao.CreateCommand();

            conexao.Open(); //Abre conexao com banco
            comando.CommandText = sql;

            dr = comando.ExecuteReader();  // faz a consulta e armazena o resultado no DataReader.

            if (dr.Read())// Verifica se a consulta retornou algum resultado.
            {
                variaveisGlobais.funcionario = dr.GetString(0); // Lê o cargo do funcionário e armazena na variável global.
                funcionario = variaveisGlobais.funcionario;

                conexao.Close(); //fechar conexao com banco
                return funcionario;
            }
            else
            {
                conexao.Close(); //fechar conexao com banco
                return funcionario;
            }
        }
        catch (Exception ex)
        {
            //try catch para pegar os erros e exibe a mensagem.
            MessageBox.Show("Erro ao tentar fazer login: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return funcionario;
        }

    }
     