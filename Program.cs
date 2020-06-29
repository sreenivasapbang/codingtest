/*This program is to run business rules based on Payment type*/
using System;
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
            Console.WriteLine("X. V2 Others");
            Console.WriteLine("Z. Others");

            var varActionType = Console.ReadKey().KeyChar;
            AllPayments paymentBRE;

            paymentBRE = new AllPayments(new GenericPaymentBRE());
            if (varActionType == 'A')
            {                
                paymentBRE.RunPaymentBRE("PyProduct");
            }
            if (varActionType == 'B')
            {
                paymentBRE.RunPaymentBRE("Book");
            }
            if (varActionType == 'C')
            {
                paymentBRE.RunPaymentBRE("Membership");
            }
            if (varActionType == 'D')
            {
                paymentBRE.RunPaymentBRE("UpgradeMembership");
            }
            if (varActionType == 'E')
            {
                paymentBRE.RunPaymentBRE("MemupOrUpgr");
            }

            if (varActionType == 'F')
            {
                paymentBRE.RunPaymentBRE("Video");
            }
            if (varActionType == 'G')
            {
                paymentBRE.RunPaymentBRE("PyProdOrBook");
            }
            if (varActionType == 'Z')
            {
                paymentBRE = new AllPayments(new NewPaymentBRE());
                paymentBRE.RunPaymentBRE("Others");
            }
            if (varActionType == 'X')
            {
                paymentBRE = new AllPayments(new NewV2PaymentBRE());
                paymentBRE.RunPaymentBRE("Others");
            }

            paymentBRE = null;
            Console.ReadKey();
        }
    }

}
