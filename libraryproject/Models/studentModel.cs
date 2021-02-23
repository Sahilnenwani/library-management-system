using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace libraryproject.Models
{
    public class studentModel
    {
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        //public studentModel()
        //{
        //    this.BookFineTables = new HashSet<BookFineTable>();
        //    this.BookReturnTables = new HashSet<BookReturnTable>();
        //    this.IssueBookTables = new HashSet<IssueBookTable>();
        //}

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int StuentTypeID { get; set; }
        public int DepartmentID { get; set; }
        public bool IsActive { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BookFineTable> BookFineTables { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<BookReturnTable> BookReturnTables { get; set; }
        //public virtual DepartmentTable DepartmentTable { get; set; }
        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<IssueBookTable> IssueBookTables { get; set; }
        //public virtual StudentTypeTable StudentTypeTable { get; set; }
    }
}
