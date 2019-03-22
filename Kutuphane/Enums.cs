using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace Kutuphane
{
    class Enums
    {
        public enum YazarAdi
        {

            [Description("Wilian Golding")]
            Willian_Golding,
            [Description("Namık Kemal")]
            Namık_Kemal,
            [Description("John Verdon")]
            John_Verdon,

        }

        public enum KitapAdi
        {

            [Description("Sineklerin Tanrısı")]
            Sineklerin_Tanrisi,
            [Description("İntibah")]
            İntibah,
            [Description("Aklından Bir Sayı Tut")]
            Aklindan_Bir_Sayi_Tut,

        }

    }
}
