using System;
using System.Collections.Generic;

namespace CoffeeshopRegistrationMVCLab.Models
{
    public partial class CoffeeshopUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
