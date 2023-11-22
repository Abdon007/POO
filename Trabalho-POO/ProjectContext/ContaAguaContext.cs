using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO.teste
{
    public class ContaAguaContext : DbContext
    {
        public DbSet<ContaAgua> ContasDeAgua { get; set; }
    }
}
