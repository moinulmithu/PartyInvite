using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage= "You must enter your Name first")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Your Email address can't be empty. please enter a valid email address")]
        [RegularExpression(".+\\@.+\\..+",ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your Phone No.")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Please specify wheather you come or not????")]
        public bool? WillAttend { get; set; }
    }
}