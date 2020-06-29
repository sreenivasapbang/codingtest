using PaymentsBREV1;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PaymentsBREV1.Tests
{
  [TestClass()]
  public class PaymentsBREUnitTest
  {
    [TestMethod()]
    public void AllPaymentsTest()
    {
            AllPayments paymentBRE = new AllPayments(new GenericPaymentBRE());
            //All positive scenarios for testing
            Assert.AreEqual(true, paymentBRE.RunPaymentBRE("PyProduct"));
            Assert.AreEqual(true, paymentBRE.RunPaymentBRE("Book"));

            Assert.AreEqual(true, paymentBRE.RunPaymentBRE("Book"));
            Assert.AreEqual(true, paymentBRE.RunPaymentBRE("Membership"));
            Assert.AreEqual(true, paymentBRE.RunPaymentBRE("UpgradeMembership"));
            Assert.AreEqual(true, paymentBRE.RunPaymentBRE("MemupOrUpgr"));
            Assert.AreEqual(true, paymentBRE.RunPaymentBRE("Video"));
            Assert.AreEqual(true, paymentBRE.RunPaymentBRE("PyProductOrBook"));


            //To demonstrate the fail case
            Assert.AreEqual(true, paymentBRE.RunPaymentBRE("Others"));
            Assert.AreEqual(true, paymentBRE.RunPaymentBRE("OthersV2"));

    }
    
    
        [TestMethod()]
        public void RunPaymentBRENewRuleTest()
        {

            //To demonstrate the pass case with new BRE classes
            //AllPayments paymentBRE = new AllPayments(new NewPaymentBRE());
            //Assert.AreEqual(true, paymentBRE.RunPaymentBRE("Others"));

            //Uncomment To demonstrate fail case
            AllPayments paymentBRE = new AllPayments(new NewPaymentBRE());
            Assert.AreEqual(true, paymentBRE.RunPaymentBRE("OthersTest"));
        }


        [TestMethod()]
        public void RunPaymentBRENewV2RuleTest()
        {

            //To demonstrate the pass case with new BRE classes
            
            AllPayments paymentBRE = new AllPayments(new NewV2PaymentBRE());
            Assert.AreEqual(true, paymentBRE.RunPaymentBRE("OthersV2"));

            //Uncomment To demonstrate fail case
            //AllPayments paymentBRE = new AllPayments(new NewV2PaymentBRE());
            //Assert.AreEqual(true, paymentBRE.RunPaymentBRE("OthersV2Test"));

        }
  }
}