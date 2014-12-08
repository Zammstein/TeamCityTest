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
            Assert.AreEqual(balance, bankAccount.balance, "expected bankaccount balance to be 10.22");
            Assert.AreEqual(name, user.name, "expected username to be foo");
            Assert.AreEqual(age, user.age, "expected age to be 12");

            Console.Write("TestCreateMethods completed succesfully");
        }

        [TestMethod]
        public void TestTransfer() {
            BankAccount bankOne = new BankAccount(balance);
            BankAccount bankTwo = new BankAccount(balance);
            User userOne = new User(name, age, bankOne);
            User userTwo = new User("bar", age, bankTwo);

            userOne.bankAccount.Transefer(userTwo.bankAccount, userOne.bankAccount.balance);

            Assert.AreEqual(userTwo.bankAccount.balance, 20.44, "The Transfer has failed!");

            Console.Write("Transfer Test has finished succesfully");
        }

        [TestMethod]
        public void TestNodeCreation() {
            User user = new User("TestDummy", 10);
            user.CreateUserNode(user);
        }
    }
}
