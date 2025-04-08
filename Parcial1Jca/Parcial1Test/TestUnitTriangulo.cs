using Parcial1Lib;

namespace Parcial1Test
{
    [TestClass]
    public sealed class TestUnitTriangulo
    {
        [TestMethod]
        public void TestArea()
        {
            double base_ = 5, altura = 10;

            Triangulo triangulo = new Triangulo(base_, altura);

            double resultado = triangulo.area();
            Assert.AreEqual(25, resultado);
        }

        [TestMethod]
        public void TestPerimetro()
        {
            double base_ = 5;
            double altura = 10;

            Triangulo triangulo = new Triangulo(base_, altura);

            double resultado = triangulo.perimetro();

            double resultadoEsperado = 15;

            Assert.AreEqual(resultadoEsperado, resultado);
        }
    }
}
