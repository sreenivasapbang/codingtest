/*This program is to run business rules based on Payment type*/
using System;
using System.Collections;
namespace PaymentsBREV1
{

    //This is the default class to run the program as console application
    //Taking single char which denotes the PaymentAction which is then passed to the 
    //AllPayments class for processing 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Payment BRE");
            Console.WriteLine("Choose Payment BRE Action Type; Type Initial");
            Console.WriteLine("A. PyProduct");
            Console.WriteLine("B. Book");
            Console.WriteLine("C. Membership");
            Console.WriteLine("D. UpgradeMembership");
            Console.WriteLine("E. MemupOrUpgr");
            Console.WriteLine("F. Video");
            Console.WriteLine("G. PyProdOrBook");
            Console.WriteLine("Y. PRESS Y TO QUIT...");
            //Console.WriteLine("X. V2 Others");
            //Console.WriteLine("Z. Others");

            AllPayments payments = new AllPayments();
            payments.InitializePayments();
            //ArrayList arrayList = payments.CreatePaymentActions(new PaymentsProduct());

            //GeneriPaymentBRE generiPaymentBRE = new GeneriPaymentBRE();
            //generiPaymentBRE.PaymentActionType = "PyProduct";
            //generiPaymentBRE.BusinessRule = "Product Packing slip is generated...";

            //System.Collections.Generic.List<IPayments> paymentsList = payments.CreatePaymentActions(generiPaymentBRE);

            //generiPaymentBRE = new GeneriPaymentBRE();
            //generiPaymentBRE.PaymentActionType = "Book";
            //generiPaymentBRE.BusinessRule = "Book Rule -  Created duplicate packing slip for Royalty Department ...";
            //paymentsList = payments.CreatePaymentActions(generiPaymentBRE);

            //generiPaymentBRE = new GeneriPaymentBRE();
            //generiPaymentBRE.PaymentActionType = "Membership";
            //generiPaymentBRE.BusinessRule = "Membership Rule -  Membership Activated ...";
            //paymentsList = payments.CreatePaymentActions(generiPaymentBRE);

            //generiPaymentBRE = new GeneriPaymentBRE();
            //generiPaymentBRE.PaymentActionType = "UpgradeMembership";
            //generiPaymentBRE.BusinessRule = "Upgrade Membership Rule -  Membership Upgraded...";
            //paymentsList = payments.CreatePaymentActions(generiPaymentBRE);

            //generiPaymentBRE = new GeneriPaymentBRE();
            //generiPaymentBRE.PaymentActionType = "MemupOrUpgr";
            //generiPaymentBRE.BusinessRule = "Membership/Upgrade Rule -  mailed to Owner and Membership Upgraded...";
            //paymentsList = payments.CreatePaymentActions(generiPaymentBRE);

            //generiPaymentBRE = new GeneriPaymentBRE();
            //generiPaymentBRE.PaymentActionType = "Video";
            //generiPaymentBRE.BusinessRule = "Video Rule -  Added Fee to First Aid video...";
            //paymentsList = payments.CreatePaymentActions(generiPaymentBRE);

            //generiPaymentBRE = new GeneriPaymentBRE();
            //generiPaymentBRE.PaymentActionType = "PyProdOrBook";
            //generiPaymentBRE.BusinessRule = "PyProdOrBook Rule -  Commission payment generated to Agent...";
            //paymentsList = payments.CreatePaymentActions(generiPaymentBRE);

            //Retrieve the Business Rule for Action Type
            var varActionType = 'A'; // Console.ReadKey().KeyChar;
            var strActionType = "";

            while (true)
            {
                varActionType = Console.ReadKey().KeyChar;
                if (varActionType == 'Y')
                    break;

                switch (varActionType)
                {
                    case 'A':
                        {
                                payments.GetPaymentsByAction("PyProduct");
                            break;
                        }
                    case 'B':
                        {
                                payments.GetPaymentsByAction("Book");
                            break;
                        }
                    case 'C':
                        {
                                payments.GetPaymentsByAction("Membership");
                            break;
                        }
                    case 'D':
                        {
                                payments.GetPaymentsByAction("UpgradeMembership");
                            break;
                        }
                    case 'E':
                        {
                                payments.GetPaymentsByAction("MemupOrUpgr");
                            break;
                        }


                    case 'F':
                        {
                                payments.GetPaymentsByAction("Video");
                            break;
                        }

                    case 'G':
                        {
                                payments.GetPaymentsByAction("PyProdOrBook");
                                break;
                        }
                    default:
                        {
                                payments.GetPaymentsByAction(strActionType);
                                break;
                        }
                }
                                         
            }
        }
    }

}
