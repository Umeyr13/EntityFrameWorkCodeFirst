using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkCodeFirst.Etities
{
    [Table("Kategori")]
    public class Kategori
    {
        [Key]
        public int KategoriID { get; set; }
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }
        public List<Urun> Urunler { get; set; }

    }
}
