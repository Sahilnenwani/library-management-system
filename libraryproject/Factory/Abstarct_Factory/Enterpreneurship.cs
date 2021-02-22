using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace libraryproject.Factory.Abstarct_Factory
{
    public class Enterpreneurship : IBookcategories
    {
        public string GetBookCategories()
        {
            return enumarations.Bookcategories.Business.ToString();
        }
    }
}