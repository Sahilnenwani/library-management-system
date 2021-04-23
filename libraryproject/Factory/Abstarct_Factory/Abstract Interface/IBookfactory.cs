using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryproject.Factory.Abstarct_Factory
{
    public interface IBookfactory
    {
        IAlltheBooks AlltheBooks();
        IBookcategories Bookcategories();
        IBooktypes Booktypes();
    }
}
