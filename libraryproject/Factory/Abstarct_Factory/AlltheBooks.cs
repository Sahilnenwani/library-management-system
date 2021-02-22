using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static libraryproject.Factory.Abstarct_Factory.enumarations;

namespace libraryproject.Factory.Abstarct_Factory
{
    public class AI : IAlltheBooks
    {
        public string GetAlltheBooks()
        {
            return AlltheBooks.AI.ToString();
        }
    }
    public class programing_languages : IAlltheBooks
    {
        public string GetAlltheBooks()
        {
            return AlltheBooks.programing_languages.ToString();

        }
    }

    public class Discrete_Maths : IAlltheBooks
    {
        public string GetAlltheBooks()
        {
            return AlltheBooks.Discrete_Maths.ToString();

        }
    }

    public class Finance : IAlltheBooks
    {
        public string GetAlltheBooks()
        {
            return AlltheBooks.Finance.ToString();

        }
    }

    public class Electricity : IAlltheBooks
    {
        public string GetAlltheBooks()
        {
            return AlltheBooks.Electricity.ToString();

        }
    }
    public class Electromagnetism: IAlltheBooks
    {
        public string GetAlltheBooks()
        {
            return AlltheBooks.Electromagnetism.ToString();

        }
    }

}