using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkCodeFirst.Etities
{
    public class Satis
    {
        public int SatisID { get; set; }
        List<Urun> Urunler { get; set; }

    }
}
