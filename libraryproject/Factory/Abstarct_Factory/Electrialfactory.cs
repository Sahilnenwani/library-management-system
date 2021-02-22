using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace libraryproject.Factory.Abstarct_Factory
{
    public class Electrialfactory : IBookfactory
    {
        public IBookcategories Bookcategories()
        {
            return new Electrial();
            
        }
        public virtual IAlltheBooks AlltheBooks()
        {
            return new Electricity();
        }

        public virtual IBooktypes Booktypes()
        {
            return new EBook();
        }

    }
    public class Electrialfactoryphysicalbook : Electrialfactory
    {

        public override IBooktypes Booktypes()
        {
            return new PhysicalBook();
        }

    }
    public class ElectrialfactoryE : Electrialfactory
    {
        
        public override IAlltheBooks AlltheBooks()
        {
            return new Electromagnetism();
        }

       
    }
    public class Electrialfactorybook : Electrialfactoryphysicalbook
    {
        public override IAlltheBooks AlltheBooks()
        {
            return new Electromagnetism();
        }


    }

}