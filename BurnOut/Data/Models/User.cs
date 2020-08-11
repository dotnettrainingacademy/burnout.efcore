using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BurnOut.Data.Models
{
    class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
