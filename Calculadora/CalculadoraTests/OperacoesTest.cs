using Calculadora;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CalculadoraTests
{
    
    
    /// <summary>
    ///This is a test class for OperacoesTest and is intended
    ///to contain all OperacoesTest Unit Tests
    ///</summary>
    [TestClass()]
    public class OperacoesTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Dividir
        ///</summary>
        [TestMethod()]
        public void DividirTest()
        {
            double dividendo = 10;
            double divisor = 3;
            double expected = 3.3333333333333335; 
            double actual;
            actual = Operacoes.Dividir(dividendo, divisor);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Multiplicar
        ///</summary>
        [TestMethod()]
        public void MultiplicarTest()
        {
            long multiplicando = 4; 
            long multiplicador = 1; 
            long expected = 4; 
            long actual;
            actual = Operacoes.Multiplicar(multiplicando, multiplicador);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Somar
        ///</summary>
        [TestMethod()]
        public void SomarTest()
        {
            long numero1 = 1; 
            long numero2 = 4; 
            long expected = 5; 
            long actual;
            actual = Operacoes.Somar(numero1, numero2);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Subtrair
        ///</summary>
        [TestMethod()]
        public void SubtrairTest()
        {
            long minuendo = 25; 
            long subtraendo = 15; 
            long expected = 10; 
            long actual;
            actual = Operacoes.Subtrair(minuendo, subtraendo);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Subtrair2De49Test()
        {
            long minuendo = 49;
            long subtraendo = 2;
            long expected = 47;
            long actual;
            actual = Operacoes.Subtrair(minuendo, subtraendo);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Subtrair2De1Test()
        {
            long minuendo = 1;
            long subtraendo = 2;
            long expected = -1;
            long actual;
            actual = Operacoes.Subtrair(minuendo, subtraendo);
            Assert.AreEqual(expected, actual);
        }
    }
}
