using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static libraryproject.Factory.Abstarct_Factory.enumarations;

namespace libraryproject.Factory.Abstarct_Factory
{
    public class Machinelearning : IBookcategories
    {
        public string GetBookCategories()
        {
            return Bookcategories.Computer.ToString();
        }
    }
}