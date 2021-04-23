using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace libraryproject.Factory.Abstarct_Factory
{
    public class BookSystemManger
    {
        IBookfactory _IBookfactory;
        public BookSystemManger(IBookfactory iBookfactory)
        {
            _IBookfactory = iBookfactory;
        }
        public string GetSystemDatails()
        {
            IBookcategories Bookcategories = _IBookfactory.Bookcategories();
            IAlltheBooks alltheBooks = _IBookfactory.AlltheBooks();
            IBooktypes booktypes = _IBookfactory.Booktypes();
            string returnvalue = string.Format("{0} {1} {2}", Bookcategories.GetBookCategories(), booktypes.GetBooktypes(), alltheBooks.GetAlltheBooks());
        return returnvalue;
                }
    }
}