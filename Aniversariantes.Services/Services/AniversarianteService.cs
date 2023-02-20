using Aniversariantes.Domain.Entities;
using Aniversariantes.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aniversariantes.Services.Services
{
    public class AniversarianteService : IAniversariante
    {
        private readonly AniversariantesDbContext _dbContext;
        public AniversarianteService(AniversariantesDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<Aniversariante> GetAll()
        {
            return _dbContext.aniversariante.ToList();
        }

        public List<Aniversariante> GetSelected(List<int> selected)
        {
            return _dbContext.aniversariante.Where(pessoa => selected.Contains(pessoa.Id)).ToList();
        }
    }
}
