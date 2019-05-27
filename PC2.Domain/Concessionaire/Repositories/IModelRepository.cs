using PC2.Domain.Concessionaire.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PC2.Domain.Concessionaire.Repositories
{
    public interface IModelRepository
    {
        Model GetById(Guid id);
        IEnumerable<Model> ListDistinct();
        IEnumerable<Model> List();
        void Save(Model model);
        void Update(Model model);
    }
}
