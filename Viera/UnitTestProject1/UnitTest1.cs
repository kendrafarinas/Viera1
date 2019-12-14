using System;
using Maria;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDebit()
        {

            //Organizar
            BankAccount bank = new BankAccount("Camila", 11.99);
            double valoresperado = 7.11;

            //Actuar
            bank.Debit(4.88);
            double valorobtenido = bank.Balance;

            //Afirmar
            Assert.AreEqual(valoresperado, valorobtenido);
        }
        [TestMethod]
        public void TestCredit()
        {

            //Organizar
            BankAccount bank = new BankAccount("Camila", 11.55);
            double valoresperado = 7.11;

            //Actuar
            bank.Credit(4.44);
            double valorobtenido = bank.Balance;

            //Afirmar
            Assert.AreEqual(valoresperado, valorobtenido);
        }
    }
}
