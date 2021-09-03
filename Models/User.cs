using System.Runtime.InteropServices;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// In SDK-style projects such as this one, several assembly attributes that were historically
// defined in this file are now automatically added during build and populated with
// values defined in project properties. For details of which attributes are included
// and how to customise this process see: https://aka.ms/assembly-info-properties


// Setting ComVisible to false makes the types in this assembly not visible to COM
// components.  If you need to access a type in this assembly from COM, set the ComVisible
// attribute to true on that type.

[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM.

[assembly: Guid("ed9bd9d2-e9a6-4b1e-8ee6-de42c15d19d2")]


namespace Rpc.Models
{
    public class User
    {
        public int ID { get; set; }

        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Confirm password doesn't match, Type again !")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string Firstname { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string Lastname { get; set; }

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime BirthDate { get; set; }
       
    }
}