﻿using Kutuphane.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DataAccess.Haritalar
{
    public class TanimMap : EntityTypeConfiguration<Tanim>
    {
        public TanimMap()
        {
            this.HasKey(c=>c.Id);
            this.Property(c => c.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity) ;
            this.Property(c => c.Tanimi).HasMaxLength(200);
            this.Property(c=>c.Aciklama).HasMaxLength(200);

            this.ToTable("Tanimlar");

            this.Property(c => c.Id).HasColumnName("Id");
            this.Property(c => c.Tanimi).HasColumnName("Tanimi") ;
            this.Property(c => c.Aciklama).HasColumnName("Aciklama");
        }
    }
}
