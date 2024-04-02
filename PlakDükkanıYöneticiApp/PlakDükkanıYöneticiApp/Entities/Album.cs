using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDükkanıYöneticiApp.Entities
{
    public class Album
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public DateTime AlbumCikisTarihi { get; set; }
        public double AlbumFiyat {  get; set; }
        public int IndirimOranı { get; set; }
        public bool SatısDurum {  get; set; }
        public int SanatciId { get; set; }
        public Sanatci? Sanatci { get; set; }
    }
}
