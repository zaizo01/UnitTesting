using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitTesting.Models
{
    public class Usuario
    {
        public int IdUser { get; set; }
        public String Name { get; set; }

        public String lastname { get; set; }

        public String password { get; set; }

        public DateTime date { get; set; }
    }
}