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
            modelBuilder.Entity<HistoriasClinicas>().HasIndex();
        }



        public Microsoft.EntityFrameworkCore.DbSet<HistoriasClinicas> HistoriasClinicas { get; set; }


        public HistoriasClinicas CreateHistoriasClinicas(HistoriasClinicasDto historias)
        {
            throw new NotImplementedException();
        }
    }


}

