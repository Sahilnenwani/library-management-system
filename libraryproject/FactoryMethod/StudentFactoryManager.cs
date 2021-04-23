using libraryproject.FactoryManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace libraryproject.FactoryMethod
{
    public class StudentFactoryManager
    {
        public IStudentManger GetStudentManager(int studenttypeid)
        {
            IStudentManger returnvalue = null;
            if (studenttypeid == 1)
            {
                returnvalue = new MemberStudentManager();

            }
            else if (studenttypeid ==2)
            {
                returnvalue = new NonMemberStudentManger();
            }
            return returnvalue;
        }
            }
}