using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ordenamiento.pruebas
{
    [TestClass]
    public class PruebasOrdenamiento
    {
        private int[] salidaEsperada = new int[]{1,2,3,4,5};
        private int[] salidaEsperada2NoHayProblema = new int[]{1,1,1,1,1};
        private int[] salidaEsperada3SiHayProblema = new int[]{1,2,3,4,4};

        private Ordenamiento.Burbuja ordenar = new Ordenamiento.Burbuja();


        [TestMethod]
        public void Ordenados()
        {
            int[] entrada = new int[]{5,4,3,2,1};
            ordenar.Ordenar(entrada);
            CollectionAssert.AreEqual(salidaEsperada, entrada);
        }
    }
}
