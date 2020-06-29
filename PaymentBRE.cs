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

    //Interface declaring the rules of the payment action method
    public interface IPayments
    {
        bool paymentAction(string actionType);

    }
    
    
    
    //Generic class to test all the payment action types
      public class GenericPaymentBRE : IPayments
      {
        private void paymentBRE()
        {

        }

        public bool paymentAction(string actionType)
        {

            switch (actionType)
            {
                case "PyProduct":
                    {
                        Console.Write("PackingSlip Generated");
                        return true;
                    }
                case "Book":
                    {
                        Console.Write("Duplicate PackingSlip for Royalty Dept Generated");
                        return true;
                    }
                case "Membership":
                    {
                        Console.Write("Membership Activated");
                        return true;
                    }
                case "UpgradeMembership":
                    {
                        Console.Write("Membership Upgraded");
                        return true;
                    }
                case "MemupOrUpgr":
                    {
                        Console.Write("Membership Activate and then Upgrade");
                        return true;
                    }

                case "Video":
                    {
                        Console.Write("FirstAid video added to the PackingSlip");
                        return true;
                    }
                case "PyProdOrBook":
                    {
                        Console.Write("Commission Generated for agent");
                        return true;
                    }
                default:
                    Console.Write("May be Future action type");
                    return false;
            }
        }
    }
    
    //New Business Rule 
    public class NewPaymentBRE : IPayments
    {
        //Default Constructor
        public NewPaymentBRE()
        {
        }
        public bool paymentAction(string actionType)
        {
            if (actionType == "Others")
            {
                Console.Write("New Business Rule is executed");
                return true;
            }
            Console.Write("New Business Rule Payment Action is wrong");
            return false;
        }
    }
    //Yet Another New Business Rule 
    public class NewV2PaymentBRE : IPayments
    {
        //Default Constructor
        public NewV2PaymentBRE()
        {

        }
        //Implementing paymentAction method as declared in the Interface
        public bool paymentAction(string actionType)
        {

            if (actionType == "OthersV2")
            {
                Console.Write("V2 New rule IS MODIFIED");
                return true;
            }
            Console.Write("New Business Rule V2 Payment Action is wrong");
            return false;
        }
    }
    
}
