using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace libraryproject.Factory.Abstarct_Factory
{
    public class Entrepreneurshipfactory : IBookfactory
    {
        

        public IBookcategories Bookcategories()
        {
            return new Enterpreneurship();
        }
        public IAlltheBooks AlltheBooks()
        {
            return new Finance();
        }
        public virtual IBooktypes Booktypes()
        {
            return new EBook();
        }
    }
    public class Entrepreneurshipfactorypyhsicalbook : Entrepreneurshipfactory
    {
        public override IBooktypes Booktypes()
        {
            return new PhysicalBook();
        }
    }
}