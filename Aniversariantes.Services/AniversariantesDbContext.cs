using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aniversariantes.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Aniversariantes.Services
{
    public class AniversariantesDbContext : DbContext
    {
        public AniversariantesDbContext (DbContextOptions<AniversariantesDbContext> options) : base(options)
        {
        }

        public DbSet<Aniversariante> aniversariante { get; set; }
    }
}
