using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aniversariantes.Services
{
    public class AniversariantesDbContextFactory : IDesignTimeDbContextFactory<AniversariantesDbContext>
    {
        public AniversariantesDbContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<AniversariantesDbContext>();
            optionBuilder.UseSqlServer(
            "Server=(localdb)\\mssqllocaldb;Database=AniversarianteContext;Trusted_Connection=True;MultipleActiveResultSets=true"
            );
            return new AniversariantesDbContext(optionBuilder.Options);
        }
    }
}
