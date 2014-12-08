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
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class User {

        public String name;
        public int age;
        public BankAccount bankAccount;


        public User(String name, int age, BankAccount bankAccount) {
            this.name = name;
            this.age = age;
            this.bankAccount = bankAccount;
        }
    }

    public class BankAccount {
        
        public double balance;

        public BankAccount(double balance) {
            this.balance = balance;
        }
    }
}
