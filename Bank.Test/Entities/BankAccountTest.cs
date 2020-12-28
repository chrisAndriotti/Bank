using Bank.Entities.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Test.Entities
{
    [TestClass]
    public class BankAccountTest
    {
        private Mock<IBankAccount> _mock;

        [TestMethod]
        public void BankAccount_AddInterest_BalancePlusInterest_Test_Success()
        {
             _mock = new Mock<IBankAccount>();

            BankAccount accountMock = new BankAccount();
            accountMock.SetNameOfCustomer("Chris");
            accountMock.Balance = 200;

            double interest = 20;

            _mock.Setup(x => x.AddInterest(It.IsAny<double>()));

            double balanceRes = 4000;

            double balanceUpdated = accountMock.AddInterest(interest);

            Assert.AreEqual(balanceRes, balanceUpdated);
        }

        [TestMethod]
        public void BankAccount_AddInterest_BalancePlusInterest_Test_Fail()
        {
            _mock = new Mock<IBankAccount>();

            BankAccount accountMock = new BankAccount();
            accountMock.SetNameOfCustomer("Chris");
            accountMock.Balance = 200;

            double interest = 20;

            _mock.Setup(x => x.AddInterest(It.IsAny<double>()));

            double balanceRes = 4001;

            double balanceUpdated = accountMock.AddInterest(interest);

            Assert.AreNotEqual(balanceRes, balanceUpdated);
        }


        [TestMethod]
        public void BankAccount_Credit_Test_Success()
        {
            _mock = new Mock<IBankAccount>();

            BankAccount accountMock = new BankAccount();
            accountMock.SetNameOfCustomer("Chris");
            accountMock.Balance = 200;

            double amount = 200;

            _mock.Setup(x => x.Credit(It.IsAny<double>()));

            double balanceRes = 400;

            double balanceUpdated = accountMock.Credit(amount);

            Assert.AreEqual(balanceRes, balanceUpdated);
        }

        [TestMethod]
        public void BankAccount_Credit_Test_Fail()
        {
            _mock = new Mock<IBankAccount>();

            BankAccount accountMock = new BankAccount();
            accountMock.SetNameOfCustomer("Chris");
            accountMock.Balance = 200;

            double amount = 200;

            _mock.Setup(x => x.Credit(It.IsAny<double>()));

            double balanceRes = 401;

            double balanceUpdated = accountMock.Credit(amount);

            Assert.AreNotEqual(balanceRes, balanceUpdated);
        }

        [TestMethod]
        public void BankAccount_Debit_Test_Success()
        {
            _mock = new Mock<IBankAccount>();

            BankAccount accountMock = new BankAccount();
            accountMock.SetNameOfCustomer("Chris");
            accountMock.Balance = 200;

            double amount = 100;

            _mock.Setup(x => x.Debit(It.IsAny<double>()));

            double balanceRes = 100;

            double balanceUpdated = accountMock.Debit(amount);

            Assert.AreEqual(balanceRes, balanceUpdated);
        }

        [TestMethod]
        public void BankAccount_Debit_Test_Fail()
        {
            _mock = new Mock<IBankAccount>();

            BankAccount accountMock = new BankAccount();
            accountMock.SetNameOfCustomer("Chris");
            accountMock.Balance = 200;

            double amount = 100;

            _mock.Setup(x => x.Debit(It.IsAny<double>()));

            double balanceRes = 99;

            double balanceUpdated = accountMock.Debit(amount);

            Assert.AreNotEqual(balanceRes, balanceUpdated);
        }


    }
}
