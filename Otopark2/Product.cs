using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark2
{
    public class table
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public string Renk { get; set; }
        public double Telefon { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime GirisSaati { get; set; }
        public DateTime CikisTarihi { get; set; }
        public int Ücret { get; set; }
        public int Yer { get; set; }


    }
}
