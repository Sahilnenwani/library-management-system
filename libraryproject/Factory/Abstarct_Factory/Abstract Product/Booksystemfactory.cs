﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace libraryproject.Factory.Abstarct_Factory
{
    public class Booksystemfactory
    {


        public IBookfactory Create(StudentTypeTable e)
        {
            IBookfactory Returnvalue = null;
            if (e.StudentType == "Member")
            {
                Returnvalue = new Machinelearningfactory();
            }
            else
            {
                Returnvalue = new Entrepreneurshipfactory();
            }
            return Returnvalue;

        }

        internal IBookfactory Create(StudentTable studentTable)
        {
            throw new NotImplementedException();
        }
        //IBookfactory _IBookfactory;
        //public string GetBookdetails()
        //{
        //    IBooktypes booktype = _IBookfactory.Booktypes();
        //    IBookcategories Bookfactory = _IBookfactory.Bookcategories();
        //    IAlltheBooks AlltheBooks = _IBookfactory.AlltheBooks();
        //    string returnvale = string.Format("{0} {1} {2}", booktype.GetBooktypes(), Bookfactory.GetBookCategories(), AlltheBooks.GetAlltheBooks());
        //    return returnvale;
        //}
    }
}