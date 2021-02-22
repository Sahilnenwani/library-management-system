using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace libraryproject.Factory.Abstarct_Factory
{
    public class Machinelearningfactory : IBookfactory
    {
       
        public IBookcategories Bookcategories()
        {
            return new Machinelearning();
        }

        public IAlltheBooks AlltheBooks()
        {
            return new AI();
        }

        public virtual IBooktypes Booktypes()
        {
            return new EBook();
        }
    
    }
    
    public class MachinelearningfactoryphysicalBook: Machinelearningfactory
    {

    public override IBooktypes Booktypes()
        {
            return new PhysicalBook();
        }

    }
}