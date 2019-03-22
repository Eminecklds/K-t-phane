using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    class EmanetKitap
    {
        public string YazarAdi
        {
            get; set;
        }
        public string KitapAdi
        { get; set; }
        public DateTime alim { get; set; }
        public DateTime teslim { get; set; }
        public string tc { get; set; }
    }
}
