using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UçakBiletRezervasyon.Models
{
    public class Lokasyon
    {
        public int id { get; set; }
        public string Ulke { get; set; }
        public string Sehir{ get; set; }
        public string Havaalani { get; set; }
        public string Tarih { get; set; }
        public string Saat { get; set; }
     
    }
}
