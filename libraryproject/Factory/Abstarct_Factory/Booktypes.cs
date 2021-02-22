using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static libraryproject.Factory.Abstarct_Factory.enumarations;

namespace libraryproject.Factory.Abstarct_Factory
{
    public class EBook : IBooktypes
    {
        public string GetBooktypes()
        {
            return Booktypes.Ebook.ToString();
        }
    }
    public class PhysicalBook : IBooktypes
    {
        public string GetBooktypes()
        {
            return Booktypes.PhysicalBook.ToString();
        }
    }
}