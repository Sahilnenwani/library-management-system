using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace libraryproject.Bridge_Method
{
    public abstract class Payment
    {
        public IPaymentSystem _IPaymentSystem;
        public abstract void MakePayment();
    }
}