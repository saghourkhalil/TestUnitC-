using DevAppsBank;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// verifie si la valeur attendue (1200) et égal à la valeur calculé account.Balance
        /// </summary>
        [TestMethod]
        public void Credit_WithValidAmount()
        {
            var account = new BankAccount("Khalil", 1000);
            account.Credit(200);
            Assert.AreEqual(1200, account.Balance);

        }

        /// <summary>
        /// Test qui test une exeption 
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void Credit_WithInvalidAmount()
        {
            var account = new BankAccount("Khalil", 1000);
            account.Credit(-100);
        }

        /// <summary>
        /// verifie si la valeur attendue (1200) et égal à la valeur calculé account.Balance
        /// </summary>
        [TestMethod]
        public void Debit_WithValidAmount()
        {
            var account = new BankAccount("Khalil", 1000);
            account.Debit(200);
            Assert.AreEqual(800, account.Balance);

        }
    }
}
