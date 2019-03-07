using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JWT_validation.Models
{
    public class UserRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}