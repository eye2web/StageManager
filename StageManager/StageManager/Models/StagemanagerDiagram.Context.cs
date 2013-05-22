﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StageManager.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class stagemanagerEntities : DbContext
    {
        public stagemanagerEntities()
            : base("name=stagemanagerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<adressets> adressets { get; set; }
        public DbSet<algemeensets> algemeensets { get; set; }
        public DbSet<bedrijfsbegeleidersets> bedrijfsbegeleidersets { get; set; }
        public DbSet<bedrijfsets> bedrijfsets { get; set; }
        public DbSet<docentsets> docentsets { get; set; }
        public DbSet<opleidingsets> opleidingsets { get; set; }
        public DbSet<persoonsets> persoonsets { get; set; }
        public DbSet<stagesets> stagesets { get; set; }
        public DbSet<studentsets> studentsets { get; set; }
        public DbSet<webkeysets> webkeysets { get; set; }
        public DbSet<academiesets> academiesets { get; set; }
        public DbSet<coordinator> coordinator { get; set; }
        public DbSet<eindstagesets> eindstagesets { get; set; }
        public DbSet<kennisgebiedset> kennisgebiedset { get; set; }
    
        public virtual int SearchAlgemeenSet(string in_searchQuery)
        {
            var in_searchQueryParameter = in_searchQuery != null ?
                new ObjectParameter("in_searchQuery", in_searchQuery) :
                new ObjectParameter("in_searchQuery", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SearchAlgemeenSet", in_searchQueryParameter);
        }
    
        public virtual int SearchDocentSet()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SearchDocentSet");
        }
    
        public virtual int SearchStudentSet()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("SearchStudentSet");
        }
    }
}
