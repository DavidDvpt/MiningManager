﻿using MiningManager.Model;
using System.Data.Entity;

namespace MiningManager.Repository
{
    public class MiningContext : DbContext
    {
        public MiningContext() : base("name=MiningDb")
        {
            //Database.SetInitializer<MiningContext>(new DropCreateDatabaseAlways<MiningContext>());
            //Database.SetInitializer<MiningContext>(new CreateDatabaseIfNotExists<MiningContext>());
            //Database.SetInitializer<MiningContext>(new DropCreateDatabaseIfModelChanges<Context>());
            Database.SetInitializer<MiningContext>(new SeedClass());
        }

        public DbSet<Commun> Communs { get; set; }
        public DbSet<InWorld> InWorlds { get; set; }
        public DbSet<Unstackable> Unstackables { get; set; }
        public DbSet<Tool> Tools { get; set; }

        public DbSet<Categorie> Categories { get; set; }
        public DbSet<Modele> Modeles { get; set; }
        public DbSet<Finder> Finders { get; set; }
        public DbSet<Excavator> Excavators { get; set; }
        public DbSet<Refiner> Refiners { get; set; }
        public DbSet<FinderAmplifier> FinderAmplifiers { get; set; }
        public DbSet<Enhancer> Enhancers { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<ToolAccessoire> ToolAccessoires { get; set; }
        public DbSet<PlanetMaterial> PlanetMaterials { get; set; }
        public DbSet<Refinable> Refinables { get; set; }
        public DbSet<Planet> Planets { get; set; }

        public DbSet<SearchMode> SearchModes { get; set; }
        public DbSet<Setup> Setups { get; set; }

        //public DbSet<StockMaterial> StockMaterials { get; set; }
        //public DbSet<TradeMaterial> TradeMaterials { get; set; }
        //public DbSet<TradeState> TradeStates { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Commun
            modelBuilder.Entity<Commun>().Property(e => e.Nom).HasMaxLength(50);

            // InWorld
            modelBuilder.Entity<InWorld>().Property(e => e.Value).HasPrecision(9, 5);

            // Unstackable
            modelBuilder.Entity<Unstackable>().Property(e => e.Decay).HasPrecision(7, 3);
            modelBuilder.Entity<Unstackable>().Property(e => e.Code).HasMaxLength(10);

            // Tool

            // Finder
            modelBuilder.Entity<Finder>().Property(e => e.Depth).HasPrecision(5, 1);
            modelBuilder.Entity<Finder>().Property(e => e.Range).HasPrecision(3, 1);

            // Excavator
            modelBuilder.Entity<Excavator>().Property(e => e.Efficienty).HasPrecision(3, 1);

            // Refiner

            // FinderAmplifier
            modelBuilder.Entity<FinderAmplifier>().Property(e => e.Coefficient).HasPrecision(4, 1);

            // Enhancer
            modelBuilder.Entity<Enhancer>().Property(e => e.BonusValue1).HasPrecision(4, 2);
            //modelBuilder.Entity<Enhancer>().Property(e => e.BonusValue2).HasPrecision(3, 1);
        }
    }
}
