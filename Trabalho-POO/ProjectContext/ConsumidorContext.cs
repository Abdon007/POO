using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_POO.teste
{
    public class ConsumidorContext : DbContext {
        public DbSet<Consumidor> Consumidores {  get; set; }
    }
}
