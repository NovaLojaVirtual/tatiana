using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitLojaVirtual
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Take()
        {
            //O oeprador Take é usado para selecionar os primeiros 'n' objetos de uma coleção

            int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var resultado = from num in numeros.Take(5) select num;
            int[] teste = { 5, 4, 1, 3, 8 };
            CollectionAssert.AreEqual(resultado.ToArray(), teste);

        }

        [TestMethod]

        public void Skipe()
        {


            int[] numeros = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var resultado = from num in numeros.Take(5) select num;
            int[] teste = { 1, 3, 9 };
            CollectionAssert.AreEqual(resultado.ToArray(), teste);
        }
    }

}
