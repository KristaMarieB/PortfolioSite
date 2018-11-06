﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PortfolioSite.Models
{
    public class Visitor
    {
        // no args
        public Visitor() { }

        [Key]
        public int VisitorID { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        public Visitor(string Name, string Email)
        {
            FullName = Name;
            EmailAddress = Email;
        }

    }
}