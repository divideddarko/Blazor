using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Twitch_Tools.Models
{
    public class PersonModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
    }
}