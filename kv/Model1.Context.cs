﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kv
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KvntEntities2 : DbContext
    {
        public KvntEntities2()
            : base("name=KvntEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Agent> Agent { get; set; }
        public virtual DbSet<Extradition> Extradition { get; set; }
        public virtual DbSet<Material> Material { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<Shipment> Shipment { get; set; }
        public virtual DbSet<SummaryList> SummaryList { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
