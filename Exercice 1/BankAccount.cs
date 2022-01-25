using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1
{
    internal class BankAccount
    {
        public string titulaire { get; set; }
        public double balance { get; set; }
        public  string devise { get; set; }

        public BankAccount(string titulaire, double balance, string devise)
        {
            titulaire = titulaire;
            balance = balance;  
            devise = devise;
        }

        /// <summary>
        /// Méthode de crédit du compte bancaire
        /// </summary>
        /// <param name="amount"></param>
        public void credit(double amount)
        {
            balance += amount;
        }
        /// <summary>
        /// Méthode de débit du compte bancaire
        /// </summary>
        /// <param name="amount"></param>
        public void debit(double amount)
        {
            balance -= amount;
        }

    }
}
