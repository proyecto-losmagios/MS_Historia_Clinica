using HCTemplateDomain.DTOs;
using HCTemplateDomain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace MSHCAccesData
{
    public class HCTemplateContext : DbContext
    {
        public HCTemplateContext(DbContextOptions<HCTemplateContext> options)
            : base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HistoriasClinicas>(entity =>
                entity.HasKey(q => q.HistoriaClinicaId)
            ) ;
        }



        public DbSet<HistoriasClinicas> HistoriasClinicas { get; set; }

    }


}

