using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please enter you name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter you email address")]
        [RegularExpression(".+\\@.+\\..+",
            ErrorMessage ="Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter you phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please specify whether you'll attent")]
        public bool? WillAttend { get; set; }
    }
}