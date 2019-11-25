﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Ce code a été généré à partir d'un modèle.
//
//    Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//    Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eco_Colocation.Controllers
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EcoColocationModelContainer : DbContext
    {
        public EcoColocationModelContainer()
            : base("name=EcoColocationModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AnnonceLocation> AnnonceLocation { get; set; }
        public DbSet<ChambreLocation> ChambreLocation { get; set; }
        public DbSet<ProjetCreation> ProjetCreation { get; set; }
        public DbSet<Lieu> Lieu { get; set; }
        public DbSet<Evenement> Evenement { get; set; }
        public DbSet<EvenementPresence> EvenementPresence { get; set; }
        public DbSet<EcoColocExistante> EcoColocExistante { get; set; }
        public DbSet<ImageConversationDev> ImageConversationDev { get; set; }
        public DbSet<Colocataire> Colocataire { get; set; }
        public DbSet<ConversationDev> ConversationDev { get; set; }
        public DbSet<RechercheColocation> RechercheColocation { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Utilisateur> Utilisateur { get; set; }
        public DbSet<EvenementAssocie> EvenementAssocie { get; set; }
        public DbSet<Adhesion> Adhesion { get; set; }
        public DbSet<ImageEcoColocEx> ImageEcoColocEx { get; set; }
        public DbSet<ImageProjetCreation> ImageProjetCreation { get; set; }
        public DbSet<Agence> AgenceSet { get; set; }
    }
}
