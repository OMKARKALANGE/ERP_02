using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Erp_02.Models
{
    public class Nuser
    {
        [Key]
        public int id { get; set; }

        public int role { get; set; }
        public string username { get; set; }

        public string password { get; set; }

    }
}