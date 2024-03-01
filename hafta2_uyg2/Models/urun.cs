using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace hafta2_uyg2.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Acıklama { get; set; }
        public string Resim { get; set; }
    }
}