using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AarhusWebDevClub.Models.ViewModels
{
    public class ContactForm
    {
        [Required]
        public string Name { get; set; }
        [Required(ErrorMessage = "This is not a valid Email address")]
        public string Email { get; set; }

        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
    }

}