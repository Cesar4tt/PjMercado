using System.Numerics;

namespace testeCaixa
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TesteDoCaixa()
        {
            Vector3 Adicionar = new Vector3(2, 3, 4);
            Assert.IsTrue(InteracoesBD.InstanciaPublica().btnadicionar_click());
            Assert.AreEqual(UC_Caixa)
        }
    }
}