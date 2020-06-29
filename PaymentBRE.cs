using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// This file holds the interface and the implemenation classes
/// </summary>
namespace PaymentsBREV1
{
    ////Interface declaring the rules of the payment action method
    public interface IPayments
    {
        bool paymentAction(string actionType);
        string PaymentActionType { get; set; }
        string BusinessRule
        {
            get; set;
        }
    }
    public interface IPaymentsFactory
    {
        //ArrayList CreatePaymentActions(AbsPayments payments);
        List<IPayments> CreatePaymentActions(IPayments payments);
        bool GetPaymentsByAction(string ActionType);
    }

    
        public void InitializePayments()
        {

            GeneriPaymentBRE generiPaymentBRE = new GeneriPaymentBRE();
            generiPaymentBRE.PaymentActionType = "PyProduct";
            generiPaymentBRE.BusinessRule = "Product Packing slip is generated...";

            System.Collections.Generic.List<IPayments> paymentsList = CreatePaymentActions(generiPaymentBRE);

            generiPaymentBRE = new GeneriPaymentBRE();
            generiPaymentBRE.PaymentActionType = "Book";
            generiPaymentBRE.BusinessRule = "Book Rule -  Created duplicate packing slip for Royalty Department ...";
            paymentsList = CreatePaymentActions(generiPaymentBRE);

            generiPaymentBRE = new GeneriPaymentBRE();
            generiPaymentBRE.PaymentActionType = "Membership";
            generiPaymentBRE.BusinessRule = "Membership Rule -  Membership Activated ...";
            paymentsList = CreatePaymentActions(generiPaymentBRE);

            generiPaymentBRE = new GeneriPaymentBRE();
            generiPaymentBRE.PaymentActionType = "UpgradeMembership";
            generiPaymentBRE.BusinessRule = "Upgrade Membership Rule -  Membership Upgraded...";
            paymentsList = CreatePaymentActions(generiPaymentBRE);

            generiPaymentBRE = new GeneriPaymentBRE();
            generiPaymentBRE.PaymentActionType = "MemupOrUpgr";
            generiPaymentBRE.BusinessRule = "Membership/Upgrade Rule -  mailed to Owner and Membership Upgraded...";
            paymentsList = CreatePaymentActions(generiPaymentBRE);

            generiPaymentBRE = new GeneriPaymentBRE();
            generiPaymentBRE.PaymentActionType = "Video";
            generiPaymentBRE.BusinessRule = "Video Rule -  Added Fee to First Aid video...";
            paymentsList = CreatePaymentActions(generiPaymentBRE);

            generiPaymentBRE = new GeneriPaymentBRE();
            generiPaymentBRE.PaymentActionType = "PyProdOrBook";
            generiPaymentBRE.BusinessRule = "PyProdOrBook Rule -  Commission payment generated to Agent...";
            paymentsList = CreatePaymentActions(generiPaymentBRE);

        }

    ////Client class which calls the payments implemenation class through interface for all the payments action type
    /// <summary>
    /// This class is also used by the unit test class
    /// </summary>
    public class AllPayments : IPaymentsFactory
    {
        private List<IPayments> _allPaymentsArray;
    
        private List<IPayments> _payments;
        public List<IPayments> PaymentsList
        {
            get
            {
                if (_payments == null)
                {
                    _payments = new List<IPayments>();
                }
                return _payments;
            }
            set
            {
                _payments = value;
            }
        }

        //Adds all Payment actions to the list
        public List<IPayments> CreatePaymentActions(IPayments payments)
        {
            
            //List<IPayments> AllPaymentsArray = new List<IPayments>();
            PaymentsList.Add(payments);
            _allPaymentsArray = PaymentsList;
            return _allPaymentsArray;
        }

        //Retrieves Payment Business Rule actions by the Action Type
        public bool GetPaymentsByAction(string ActionType)
        {
            bool foundAction = false;
            foreach (IPayments aPayments in PaymentsList)
            {
                //aPayments.paymentActions();
                if (aPayments.paymentAction(ActionType))
                {
                    foundAction = true;
                    return true;
                }
            }

            if (!foundAction)
            {
                Console.Write("No matching Payment Action found");
                return false;
            }
            else
                return true;
        }
    }


    //Generic Class to hold Business Rules for each product and perform respective action
    public class GeneriPaymentBRE : IPayments
    {
        //Default Constructor
        public GeneriPaymentBRE()
        {

        }

        
            //This property holds the Action Type
        private string _paymentActionType;
        public string PaymentActionType
            {
            get
            {

                return _paymentActionType;
            }
            set
            {
                    _paymentActionType = value;
            }
        }

        //This property holds the Business rule information
        private string _businessRule;
        public string BusinessRule
        {
            get
            {

                return _businessRule;
            }
            set
            {
                _businessRule = value;
            }
        }


        //Implementing paymentAction method as declared in the Interface
        public bool paymentAction(string actionType)
        {

            if (actionType == PaymentActionType)
            {
                Console.Write(BusinessRule);
                return true;
            }
            //Console.Write("New Business Rule V2 Payment Action is wrong");
            return false;
        }
    }
    
}
