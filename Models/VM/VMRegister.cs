using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UserApp.Models.VM
{
    public class VMRegister
    {
        public Guid ID { get; set; }

        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
       
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Enter Valid E-mail")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        public string RePassword { get; set; }
        public string CreatedOn { get; set; }
        public string LastLogin { get; set; }
}
}