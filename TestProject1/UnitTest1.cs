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
    }
}