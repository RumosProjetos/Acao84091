namespace Aula01.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidarSeMetodoSomaFuncionaCorretamente()
        {
            //arrange
            int valor = 1;
            int valor2 = 2;

            //act
            int somatorio = valor + valor2;

            //assert
            Assert.AreEqual(3, somatorio);
        }

        [TestMethod]
        public void ValidarSeMetodoSomaFuncionaDeFormaIncorreta()
        {
            //arrange
            int valor = 1;
            int valor2 = 2;

            //act
            int somatorio = valor + valor2;

            //assert
            Assert.AreEqual(30, somatorio);
        }
    }
}