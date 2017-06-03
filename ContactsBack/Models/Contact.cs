﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ContactsBack.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [Required(ErrorMessage = "You must enter a {0}")]
        [StringLength(30, ErrorMessage = "The field {0} can contain maximun {1} and minimum {2} characters", MinimumLength = 1)]
        [Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "You must enter a {0}")]
        [StringLength(30, ErrorMessage = "The field {0} can contain maximun {1} and minimum {2} characters", MinimumLength = 1)]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        public string Image { get; set; }

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email address")]
        [StringLength(100, ErrorMessage = "The field {0} can contain maximun {1} and minimum {2} characters", MinimumLength = 7)]
        public string EmailAddress { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone number")]
        [StringLength(20, ErrorMessage = "The field {0} can contain maximun {1} and minimum {2} characters", MinimumLength = 7)]
        public string PhoneNumber { get; set; }
    }

}