using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryproject.Bridge_Method
{
        public interface IPaymentSystem
    {
        string ProcessPayment(string PaymentSystem);
    }
}
