using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkCodeFirst.Etities
{
    [Table("Urun")]
    public class Urun
    {
        [Key]
        public int UrunID { get; set; }
        public string UrunaAdi { get; set; }
        public int Stok { get; set; }
        public decimal Fiyat { get; set; }
        public byte[] Resim { get; set; }
        public Kategori Kategori { get; set; }
        public List<Satis> Satislar { get; set; }


    }
}
