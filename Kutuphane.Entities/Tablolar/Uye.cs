using Kutuphane.DataAccess.Arayuzler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Entities
{
    public class Uye: IEntity
    {
        public int Id { get; set; }
        public bool Durum { get; set; }
        public string TcKimlikNo { get; set; }
        
        public int OkulNo { get; set; }
        public string Barkod { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int SinifId { get; set; }
        public string YabanciDil { get; set; }
        public DateTime KayitTarihi { get; set; }
        public string Aciklama { get; set; }
       
        public virtual Sinif Sinif  { get; set; }
        public virtual ICollection<Telefon> Telefonlar { get; set; }
        public virtual ICollection<Adres> Adresler { get; set; }
        public virtual ICollection<KitapHareket> KitapHareketleri { get; set; }

    }
}
