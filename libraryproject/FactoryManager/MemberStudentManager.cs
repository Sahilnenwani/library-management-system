using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace libraryproject.FactoryManager
{
    public class MemberStudentManager : IStudentManger
    {
        public decimal GetBooks()
        {
            return 6;
        }

        public decimal GetDays()
        {
           return 30;
        }
    }
}