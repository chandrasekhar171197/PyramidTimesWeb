﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PyramidTimesWeb
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class PyramidTimesWebEntities : DbContext
    {
        public PyramidTimesWebEntities()
            : base("name=PyramidTimesWebEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AdminEvent> AdminEvents { get; set; }
        public virtual DbSet<ContactData> ContactDatas { get; set; }
        public virtual DbSet<EventRegistration> EventRegistrations { get; set; }
        public virtual DbSet<PastEvent> PastEvents { get; set; }
        public virtual DbSet<SpeakerRegistration> SpeakerRegistrations { get; set; }
    }
}