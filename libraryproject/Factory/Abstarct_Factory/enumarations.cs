using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace libraryproject.Factory.Abstarct_Factory
{
    public class enumarations
    {
        public enum Booktypes
        {
            //COCIS,
            //COE,
            //COBA
            Ebook,
            PhysicalBook

        }
        public enum Bookcategories
        {
            Computer,
            Engineering,
            Business
        } 
        public enum AlltheBooks
        {
            AI,
            programing_languages,
            Discrete_Maths,
            Electricity, 
            Electromagnetism,
            Finance
            
            
        }

    }
}