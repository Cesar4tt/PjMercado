using Microsoft.VisualBasic.Logging;
using System.Text.RegularExpressions;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestesDeLogin()
        {
            // Teste #01: Login e senha corretos
            string login = "Lucasalmeida@Emporioallblue";
            string senha = "1234";
            Assert.AreEqual("Supervisor", InteracoesBD.InstanciaPublica().LoginUsuario(login, senha));

            login = "Carloseduardo@Emporioallblue";
            senha = "4321";
            Assert.AreEqual("Caixa", InteracoesBD.InstanciaPublica().LoginUsuario(login, senha));

            // Teste #02: Login incorreto
            login = "teste@teste.com";
            Assert.AreEqual("nenhum", InteracoesBD.InstanciaPublica().LoginUsuario(login, senha));

            // Teste #03: Senha incorreta
            login = "Rafaeloliveira@Emporioallblue";
            senha = "4321";
            Assert.AreEqual("nenhum", InteracoesBD.InstanciaPublica().LoginUsuario(login, senha));

      
        }

        [TestMethod]
        public void TestesBuscaProduto()
        {
            string descricaoTeste;
            string marcaTeste;
            string codigoTeste;
            string valorTeste;


            string dataSource = "Server = localhost; Database = Mercado_Emporio_Blue; User ID = root; Password =;";
            string codigoProduto = "00001";

            InteracoesBD.InstanciaPublica().LerProduto(codigoProduto, dataSource, out descricaoTeste, out marcaTeste, out codigoTeste, out valorTeste);

            // Teste #01: 
            string descricaoProduto = "Arroz Tradicional Camil 1kg";
            string marcaProduto = "Camil";
            codigoProduto = "00001";
            double valor = 6.6;


            Assert.AreEqual(descricaoProduto, descricaoTeste);
            Assert.AreEqual(marcaTeste, marcaProduto);
            Assert.AreEqual(codigoProduto, codigoProduto);
            Assert.AreEqual(valor.ToString("C"), valorTeste);

            //Teste #02: Produto incorreto. 
            descricaoProduto = "Arroz Tradicional Camil 1kg";
            codigoProduto = "00002";

            Assert.AreNotEqual(descricaoProduto, codigoProduto);

        }

            [TestMethod]
              public void TestesAdicionarProduto()
              {
              
                string descricaoTeste;
                string marcaTeste;
                string codigoTeste;
                string valorTeste;


                string descricao = "Espoja Bob lou�a";
                string marca = "Nickeloadeon";
                string codigo = "00044";
                string valor ="4.0";
                int RowAffect = 1;


                string dataSource = "Server = localhost; Database = Mercado_Emporio_Blue; User ID = root; Password =;";




                Assert.IsTrue(InteracoesBD.InstanciaPublica().CadastroProduto(descricao, codigo, valor, marca, dataSource));
               



              }

    }
}
