using Aniversariantes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aniversariantes.Domain.Interfaces
{
    public interface IAniversariante
    {
        IList<Aniversariante> GetAll();
        List<Aniversariante> GetSelected(List<int> selected);
    }
}
