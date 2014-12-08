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
        public void TestCreateMethods()
        {
            BankAccount bankAccount = new BankAccount(balance);
            User user = new User(name, age, bankAccount);
            Assert.AreEqual(balance, bankAccount.balance, "19");
            Assert.AreEqual(name, user.name, "20");
            Assert.AreEqual(age, user.age, "21");
        }

        [TestMethod]
        public void TestTransfer() {
            BankAccount bankOne = new BankAccount(balance);
            BankAccount bankTwo = new BankAccount(balance);
            User userOne = new User(name, age, bankOne);
            User userTwo = new User("bar", age, bankTwo);

            userOne.bankAccount.Transefer(userTwo.bankAccount, userOne.bankAccount.balance);
        }
    }
}
