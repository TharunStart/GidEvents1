﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EventManagement.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class eventsEntities1 : DbContext
    {
        public eventsEntities1()
            : base("name=eventsEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<bookinglist> bookinglists { get; set; }
        public virtual DbSet<eventlist> eventlists { get; set; }
        public virtual DbSet<feedback> feedbacks { get; set; }
        public virtual DbSet<user> users { get; set; }
    }
}