using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace libraryproject.Bridge_Method
{
    public class HBLpaymentsystem:IPaymentSystem
    {
       public string ProcessPayment(string paymentSystem)
        {
            return "Using HBLpayment getway for" + paymentSystem;
        }
    }
}