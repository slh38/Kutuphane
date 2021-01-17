using Kutuphane.DataAccess.Arayuzler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.Entities
{
    public class Sinif: IEntity
    {
        public int Id { get; set; }
        public string OkulTuru { get; set; }
        public string Sinifi { get; set; }
        public string Subesi { get; set; }
        public string Bolumu { get; set; }
        public string Aciklama { get; set; }
        public virtual ICollection<Uye> Uyeler { get; set; }
    }
}
