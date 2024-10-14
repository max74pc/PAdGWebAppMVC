using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PAdGWebAppMVC.Models
{
    public class BlogCategory
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int BC_Id { get; set; }

        [Required]
        public string BC_Description { get; set; }

        [Required]
        public string BC_ShortDescr { get; set; }
    }
}