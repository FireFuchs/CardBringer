﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CardBringer2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CardBringerDBEntities : DbContext
    {
        public CardBringerDBEntities()
            : base("name=CardBringerDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<karta> karta { get; set; }
        public virtual DbSet<korisnik> korisnik { get; set; }
        public virtual DbSet<kosharica> kosharica { get; set; }
        public virtual DbSet<oglas> oglas { get; set; }
        public virtual DbSet<uloga> uloga { get; set; }
        public virtual DbSet<wishlist> wishlist { get; set; }
    }
}
