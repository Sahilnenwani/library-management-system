using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace libraryproject.Bridge_Method
{
    public class EassypaisapaymentSystem:IPaymentSystem
    {
        public string ProcessPayment(string paymentSystem)
        {
            return "Using EassyPaisapayment getway for" + paymentSystem;
        }

    }
}