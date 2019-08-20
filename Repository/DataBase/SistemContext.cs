using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Model;

namespace Repository.DataBase
{
    public class SistemaContext : DbContext
    {
        public SistemaContext()
        {
        }

        public SistemaContext(DbContextOptions<SistemaContext> options) : base(options)
        {

        }

        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        
    }
}

}
