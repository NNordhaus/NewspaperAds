﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewspaperAds.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class NewspapersEntities : DbContext
    {
        public NewspapersEntities()
            : base("name=NewspapersEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Ad> Ads { get; set; }
        public DbSet<Allocation> Allocations { get; set; }
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Paper> Papers { get; set; }
    }
}
