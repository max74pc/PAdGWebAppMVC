using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PAdGWebAppMVC.Models
{
    public class BlogArticle
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int BA_Id { get; set; }

        [Required]
        public string BA_Titolo { get; set; }

        [Required]
        public string BA_Categoria { get; set; }

        [Required]
        public string BA_Descrizione { get; set; }

        [Required]
        public string BA_URL { get; set; }

        [Required]
        public DateTime BA_DataOra_Pubblicazione { get; set; }
    }
}
    