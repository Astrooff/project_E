﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace project_E
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class progect_EEntities9 : DbContext
    {
        public progect_EEntities9()
            : base("name=progect_EEntities9")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AgentsSet> AgentsSet { get; set; }
        public virtual DbSet<ClientsSet> ClientsSet { get; set; }
        public virtual DbSet<RealEstateSet> RealEstateSet { get; set; }
    }
}
