﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityOrnek.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DbSinavOgrenciEntities : DbContext
    {
        public DbSinavOgrenciEntities()
            : base("name=DbSinavOgrenciEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ders> ders { get; set; }
        public virtual DbSet<ogrenci> ogrenci { get; set; }
        public virtual DbSet<kulup> kulup { get; set; }
        public virtual DbSet<notlar> notlar { get; set; }
    
        public virtual ObjectResult<notListesi_Result> notListesi()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<notListesi_Result>("notListesi");
        }
    }
}
