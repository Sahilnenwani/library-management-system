using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace libraryproject.Bridge_Method
{
    public class OnlinePayment:Payment
    {
        public override void MakePayment()
        {
            _IPaymentSystem.ProcessPayment("Cash payment");
        }
    }
}