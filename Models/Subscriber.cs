using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ivosWebsite.Models
{
    public class Subscriber
    {
        public string? Name { get; set; }

        [Required, EmailAddress]
        public string? Email { get; set; }
    }
}

