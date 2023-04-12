using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KisiselWebSitesi.Models.Siniflar
{
    public class ikonlar
    {
        [Key]
        public int Id { get; set; }
        public string Ikon { get; set; }
        public string Link { get; set; }

    }
}