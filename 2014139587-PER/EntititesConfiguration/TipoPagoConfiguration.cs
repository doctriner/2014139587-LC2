﻿using _2014139587_ENT;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014139587_PER.EntititesConfiguration
{
    public class TipoPagoConfiguration : EntityTypeConfiguration<TipoPago>
    {
        public TipoPagoConfiguration()
        {
            //Table configurations
            ToTable("TipoPagos");
            HasKey(c => c.TipoPagoId);
            Property(c => c.TipoPagoId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(c => c.MetodoPago).IsRequired().HasMaxLength(300);
        }
    }
}
