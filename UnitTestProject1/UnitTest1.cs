using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication7;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        public double balance = 10.22;
        public String name = "foo";
        public int age = 12;

        [TestMethod]
        public void TestMethod1()
        {
            BankAccount bankAccount = new BankAccount(balance);
            User user = new User(name, age, bankAccount);
            Assert.AreEqual(balance, bankAccount.balance);
            Assert.AreEqual(name, user.name);
            Assert.AreEqual(age, user.age);
        }
    }
}
