using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication8.Models
{
    public class UserProfileModel
    {

        [Display(Name = "Full Name:")]
        [Required(ErrorMessage ="Full Name is required.")]
        public string FullName { get; set; }

        

        [Display(Name = "Pass:")]
        [Required(ErrorMessage = "pass is required.")]
        public string Address { get; set; }

    }
}