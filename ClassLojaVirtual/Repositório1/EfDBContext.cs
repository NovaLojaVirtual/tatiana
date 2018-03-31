using ClassLojaVirtual.Entitades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ClassLojaVirtual.Repositório1
{
  public  class EfDBContext : DbContext
    {
        public EfDBContext():base("EfDBContext")
        {

        }

        public DbSet<Produtos> Produto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            
            modelBuilder.Entity<Produtos>().ToTable("Produtos");//lista de produtos na tabela
        }
         


    }
}
