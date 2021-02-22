using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace libraryproject.Models
{
    public class Book
    {
        public int UserID { get; set; } 
        public int BookID { get; set; }
        public string BookName { get; set; }
        public int IssueDate { get; set; }
        public string  ReturnDate{ get; set; }

        public string  Catogry{ get; set; }

    }
}