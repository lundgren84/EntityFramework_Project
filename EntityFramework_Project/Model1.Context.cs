﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework_Project
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class HemmakvällEntities : DbContext
    {
        public HemmakvällEntities()
            : base("name=HemmakvällEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<tbl_HemmaKväll> tbl_HemmaKväll { get; set; }
        public virtual DbSet<tbl_Member> tbl_Member { get; set; }
        public virtual DbSet<tbl_Movie> tbl_Movie { get; set; }
    }
}
