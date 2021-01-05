using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace partialview.Models
{
    public class Urun
    {
        [Required]
        public string UrunAdi { get; set; }
        public int UrunKodu { get; set; }
        public int  UrunAdedi { get; set; }
    }
}
