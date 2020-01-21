using Microsoft.VisualStudio.TestTools.UnitTesting;
using _6_GAMES;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test22yars()
        {
            string olds = "22";
            bool Yes = false;

            oldik ol = new oldik();
            bool yes = ol.TestOld(olds);

            Assert.AreEqual(Yes, yes);
        }

        [TestMethod]
        public void Test15yars()
        {
            string olds = "15";
            bool Yes = false;

            oldik ol = new oldik();
            bool yes = ol.TestOld(olds);

            Assert.AreEqual(Yes, yes);
        }

        [TestMethod]
        public void Test67yars()
        {
            string olds = "67";
            bool Yes = false;

            oldik ol = new oldik();
            bool yes = ol.TestOld(olds);

            Assert.AreEqual(Yes, yes);
        }

        [TestMethod]
        public void Test670yars() //к сожалению так долго не живут
        {
            string olds = "670";
            bool Yes = false;

            oldik ol = new oldik();
            bool yes = ol.TestOld(olds);

            Assert.AreNotEqual(Yes, yes); //отрицательный тест
        }

        [TestMethod]
        public void TestONEyars() //возраст нужно писать цифрами
        {
            string olds = "ONE";
            bool Yes = false;

            oldik ol = new oldik();
            bool yes = ol.TestOld(olds);

            Assert.AreNotEqual(Yes, yes); //отрицательный тест
        }

        [TestMethod]
        public void TestЛол_не_напишу_ничегоyars() //это вовсе не возраст
        {
            string olds = "Лол не напишу ничего";
            bool Yes = false;

            oldik ol = new oldik();
            bool yes = ol.TestOld(olds);

            Assert.AreNotEqual(Yes, yes); //отрицательный тест
        }

    }
}
