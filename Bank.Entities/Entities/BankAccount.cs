using System;

namespace Bank.Entities.Entities
{
    public class BankAccount : IBankAccount
    {
        private string customerName;
        private double balance;

        public BankAccount()
        {

        }
        public BankAccount(string customerName, double balance)
        {
            this.customerName = customerName;
            this.balance = balance;
        }

        public string CustomerName
        {
            get { return this.customerName; }
            //set { this.customerName = value; }
        }

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public void SetNameOfCustomer(string name)
        {
            this.customerName = name;
        }

        public double AddInterest(double interest)
        {
            return this.balance *= interest;
        }


        // Credito(double amount)
        // Se amount < 0 lançar exception
        // balance += amount
        public double Credit(double amount)
        {

            if(amount < 0)
            {
                Exception err = new Exception("Amount não pode ser zero");
            }

            return Balance += amount;

        }

        public double Debit(double amount)
        {
            if (amount > Balance)
            {
                Exception err = new Exception("Saque não pode ser maior que o saldo.");
            }

            if(amount < 0)
            {
                Exception err = new Exception("Valor do saque não pode ser menor ou igual a zero.");
            }

            return Balance -= amount;
            
        }


        // Debito(double amount)
        // se amount > balance lançar exception
        // Se amount < 0 lançar exception
        // balance -= amount * 0.025

    }
}

