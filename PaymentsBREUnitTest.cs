using PaymentsBREV1;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PaymentsBREV1.Tests
{
  [TestClass()]
  public class PaymentsBREUnitTest
  {
 
        [TestMethod()]
        public void GetPaymentsByActionTest()
        {
            
            AllPayments payments = new AllPayments();
            payments.InitializePayments();
            Assert.AreEqual(true,payments.GetPaymentsByAction("Book"));
            
        }

        [TestMethod()]
        public void AddPaymentsByActionTest()
        {
            AllPayments payments = new AllPayments();
            GeneriPaymentBRE generiPaymentBRE = new GeneriPaymentBRE();
            generiPaymentBRE.PaymentActionType = "New Product";
            generiPaymentBRE.BusinessRule = "New Product Action...";

            System.Collections.Generic.List<IPayments> paymentsList = payments.CreatePaymentActions(generiPaymentBRE);

                       
            Assert.AreEqual(true, payments.GetPaymentsByAction("New Product"));

        }
  }
}
