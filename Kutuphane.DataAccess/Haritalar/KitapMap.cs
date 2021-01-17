using Kutuphane.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DataAccess.Haritalar
{
    public class KitapMap:EntityTypeConfiguration<Kitap>
    {
        public KitapMap()
        {
            this.HasKey(c => c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(c => c.KitapKodu).HasMaxLength(12);
            this.Property(c=>c.ISBN).HasMaxLength(20);
            this.Property(c=>c.KitapAdi).HasMaxLength(50);
            this.Property(c=>c.YayinEvi).HasMaxLength(50);
            this.Property(c => c.BasimYeri).HasMaxLength(30);
            this.Property(c => c.DemirBasNo).HasMaxLength(20);
            this.Property(c => c.Aciklama).HasMaxLength(200);

            this.ToTable("Kitaplar");
            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.Durum).HasColumnName("Durum");
            this.Property(c => c.OduncVerilebilir).HasColumnName("OduncVerilebilir");
            this.Property(c => c.BarkodId).HasColumnName("BarkodId");
            this.Property(c => c.KitapKodu).HasColumnName("KitapKodu");
            this.Property(c => c.ISBN).HasColumnName("ISBN");
            this.Property(c => c.KitapAdi).HasColumnName("KitapAdi");
            this.Property(c => c.YazarId).HasColumnName("YazarId");
            this.Property(c => c.TuruId).HasColumnName("TuruId");
            this.Property(c => c.YayinEvi).HasColumnName("YayinEvi");
            this.Property(c => c.BasimYili).HasColumnName("BasimYili");
            this.Property(c => c.BaskiSayisi).HasColumnName("BaskiSayisi");
            this.Property(c => c.CiltSayisi).HasColumnName("CiltSayisi");
            this.Property(c => c.SayfaSayisi).HasColumnName("SayfaSayisi");
            this.Property(c => c.BasimYeri).HasColumnName("BasimYeri");
            this.Property(c => c.Aciklama).HasColumnName("Aciklama");


        }    
    }
}
