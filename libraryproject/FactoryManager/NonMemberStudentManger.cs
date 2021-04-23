using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace libraryproject.FactoryManager
{
    public class NonMemberStudentManger : IStudentManger
    {
        public decimal GetBooks()
        {
            return 2;
        }

        public decimal GetDays()
        {
            return 15;
        }
    }
}