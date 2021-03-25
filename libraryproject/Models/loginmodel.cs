using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace libraryproject.Models
{
    public class loginmodel
    {   [Required] 
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string Userpassword { get; set; }
    }
}