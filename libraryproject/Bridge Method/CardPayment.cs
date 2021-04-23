using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace libraryproject.Bridge_Method
{
    public class CardPayment:Payment
    {
        public override void MakePayment()
        {
            _IPaymentSystem.ProcessPayment("Card payment");
        }
    }
}