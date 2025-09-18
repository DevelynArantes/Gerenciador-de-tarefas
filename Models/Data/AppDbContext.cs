using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MODULOAPI.Models.Data
{
    public class AppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Tarefa> Tarefas { get; set; }
    
        
    }
}
