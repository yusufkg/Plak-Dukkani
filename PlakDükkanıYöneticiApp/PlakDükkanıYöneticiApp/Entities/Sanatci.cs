using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDükkanıYöneticiApp.Entities
{
    public class Sanatci
    {
        public int Id { get; set; }
        public string AlbumSanatcısı { get; set; }    
        public List<Album> Albums {  get; set; }
        public override string ToString()
        {
            return  AlbumSanatcısı;
        }
    }
}
