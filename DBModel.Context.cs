﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace myFirstApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sunilGarageDBEntities : DbContext
    {
        public sunilGarageDBEntities()
            : base("name=sunilGarageDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<item> items { get; set; }
        public virtual DbSet<job> jobs { get; set; }
        public virtual DbSet<mechanic> mechanics { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<jobItem> jobItems { get; set; }
    }
}
