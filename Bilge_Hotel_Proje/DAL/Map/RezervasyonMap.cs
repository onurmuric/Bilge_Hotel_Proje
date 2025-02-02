﻿using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Map
{
    public class RezervasyonMap: EntityTypeConfiguration<Rezervasyon>
    {
        public RezervasyonMap()
        {
            ToTable("dbo.Rezervasyonlar");
            Property(x => x.RezervasyonID).IsRequired();
            Property(x => x.RezervasyonTarihi).IsRequired();
            Property(x => x.KonaklamaBaslangic).IsRequired();
            Property(x => x.OdaID).IsRequired();
            Property(x => x.TatilPaketiID).IsRequired();
            Property(x => x.KonaklamaBitis).IsRequired();
            Property(x => x.GunSayisi).IsRequired();
            


        }
    }
}
