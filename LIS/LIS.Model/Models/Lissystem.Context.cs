﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LIS.Model.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LissystemEntities : DbContext
    {
        public LissystemEntities()
            : base("name=LissystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tblanalytic> tblanalytics { get; set; }
        public virtual DbSet<tblbill> tblbills { get; set; }
        public virtual DbSet<tblcollector> tblcollectors { get; set; }
        public virtual DbSet<tbldoctor> tbldoctors { get; set; }
        public virtual DbSet<tblequipement> tblequipements { get; set; }
        public virtual DbSet<tblmachine> tblmachines { get; set; }
        public virtual DbSet<tblorder> tblorders { get; set; }
        public virtual DbSet<tblpatient> tblpatients { get; set; }
        public virtual DbSet<tblpatienttestresult> tblpatienttestresults { get; set; }
        public virtual DbSet<tblpurchase> tblpurchases { get; set; }
        public virtual DbSet<tblrecord> tblrecords { get; set; }
        public virtual DbSet<tblrole> tblroles { get; set; }
        public virtual DbSet<tblsupplier> tblsuppliers { get; set; }
        public virtual DbSet<tbltestmaster> tbltestmasters { get; set; }
        public virtual DbSet<tbluser> tblusers { get; set; }
    }
}
