using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkCodeFirst.Etities
{
    [Table("Musteri")]
    public class Musteri
    {
        [Key]
        public int MusteriID { get; set; }
        public string MusteriÜnvanı { get; set; }
        public string MusteriAdres { get; set; }
        public string Telefon { get; set; }
        public string yeni { get; set; }

    }
}
