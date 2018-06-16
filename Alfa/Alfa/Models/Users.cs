using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Alfa.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Signature { get; set; }
        public string Email { get; set; }
        public bool Payed { get; set; }
    }
}