﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gsbRapports2
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gsbrapports2021Entities : DbContext
    {
        public gsbrapports2021Entities()
            : base("name=gsbrapports2021Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<famille> familles { get; set; }
        public virtual DbSet<medecin> medecins { get; set; }
        public virtual DbSet<medicament> medicaments { get; set; }
        public virtual DbSet<offrir> offrirs { get; set; }
        public virtual DbSet<rapport> rapports { get; set; }
        public virtual DbSet<visiteur> visiteurs { get; set; }
    }
}
