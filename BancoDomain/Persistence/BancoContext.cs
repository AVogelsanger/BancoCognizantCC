using BancoInfra.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BancoInfra.Persistence
{
    public class BancoContext : DbContext
    {
        public BancoContext() : base("BancoContext") { }

        public DbSet<ContaCorrente> ContasCorrentes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}