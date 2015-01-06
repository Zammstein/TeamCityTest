using Neo4jClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());              
        }
    }

    /// <summary>
    /// The User class for bank acounts
    /// </summary>
    public class User {

        public String name;
        public int age;
        public BankAccount bankAccount;


        public User(String name, int age, BankAccount bankAccount) {
            this.name = name;
            this.age = age;
            this.bankAccount = bankAccount;
        }

        public User(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void CreateUserNode(User user)
        {
            var client = new GraphClient(new Uri("http://localhost:7474/db/data"));
            client.Connect();
            var newUser = user;
            client.Cypher
            .Create("(user:User {newUser})")
            .WithParam("newUser", newUser)
            .ExecuteWithoutResults();
        }
    }

    /// <summary>
    /// BankAccount class to connect to a User
    /// </summary>
    public class BankAccount {
        
        public double balance;

        public BankAccount(double balance) {
            this.balance = balance;
        }

        public void Transefer(BankAccount toBank, double amount) {
            this.balance -= amount;
            toBank.balance += amount;
        }

        public void modifyBalance(double amount) {
            // add to account
            this.balance += amount;
        }
    }
}
